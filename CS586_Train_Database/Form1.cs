using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS586_Train_Database
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private async void connect_button_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                // Build connection string
                NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
                builder.Host = "dbclass.cs.pdx.edu";
                builder.Database = "w19wdb19";
                builder.Username = "w19wdb19";
                builder.Passfile = GetPassfilePath();
                builder.SslMode = SslMode.Require;
                builder.TrustServerCertificate = true;

                // Check for password file
                if (builder.Passfile == null)
                {
                    MessageBox.Show(@"PostgreSQL password file not found! Please create a password file at %APPDATA%\postgresql\pgpass.conf (where %APPDATA% refers to the Application Data subdirectory in the user's profile).", "ERROR: No password file found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status_label.Text = "No password file!";
                    status_label.ForeColor = Color.Red;
                    return;
                }

                // Create connection object
                conn = new NpgsqlConnection(builder.ConnectionString);
            }

            update_status("Connecting...", Color.DarkKhaki);
            connect_button.Enabled = false;

            try
            {
                await conn.OpenAsync();
                update_status("Connected.", Color.Green);
                connect_button.Text = "Connected";
                load_stations_button.Enabled = true;
                find_button.Enabled = true;
                search_box.Enabled = true;
            }
            catch (NpgsqlException)
            {
                update_status("Unable to connect.", Color.Red);
                MessageBox.Show("Unable to connect to database. Please make sure VPN is enabled and try again.", "ERROR: Unable to connect to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect_button.Enabled = true;
            }
        }

        private string GetPassfilePath()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "postgresql", "pgpass.conf");
            if (File.Exists(path))
            {
                return path;
            }

            path = Path.Combine(Directory.GetCurrentDirectory(), "pgpass.conf");
            if (File.Exists(path))
            {
                return path;
            } else
            {
                return null;
            }
        }

        private void update_status(string message, Color? color = null)
        {
            status_label.Text = message;
            status_label.ForeColor = color ?? Color.Black;
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
    }
}
