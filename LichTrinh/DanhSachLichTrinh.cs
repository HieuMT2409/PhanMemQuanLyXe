using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThueXeOTo.LichTrinh
{
    public partial class DanhSachLichTrinh : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";

        public DanhSachLichTrinh()
        {
            InitializeComponent();
        }

        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhSachLichTrinh_Load(object sender, EventArgs e)
        {
            dataLichTrinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Orders";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    this.dataLichTrinh.DataSource = dataTable;
                }
            }
        }
    }
}
