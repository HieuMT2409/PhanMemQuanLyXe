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
using static System.Net.Mime.MediaTypeNames;

namespace ThueXeOTo
{
    public partial class ThongTinThueXe : Form
    {
        private List<string> carLists = new List<string>();
        public ThongTinThueXe()
        {
            InitializeComponent();
        }

        private void ThongTinThueXe_Load(object sender, EventArgs e)
        {
        }

        public void Reset()
        {
            foreach (Control control in Controls)
            {
                if (control is ListBox listBox)
                {
                    listBox.Items.Clear();
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now; // Đặt lại ngày giờ mặc định (hoặc giá trị bạn muốn)
                }
            }
        }

        public List<string> GetCarlist()
        {
            return carLists;
        }

        public void AddCartoList(string name)
        {
            carLists.Add(name);
        }

        public void UpdateInfo(string id, string name, string nameCar)
        {
            using (var context = new CarDBContext())
            {
                var query = context.Customers.Where(customer => customer.ID == int.Parse(id) && customer.Name == name);

                Customer result = query.FirstOrDefault();

                txtNameUser.Text = result.Name;
                txtSDT.Text = result.SDT;
                txtAddress.Text = result.Address;

                txtXethue.Text = nameCar;
                txtID.Text = id;
            }
        }

        public string GetID()
        {
            return txtID.Text;
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

        public void LoadHoaDonForm(int id, string name)
        {
            Home_New homeForm = this.ParentForm as Home_New;

            if (homeForm != null)
            {
                HoaDon xe = new HoaDon();

                xe.TopLevel = false;
                homeForm.panel1.Controls.Clear();
                homeForm.panel1.Controls.Add(xe);
                xe.FormBorderStyle = FormBorderStyle.None;
                xe.Dock = DockStyle.Fill;
                MessageBox.Show(homeForm.count.ToString());
                if (homeForm.count >= 1)
                {
                    homeForm.hoaDon.lbCar.Items.Clear();
                }
                xe.UpdateData(id, name);
                xe.LoadButton();
                xe.Show();
            }
        }

        public void LoadDanhSachXeForm()
        {
            Home_New homeForm = this.ParentForm as Home_New;

            if (homeForm != null)
            {
                Listcars xe = new Listcars();

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
            // Lấy thông tin của Listbox
            List<string> allValues = new List<string>();

            foreach (var item in lbFeature.Items)
            {
                allValues.Add(item.ToString());
            }
            string combinedValues = string.Join(", ", allValues);

            // Kiểm tra yêu cầu nhập đủ các trường dữ liệu
            // Kiểm tra thời gian checkin checkout
            DateTime checkin = dtIN.Value;
            DateTime checkout = dtOUT.Value;

            if (checkout <= checkin)
            {
                MessageBox.Show("Thời gian checkout phải lớn hơn thời gian checkin. Vui lòng chọn lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var context = new CarDBContext())
                {
                    var order = new Order
                    {
                        NameUser = txtNameUser.Text,
                        NameCar = txtXethue.Text,
                        TimeIn = dtIN.Value,
                        TimeOut = dtOUT.Value,
                        CustomerID = int.Parse(txtID.Text),
                        Feature = combinedValues
                    };

                    context.Orders.Add(order);
                    context.SaveChanges();


                    LoadHoaDonForm(order.CustomerID, order.NameCar);
                }
            }
        }
    }
}
