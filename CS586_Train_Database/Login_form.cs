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
    public partial class Login_form : Form
    {
        NpgsqlConnection conn;
        Main_form main_form;

        public Login_form()
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

        private async void Login_button_Click(object sender, EventArgs e)
        {
            Login_btn.Enabled = false;
            NewUser_btn.Enabled = false;
            loading_picture.Visible = true;

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
                await conn.OpenAsync();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM train.user WHERE email = @email AND password = @password", conn);
                cmd.Parameters.AddWithValue("email", email_txt.Text);
                cmd.Parameters.AddWithValue("password", Password_txt.Text);

                Int64 count = (Int64)cmd.ExecuteScalar();
                if (count == 1)
                {
                    main_form = new Main_form(conn);
                    Close();
                    main_form.Show();
                }
                else
                {
                    MessageBox.Show("Wrong credential", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to database. Please make sure VPN is enabled and try again.\n" + ex.Message, "ERROR: Unable to connect to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            finally
            {
                Login_btn.Enabled = true;
                NewUser_btn.Enabled = true;
                loading_picture.Visible = false;
            }
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            Hide();
            Registration_form Reg1 = new Registration_form();
            Reg1.ShowDialog();
            Show();
        }

        private void Login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main_form == null)
            {
                Application.Exit();
            }
        }
    }
}
