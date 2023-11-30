using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThueXeOTo.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ThueXeOTo
{
    public partial class HoaDon : Form
    {
        private int orderID = -1;
        private List<string> list = new List<string>();
        public HoaDon()
        {
            InitializeComponent();

        }


        public void UpdateData(int id, string name)
        {
            using (var context = new CarDBContext())
            {
                var user = context.Customers.Where(customer => customer.ID == id);
                Customer customer = user.FirstOrDefault();

                //Xử lý việc hiển thị tên khách hàng khi chọn 2 xe trở lên
                comboBoxCustomers.SelectedItem = customer;
                comboBoxCustomers.Enabled = true;


                var query = context.Orders.Where(order => order.CustomerID == id && order.NameCar == name);

                Order order = query.FirstOrDefault();
                orderID = order.OrderID;
                Home_New homeForm = this.ParentForm as Home_New;

                homeForm.thongtinthuexe.AddCartoList(order.NameCar);
                list = homeForm.thongtinthuexe.GetCarlist();
                lbCar.Items.AddRange(list.ToArray());


                lbCar.SelectedIndexChanged -= lbCar_SelectedIndexChanged;
                lbCar.SelectedIndexChanged += lbCar_SelectedIndexChanged;
            }
        }

        private void lbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCar.SelectedItem != null)
            {
                LoadFeature();
            }
        }

        public void LoadFeature()
        {
            using (var context = new CarDBContext())
            {
                var feature = context.Orders.Where(order => order.NameCar == lbCar.SelectedItem.ToString());
                Order order = feature.FirstOrDefault();
                lbFeature.Items.Clear();
                lbFeature.Items.Add(order.Feature);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                // Upload thành công thì cập nhật lại giá trị State của xe
                List<string> allValues = new List<string>();

                foreach (var item in lbCar.Items)
                {
                    var car = context.Cars.FirstOrDefault(c => c.Name == item.ToString());
                    if (car != null)
                    {
                        car.State = "Đang cho thuê";
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home_New homeForm = this.ParentForm as Home_New;
                homeForm.LoadDanhSachHoaDonForm();


            }
        }

        public void LoadListCarForm()
        {
            Listcars listcars = new Listcars();
            Home_New homeForm = this.ParentForm as Home_New;

            listcars.TopLevel = false;
            homeForm.panel1.Controls.Clear();
            homeForm.panel1.Controls.Add(listcars);
            listcars.FormBorderStyle = FormBorderStyle.None;
            listcars.Dock = DockStyle.Fill;

            Customer selectedCustomer = (Customer)this.comboBoxCustomers.SelectedItem;
            listcars.UpdateLabel(selectedCustomer.ID, selectedCustomer.Name);

            listcars.Show();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            LoadListCarForm();
        }

        public void LoadButton()
        {
            if (lbCar.Items != null)
            {
                btnChoose.Visible = false;
                Button button = new Button();
                button.Text = "TIếp tục chọn xe";
                button.Name = "bntContinue";
                button.Size = new System.Drawing.Size(130, 52);
                button.Location = new System.Drawing.Point(34, 523);

                button.Click += new EventHandler(NewButton_Click);

                this.Controls.Add(button);
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var customersList = context.Customers.ToList();

                comboBoxCustomers.DataSource = customersList;
                comboBoxCustomers.DisplayMember = "Name";
                comboBoxCustomers.ValueMember = "ID";
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
