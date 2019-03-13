using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS586_Train_Database
{
    public partial class StationSearchForm : Form
    {
        NpgsqlConnection conn;

        public StationSearchForm(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void find_button_Click(object sender, EventArgs e)
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
    }
}
