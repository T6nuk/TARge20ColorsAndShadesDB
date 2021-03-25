using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsAndShadesDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorsAndShadesDB.Properties.Settings.ColorsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateColorsTable();
        }

        private void PopulateColorsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrimaryColor", connection))
            {
                DataTable ColorTable = new DataTable();
                adapter.Fill(ColorTable);

                Primary_colors_list.DisplayMember = "primary_color";
                Primary_colors_list.ValueMember = "Id";
                Primary_colors_list.DataSource = ColorTable;
            }
        }

        public void PopulateShadesTable()
        {
            string query = "SELECT Shades.Name FROM Shades INNER JOIN PrimaryColor ON Shades.PrimaryId = PrimaryColor.Id WHERE PrimaryColor.Id = @PrimaryId";
            using(connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PrimaryId", Primary_colors_list.SelectedValue);
                DataTable ShadesNameTable = new DataTable();
                adapter.Fill(ShadesNameTable);

                Shades_list.DisplayMember = "Name";
                Shades_list.ValueMember = "Id";
                Shades_list.DataSource = ShadesNameTable;
            }
        }



        private void Primary_colors_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateShadesTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
