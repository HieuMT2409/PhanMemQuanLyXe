using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataCar.SelectedRows[0];
            string name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();

            TinhNangXe tinhNangXe = new TinhNangXe();

            tinhNangXe.UpdateLabel(name);

            tinhNangXe.Show();
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
                }
            }
        }

        private void dataCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
