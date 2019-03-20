using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace CS586_Train_Database
{
    public partial class Main_form : Form
    {
        NpgsqlConnection conn;

        int selected_route;
        string selected_station;
        string selected_departure;
        string user_email;

        public Main_form(NpgsqlConnection conn, string user_email)
        {
            InitializeComponent();
            this.conn = conn;
            this.user_email = user_email;
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

            Application.Exit();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            // Delete old trains
            using (var cmd = new NpgsqlCommand("train.delete_old_trains", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }

            // Populate routes
            using (var cmd = new NpgsqlCommand("SELECT number || ' - ' || name AS display, number FROM train.route WHERE name != 'Corridor' ORDER BY number", conn))
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);

                routes_listBox.DisplayMember = "display";
                routes_listBox.ValueMember = "number";
                routes_listBox.DataSource = dt;
            }

            // Check for alerts
            check_alerts();

            // Populate alerts
            populate_alerts();
        }

        private void route_select_Click(object sender, EventArgs e)
        {
            selected_route = Convert.ToInt32(routes_listBox.SelectedValue);

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM train.station JOIN train.stop ON stop.station = station.code WHERE stop.route = @route ORDER BY stop_order";
                cmd.Parameters.AddWithValue("route", selected_route);

                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);

                stations_listBox.DisplayMember = "name";
                stations_listBox.ValueMember = "code";
                stations_listBox.DataSource = dt;
            }

            stations_group.Visible = true;
        }

        private async void station_select_Click(object sender, EventArgs e)
        {
            station_select.Enabled = false;
            loading_picture.Visible = true;
            trains_listBox.Items.Clear();
            selected_station = (string) stations_listBox.SelectedValue;
            List<Train> trains = new List<Train>();

            // Check if data in database
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM train.train JOIN train.route ON train.route = route.number WHERE train.route = @route AND train.station = @station";
                cmd.Parameters.AddWithValue("route", selected_route);
                cmd.Parameters.AddWithValue("station", selected_station);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Train t = new Train();
                            //t.Destination_code = reader.GetString(0);

                            if (!reader.IsDBNull(1))
                                t.Lat = reader.GetDouble(1);

                            if (!reader.IsDBNull(2))
                                t.Lon = reader.GetDouble(2);

                            t.Number = reader.GetInt16(3);
                            t.Speed = reader.GetDouble(4);
                            t.Miles = reader.GetInt32(5);

                            if (!reader.IsDBNull(6))
                                t.Heading = reader.GetString(6);

                            //t.Or_Date = DateTime.ParseExact(reader.GetString(7), "yyyyMMdd", CultureInfo.InvariantCulture);
                            t.Or_Date = reader.GetString(7);

                            if (!reader.IsDBNull(8))
                                t.Sch_arr = reader.GetString(8);

                            if (!reader.IsDBNull(9))
                                t.Sch_dep = reader.GetString(9);

                            t.Name = (string)reader["name"];
                            t.Est_arr = (string)reader["estimated_arrival"];

                            if (!(reader["estimated_departure"] == DBNull.Value))
                                t.Est_dep = (string)reader["estimated_departure"];
                            t.Is_enroute = (bool)reader["is_enroute"];

                            t.Local_date = (string)reader["local_date"];

                            // Check if data is recent
                            if (reader.GetDateTime(10).Subtract(DateTime.Now).Duration().TotalMinutes < 30)
                            {
                                trains.Add(t);
                            }
                        }
                    }
                }
            }

            // Data not cached, retrieve from internet
            if (trains.Count == 0) {
                using (WebClient wc = new WebClient())
                {
                    wc.QueryString["station"] = selected_station;
                    string data = await wc.DownloadStringTaskAsync("https://asm.transitdocs.com/api/stationDepartures.php");

                    StationDepartures departures = JsonConvert.DeserializeObject<StationDepartures>(data);
                    trains = new List<Train>(departures.Trains);
                }

                // Upload values to database
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO train.train (station, lat, lon, route, speed, miles, heading, origin_date, scheduled_arrival, scheduled_departure, estimated_arrival, estimated_departure, is_enroute, local_date) VALUES (@station, @lat, @lon, @route, @speed, @miles, @heading, @origin_date, @sched_arr, @sched_dep, @est_arr, @est_dep, @enroute, @local_date)";
                    //cmd.Prepare();

                    foreach (Train t in trains)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("station", selected_station);
                        cmd.Parameters.AddWithValue("lat", t.Lat);
                        cmd.Parameters.AddWithValue("lon", t.Lon);
                        cmd.Parameters.AddWithValue("route", t.Number);
                        cmd.Parameters.AddWithValue("speed", t.Speed);
                        cmd.Parameters.AddWithValue("miles", t.Miles);
                        cmd.Parameters.AddWithValue("heading", (object) t.Heading ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("origin_date", t.Or_Date);
                        cmd.Parameters.AddWithValue("sched_arr", (object)t.Sch_arr ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("sched_dep", (object)t.Sch_dep ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("est_arr", (object)(t.Est_arr ?? t.Act_arr) ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("est_dep", (object)(t.Est_dep ?? t.Act_dep) ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("enroute", t.Is_enroute);
                        cmd.Parameters.AddWithValue("local_date", t.Local_date);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            trains.Sort(delegate(Train t1, Train t2) { return t1.Or_Date.CompareTo(t2.Or_Date); });

            foreach (Train t in trains)
            {
                if (t.Number == selected_route)
                    trains_listBox.Items.Add(t);
            }

            loading_picture.Visible = false;
            trains_group.Visible = true;
            station_select.Enabled = true;
        }

        private void train_select_Click(object sender, EventArgs e)
        {
            if (trains_listBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a train.", "No train selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            details_groupBox.Visible = true;
            Train train = (Train) trains_listBox.SelectedItem;
            selected_departure = train.Or_Date;

            // Get station information
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT city || ', ' || state FROM train.station WHERE code = @code";
                cmd.Parameters.AddWithValue("code", selected_station);

                string location = (string) cmd.ExecuteScalar();
                train_city_label.Text = location;
            }

            route_name_label.Text = train.Name;
            route_number_label.Text = train.Number.ToString();
            miles_travelled_label.Text = train.Miles.ToString();
            coordinates_label.Text = train.Lat + ", " + train.Lon;
            direction_label.Text = train.Heading;
            speed_label.Text = train.Speed.ToString();
            estimated_arrival_label.Text = train.Is_enroute ? train.Est_arr : train.Est_dep;
            label9.Text = train.Is_enroute ? "Estimated arrival:" : "Actual arrival:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StationSearchForm stationSearch = new StationSearchForm(conn);
            stationSearch.ShowDialog(this);
        }

        private void populate_alerts()
        {
            using (var cmd = new NpgsqlCommand("SELECT train_route || ' ' ||  train_station || ' ' || local_date || ' ' || type || ' ' || distance || ' minutes before' AS display FROM train.alert JOIN train.train ON alert.train_station = train.station AND alert.train_route = train.route AND alert.train_departure = train.origin_date", conn))
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);

                alerts_listBox.DisplayMember = "display";
                //alerts_listBox.ValueMember = "display";
                alerts_listBox.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AlertDialog alert = new AlertDialog())
            {
                alert.ShowDialog(this);
                if (alert.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO train.alert (type, distance, user_email, train_station, train_route, train_departure) VALUES (@type, @distance, @email, @station, @route, @departure)";

                            cmd.Parameters.AddWithValue("type", alert.Type);
                            cmd.Parameters.AddWithValue("distance", alert.Minutes);
                            cmd.Parameters.AddWithValue("email", user_email);
                            cmd.Parameters.AddWithValue("station", selected_station);
                            cmd.Parameters.AddWithValue("route", selected_route);
                            cmd.Parameters.AddWithValue("departure", selected_departure);
                            cmd.ExecuteNonQuery();
                        }
                    } catch (PostgresException ex)
                    {
                        MessageBox.Show("Alert already created!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            populate_alerts();   
        }

        void check_alerts()
        {
            int route = 0;
            string departure = "";
            string station = "";
            int distance = 0;
            string type = "";
            bool delete = false;

            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM train.alert JOIN train.train ON alert.train_station = train.station AND alert.train_route = train.route AND alert.train_departure = train.origin_date WHERE user_email = @email";
                cmd.Parameters.AddWithValue("email", user_email);

                // Get alerts
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string eta;

                        if (reader["estimated_arrival"] == DBNull.Value)
                        {
                            if (reader["estimated_departure"] == DBNull.Value)
                            {
                                continue;
                            } else
                            {
                                eta = (string)reader["estimated_departure"];
                            }
                        } else
                        {
                            eta = (string)reader["estimated_arrival"];
                        }
                        DateTime estimated_arrival = DateTime.ParseExact(eta, "h:mmtt", CultureInfo.InvariantCulture);
                        double minutes = estimated_arrival.Subtract(DateTime.Now).TotalMinutes;
                        station = (string)reader["station"];
                        distance = (int)reader["distance"];
                        if (minutes < distance)
                        {
                            route = reader.GetInt16(reader.GetOrdinal("route"));

                            MessageBox.Show($"Train {route} is {minutes:F1} minutes away from {station}");
                            departure = (string)reader["train_departure"];
                            type = (string)reader["type"];
                            delete = true;
                        }
                    }
                }
            }

            // Delete alert
            if (delete)
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM train.alert WHERE user_email = @email AND alert.train_station = @station AND alert.train_route = @route AND alert.train_departure = @departure AND alert.distance = @distance AND alert.type = @type";
                    cmd.Parameters.AddWithValue("email", user_email);
                    cmd.Parameters.AddWithValue("station", station);
                    cmd.Parameters.AddWithValue("departure", departure);
                    cmd.Parameters.AddWithValue("route", route);
                    cmd.Parameters.AddWithValue("distance", distance);
                    cmd.Parameters.AddWithValue("type", type);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
