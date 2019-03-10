using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            if (conn != null && conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private void load_stations_button_Click(object sender, EventArgs e)
        {
            using (var cmd = new NpgsqlCommand("SELECT * FROM train.station", conn))
            {
                DataSet ds = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                grid.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                search();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void search()
        {
            string search = search_box.Text;

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM train.station WHERE UPPER(code) = UPPER(@code) OR name ILIKE '%' || @name || '%' OR city ILIKE '%' || @city || '%'";
                cmd.Parameters.AddWithValue("city", search);
                cmd.Parameters.AddWithValue("code", search);
                cmd.Parameters.AddWithValue("name", search);
                DataSet ds = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                grid.DataSource = ds.Tables[0];
            }
        }

        private void search_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
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
        }

        private void station_select_Click(object sender, EventArgs e)
        {
            trains_listBox.Items.Clear();
            selected_station = (string) stations_listBox.SelectedValue;

            using (WebClient wc = new WebClient())
            {
                wc.QueryString["station"] = selected_station;
                string data = wc.DownloadString("https://asm.transitdocs.com/api/stationDepartures.php");

                StationDepartures departures = JsonConvert.DeserializeObject<StationDepartures>(data);
                foreach (Train t in departures.trains)
                {
                    if (t.Number == selected_route)
                        trains_listBox.Items.Add(t);
                }
            }

            trains_group.Visible = true;
        }

        private void train_select_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allow the user to create an alert", "Create alert");
        }
    }
}
