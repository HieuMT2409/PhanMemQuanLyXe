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
using ThueXeOTo.ControlCars;

namespace ThueXeOTo.KhachHang
{

    public partial class DanhSachKH : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        DanhSachXe danhSachXe = new DanhSachXe();
        DanhSachHoaDon danhSachHoaDon = new DanhSachHoaDon();


        public DanhSachKH()
        {
            InitializeComponent();
        }

        private void DanhSachKH_Load(object sender, EventArgs e)
        {
            dataKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    this.dataKH.DataSource = dataTable;
                }
                connection.Close();
            }

            this.Activated += (s, args) => LoadCars();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "SELECT * FROM Orders WHERE NameUser LIKE N'%" + txbSearch.Text + "%' OR SDT LIKE N'%" + txbSearch.Text + "%' OR Address LIKE N'%" + txbSearch.Text + "%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    this.dataKH.DataSource = dataTable;
                }
                connection.Close();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataKH.SelectedRows[0];
            string id = selectedRow.Cells["iDDataGridViewTextBoxColumn"].Value.ToString();
            string name = selectedRow.Cells["nameUserDataGridViewTextBoxColumn"].Value.ToString();
            string sdt = selectedRow.Cells["sDTDataGridViewTextBoxColumn"].Value.ToString();
            string address = selectedRow.Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
            string nameCar = selectedRow.Cells["nameCarDataGridViewTextBoxColumn"].Value.ToString();
            string timein = selectedRow.Cells["timeInDataGridViewTextBoxColumn"].Value.ToString();
            string timeout = selectedRow.Cells["timeOutDataGridViewTextBoxColumn"].Value.ToString();

            FixKH fixKH = new FixKH();
            fixKH.UpdateInfo(id, name, sdt, address, nameCar, timein, timeout);

            fixKH.FormClosed += (s, args) => LoadData();

            fixKH.ShowDialog();
        }

        private void LoadData()
        {
            dataKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhSachHoaDon.dataOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    this.dataKH.DataSource = dataTable;
                    danhSachHoaDon.dataOrder.DataSource = dataTable;
                }
                connection.Close();
            }
        }

        private void LoadCars()
        {
            Home_New homeForm = this.ParentForm as Home_New;
            if (homeForm != null)
            {
                homeForm.LoadDanhSachXeForm();
                /*danhSachXe.dataCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                        danhSachXe.dataCar.DataSource = dataTable;
                    }
                    connection.Close();
                }*/
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //kiểm tra ngày trả nếu bé hơn ngày hiện tại thì cho xóa
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Truy vấn xóa dữ liệu từ bảng Orders
                            string deleteQuery = "DELETE FROM Orders WHERE ID = @id";
                            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection, transaction))
                            {
                                DataGridViewRow selectedRow = dataKH.SelectedRows[0];
                                string id = selectedRow.Cells["iDDataGridViewTextBoxColumn"].Value.ToString();
                                string timeout = selectedRow.Cells["timeOutDataGridViewTextBoxColumn"].Value.ToString();

                                deleteCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

                                // Thực hiện xóa dữ liệu
                                if (DateTime.TryParse(timeout, out DateTime timeoutDateTime))
                                {
                                    DateTime currentDate = DateTime.Now;

                                    if (timeoutDateTime < currentDate)
                                    {
                                        int rowCount = deleteCommand.ExecuteNonQuery();

                                        // Kiểm tra số dòng bị ảnh hưởng (nếu là 0, có thể xem xét rollback)
                                        if (rowCount > 0)
                                        {
                                            // Truy vấn cập nhật giá trị State trong bảng Cars
                                            string updateQuery = "UPDATE Cars SET State = N'Trống' WHERE Name = @name AND State = N'Đang cho thuê'";
                                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                                            {
                                                string name = selectedRow.Cells["nameCarDataGridViewTextBoxColumn"].Value.ToString();

                                                updateCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                                                // Thực hiện cập nhật giá trị
                                                int updateRowCount = updateCommand.ExecuteNonQuery();

                                                // Kiểm tra số dòng bị ảnh hưởng (nếu là 0, có thể xem xét rollback)
                                                if (updateRowCount > 0)
                                                {
                                                    // Commit giao dịch nếu tất cả thành công
                                                    transaction.Commit();
                                                    MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    // Load lại dữ liệu của Cars
                                                    LoadCars();
                                                    danhSachXe.dataCar.Refresh();
                                                    // Load lại dữ liệu của Orders
                                                    LoadData();
                                                    danhSachHoaDon.dataOrder.Refresh();


                                                }
                                                else
                                                {
                                                    // Nếu cập nhật giá trị State không thành công, thực hiện rollback
                                                    transaction.Rollback();
                                                    MessageBox.Show("Cập nhật giá trị State không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // Nếu xóa dữ liệu từ bảng Orders không thành công, thực hiện rollback
                                            transaction.Rollback();
                                            MessageBox.Show("Xóa dữ liệu từ bảng Orders không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Khách hàng đang trong thời hạn thuê xe, Không thể xóa khách hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Xử lý ngoại lệ và thực hiện rollback
                            transaction.Rollback();
                            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
