using Newtonsoft.Json;
using Npgsql;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace CS586_Train_Database
{
    public partial class Main_form : Form
    {
        NpgsqlConnection conn;

        int selected_route;
        string selected_station;

        public Main_form(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
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
            // Populate routes
            using (var cmd = new NpgsqlCommand("SELECT number || ' - ' || name AS display, number FROM train.route ORDER BY number", conn))
            {
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);

                routes_listBox.DisplayMember = "display";
                routes_listBox.ValueMember = "number";
                routes_listBox.DataSource = dt;
            }
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
            trains_group.Visible = false;
            details_groupBox.Visible = false;
        }

        private async void station_select_Click(object sender, EventArgs e)
        {
            station_select.Enabled = false;
            loading_picture.Visible = true;
            trains_listBox.Items.Clear();
            selected_station = (string) stations_listBox.SelectedValue;

            using (WebClient wc = new WebClient())
            {
                wc.QueryString["station"] = selected_station;
                string data = await wc.DownloadStringTaskAsync("https://asm.transitdocs.com/api/stationDepartures.php");

                StationDepartures departures = JsonConvert.DeserializeObject<StationDepartures>(data);
                foreach (Train t in departures.Trains)
                {
                    if (t.Number == selected_route)
                        trains_listBox.Items.Add(t);
                }
            }

            loading_picture.Visible = false;
            trains_group.Visible = true;
            station_select.Enabled = true;
            details_groupBox.Visible = false;
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

            route_name_label.Text = train.Name;
            route_number_label.Text = train.Number.ToString();
            miles_travelled_label.Text = train.Miles.ToString();
            coordinates_label.Text = train.Lat + ", " + train.Lon;
            direction_label.Text = train.Heading;
            speed_label.Text = train.Speed.ToString();
            updated_last_label.Text = train.Local_date;
            estimated_arrival_label.Text = train.Sch_arr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StationSearchForm stationSearch = new StationSearchForm(conn);
            stationSearch.ShowDialog(this);
        }
    }
}
