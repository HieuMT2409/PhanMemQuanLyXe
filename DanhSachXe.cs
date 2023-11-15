using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ThueXeOTo.ControlCar;
using ThueXeOTo.ControlCars;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThueXeOTo
{
    public partial class DanhSachXe : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        public DanhSachXe()
        {
            InitializeComponent();
        }

        private void DanhSachXe_Load(object sender, EventArgs e)
        {
            dataCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    this.dataCar.DataSource = dataTable;
                    this.dataCar.Refresh();
                }
                connection.Close();
            }
        }

        private void dataCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars WHERE Company LIKE N'%" + txbSearch.Text + "%' OR Type LIKE N'%" + txbSearch.Text + "%' OR Name LIKE N'%" + txbSearch.Text + "%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    this.dataCar.DataSource = dataTable;
                }
                connection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();

            addCar.FormClosed += (s, args) => LoadData();

            addCar.ShowDialog();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataCar.SelectedRows[0];
            string id = selectedRow.Cells["Id"].Value.ToString();
            string name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            string type = selectedRow.Cells["typeDataGridViewTextBoxColumn"].Value.ToString();
            string company = selectedRow.Cells["companyDataGridViewTextBoxColumn"].Value.ToString();

            FixCar fixCar = new FixCar();
            fixCar.UpdateInfo(id, name, type, company);

            fixCar.FormClosed += (s, args) => LoadData();

            fixCar.ShowDialog();
        }

        private void LoadData()
        {
            dataCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Cars";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    this.dataCar.DataSource = dataTable;
                }
                connection.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "DELETE FROM Cars WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataGridViewRow selectedRow = dataCar.SelectedRows[0];
                    string id = selectedRow.Cells["Id"].Value.ToString();
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                    int rowCount = command.ExecuteNonQuery();
                    LoadData();
                }
                connection.Close();
            }
        }

        private void carBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void carDBContextBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void initDBcarBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
