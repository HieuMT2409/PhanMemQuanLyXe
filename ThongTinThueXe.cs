using Microsoft.Data.SqlClient;
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
            if(txtNameUser.Text == "" || txtXethue.Text =="" || txtSDT.Text == "" || cbPAY.Text == "")
            {
                if (txtSDT.TextLength != 10)
                {
                    MessageBox.Show("Thông tin số điện thoại không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Cần nhập đủ các thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

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
                    string query = "INSERT INTO Orders(NameUser, SDT, NameCar, TimeIn, TimeOut, TypePay, Address, Feature) VALUES (@nameuser, @sdt, @namecar, @timein, @timeout, @typepay, @address, @feature)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@nameuser", SqlDbType.NVarChar).Value = txtNameUser.Text;
                        command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = txtSDT.Text;
                        command.Parameters.Add("@namecar", SqlDbType.NVarChar).Value = txtXethue.Text;
                        command.Parameters.Add("@timein", SqlDbType.DateTime2).Value = dtIN.Text;
                        command.Parameters.Add("@timeout", SqlDbType.DateTime2).Value = dtOUT.Text;
                        command.Parameters.Add("@typepay", SqlDbType.NVarChar).Value = cbPAY.Text;
                        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;
                        command.Parameters.Add("@feature", SqlDbType.NVarChar).Value = combinedValues;

                        int rowCount = command.ExecuteNonQuery();

                        //Upload thành công thì cập nhật lại giá trị State của xe
                        if(rowCount > 0)
                        {
                            string updateQuery = "UPDATE Cars SET State = N'Đang cho thuê' WHERE Name = @namecar";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.Add("@namecar", SqlDbType.NVarChar).Value = txtXethue.Text;

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Home_New home_New = new Home_New();
                        home_New.LoadDanhSachXeForm();
                    }
                }
            }
        }
    }
}
