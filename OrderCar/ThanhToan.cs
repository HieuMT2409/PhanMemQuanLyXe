using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ThueXeOTo.Database;
using ThueXeOTo.LichTrinh;

namespace ThueXeOTo.OrderCar
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {

        }

        public void Update_Data(int id)
        {
            using (var context = new CarDBContext())
            {
                var order = context.Orders.FirstOrDefault(c => c.OrderID == id);
                if (order != null)
                {
                    string[] elements = order.Feature.Split(',');
                    int count = elements.Length - 1;
                    double total = 0;

                    var car = context.Cars.FirstOrDefault(c => c.Name == order.NameCar);
                    string prices = car.Price;
                    string[] price = prices.Split(" ");
                    total = double.Parse(price[0]) * 1000000 + count * 200000;

                    for (var i = 1; i < elements.Length; i++)
                    {
                        lbFeature.Items.Add(elements[i] + ": 200,000 đồng ");
                    }

                    txtHoaDon.Text = "Hóa đơn #" + order.OrderID.ToString();
                    txtXe.Text = order.NameCar;
                    txtNhienlieu.Text = elements[0];
                    txtTotal.Text = total.ToString("N0") + " đồng";

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var order = context.Orders.FirstOrDefault(c => c.NameCar == txtXe.Text);
                if (order != null)
                {
                    //thêm thông tin vào doanh thu
                    var car = context.Cars.FirstOrDefault(c => c.Name == order.NameCar);

                    context.AddReport(order.NameCar, car.Company, car.Type, order.TimeIn, order.TimeOut, txtTotal.Text);

                    //chuyển trạng thái xe về lại Trống
                    var cars = context.Cars.Where(c => c.Name == order.NameCar && c.State == "Đang cho thuê");
                    foreach (var item in cars)
                    {
                        item.State = "Trống";
                    }

                    context.Orders.Remove(order);
                    context.SaveChanges();


                }
                DanhSachLichTrinh danhSachLichTrinh = new DanhSachLichTrinh();
                danhSachLichTrinh.Load_Data();
                this.Close();
            }
        }
    }
}
