using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS586_Train_Database
{
    public partial class Form2 : Form
    {
        NpgsqlConnection conn;

        public Form2()
        {
            InitializeComponent();
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
            }
            else
            {
                return null;
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
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
                return;
            }

            // Create connection object
            conn = new NpgsqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT count(*) FROM train.user where email = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'", conn);
                Int64 count = (Int64)cmd.ExecuteScalar();
                if (count == 1)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong credential", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }

            }
            catch
            {
                MessageBox.Show("Unable to connect to database. Please make sure VPN is enabled and try again.", "ERROR: Unable to connect to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            }
        

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
