using Npgsql;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
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
    /* This part is to validate email format, but won't work!
    public class RegexUtilities
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
            {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
    */
    public partial class Registration_form : Form
    {
        private NpgsqlConnection conn;
        private string Role;
        public Registration_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
        private void User_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Role = "User";
        }

        private void Admin_Rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Role = "Admin";
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (email_txt.Text == "" || Pass_txt.Text == "" || Name_txt.Text == "" || Phone_txt.Text == "")
                MessageBox.Show("Please fill all the rows indicated with red star");
            else if (Pass_txt.Text != PassConf_txt.Text)
                MessageBox.Show("Password confirmation doesn't match");
            else
            {
                // Build connection string
                NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
                builder.Host = "dbclass.cs.pdx.edu";
                builder.Database = "w19wdb19";
                builder.Username = "w19wdb19";
                builder.Passfile = GetPassfilePath();
                if (builder.Passfile == null)
                {
                    MessageBox.Show(@"PostgreSQL password file not found! Please create a password file at %APPDATA%\postgresql\pgpass.conf (where %APPDATA% refers to the Application Data subdirectory in the user's profile).", "ERROR: No password file found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                builder.SslMode = SslMode.Require;
                builder.TrustServerCertificate = true;
                using (var conn = new NpgsqlConnection(builder.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO train.user (email, password, name, phone,role) VALUES ('" + email_txt.Text + "', '" + Pass_txt.Text + "', '" + Name_txt.Text + "', '" + Phone_txt.Text + "', '" + Role + "');";
                        cmd.ExecuteNonQuery();
                    }
                }
                this.Close();
            }
        }
    }
}
