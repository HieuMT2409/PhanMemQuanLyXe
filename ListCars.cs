using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThueXeOTo.OrderCar;

namespace ThueXeOTo
{

    public partial class Listcars : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";

        public ChooseCar chooseCar = new ChooseCar();
        public Listcars()
        {
            InitializeComponent();
        }

        private void ShowForm()
        {
            Home_New homeForm = this.ParentForm as Home_New;

            if (homeForm != null)
            {
                chooseCar.TopLevel = false;
                homeForm.panel1.Controls.Clear();
                homeForm.panel1.Controls.Add(chooseCar);
                chooseCar.FormBorderStyle = FormBorderStyle.None;
                chooseCar.Dock = DockStyle.Fill;
                chooseCar.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Type = N'4 Chỗ (Mini)'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    chooseCar.dataDetailCar.DataSource = dataTable;
                }
            }

            ShowForm();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Type = N'4 Chỗ (Sedan)'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    chooseCar.dataDetailCar.DataSource = dataTable;
                }
            }
            ShowForm();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Type = N'4 Chỗ (Hatchback)'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    chooseCar.dataDetailCar.DataSource = dataTable;
                }
            }
            ShowForm();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Type = N'5 Chỗ (SUV Gầm cao)'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    chooseCar.dataDetailCar.DataSource = dataTable;
                }
            }
            ShowForm();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Type = N'7 Chỗ (SUV Gầm cao)'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    chooseCar.dataDetailCar.DataSource = dataTable;
                }
            }
            ShowForm();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Type = N'7 Chỗ (MPV Gầm thấp)'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    chooseCar.dataDetailCar.DataSource = dataTable;
                }
            }
            ShowForm();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Type = N'Bán tải'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    chooseCar.dataDetailCar.DataSource = dataTable;
                }
            }
            ShowForm();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
