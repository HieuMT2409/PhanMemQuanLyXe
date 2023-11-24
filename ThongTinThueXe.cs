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
using ThueXeOTo.Database;
using ThueXeOTo.KhachHang;
using ThueXeOTo.OrderCar;

namespace ThueXeOTo
{
    public partial class ThongTinThueXe : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        public ThongTinThueXe()
        {
            InitializeComponent();
        }

        private void ThongTinThueXe_Load(object sender, EventArgs e)
        {
        }

        public void UpdateLabel(string text)
        {
            txtXethue.Text = text;
        }

        public void UpdateInfo(int id, string name)
        {
            using (var context = new CarDBContext())
            {
                var query = context.Customers.Where(customer => customer.ID == id);

                Customer result = query.FirstOrDefault();


                txtNameUser.Text = result.Name;
                txtSDT.Text = result.SDT;
                txtAddress.Text = result.Address;
            }
        }

        public void UpdateData(List<string> data)
        {
            foreach (string item in data)
            {
                lbFeature.Items.Add(item);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void LoadDanhSachXeForm()
        {
            Home_New homeForm = this.ParentForm as Home_New;

            if (homeForm != null)
            {
                DanhSachHoaDon xe = new DanhSachHoaDon();

                xe.TopLevel = false;
                homeForm.panel1.Controls.Clear();
                homeForm.panel1.Controls.Add(xe);
                xe.FormBorderStyle = FormBorderStyle.None;
                xe.Dock = DockStyle.Fill;
                xe.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lấy thông tin của Listbox
            List<string> allValues = new List<string>();

            foreach (var item in lbFeature.Items)
            {
                allValues.Add(item.ToString());
            }
            string combinedValues = string.Join(", ", allValues);

            //Kiểm tra yêu cầu nhập đủ các trường dữ liệu
            if (txtNameUser.Text == "" || txtXethue.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Cần nhập đủ các thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Kiểm tra thời gian checkin checkout
                DateTime checkin = dtIN.Value;
                DateTime checkout = dtOUT.Value;

                if (checkout <= checkin)
                {
                    MessageBox.Show("Thời gian checkout phải lớn hơn thời gian checkin. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(conectionString))
                    {
                        connection.Open();

                        // Truy vấn dữ liệu
                        string query = "INSERT INTO Orders(NameUser, NameCar, TimeIn, TimeOut, Feature) VALUES (@nameuser, @namecar, @timein, @timeout, @feature)";
                        string query1 = "INSERT INTO Customers(Name, SDT, Address) VALUES (@nameuser, @sdt, @address)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.Add("@nameuser", SqlDbType.NVarChar).Value = txtNameUser.Text;
                            command.Parameters.Add("@namecar", SqlDbType.NVarChar).Value = txtXethue.Text;
                            command.Parameters.Add("@timein", SqlDbType.DateTime2).Value = dtIN.Text;
                            command.Parameters.Add("@timeout", SqlDbType.DateTime2).Value = dtOUT.Text;
                            command.Parameters.Add("@feature", SqlDbType.NVarChar).Value = combinedValues;

                            int rowCount = command.ExecuteNonQuery();

                            using (SqlCommand insertCustomer = new SqlCommand(query1, connection))
                            {
                                insertCustomer.Parameters.Add("@nameuser", SqlDbType.NVarChar).Value = txtNameUser.Text;
                                insertCustomer.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = txtSDT.Text;
                                insertCustomer.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;

                                insertCustomer.ExecuteNonQuery();
                            }

                            //Upload thành công thì cập nhật lại giá trị State của xe
                            if (rowCount > 0)
                            {
                                string updateQuery = "UPDATE Cars SET State = N'Đang cho thuê' WHERE Name = @namecar";

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.Add("@namecar", SqlDbType.NVarChar).Value = txtXethue.Text;

                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDanhSachXeForm();
                        }
                        connection.Close();
                    }
                }
            }

        }
    }
}
