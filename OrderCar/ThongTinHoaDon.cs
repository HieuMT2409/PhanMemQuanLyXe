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

namespace ThueXeOTo.OrderCar
{
    public partial class ThongTinHoaDon : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";

        public ThongTinHoaDon()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void UpdateData(string id, string name, string sdt, string address, string namecar, string feature, string timein, string timeout, string typepay)
        {
            string[] elements = feature.Split(',');
            foreach (string element in elements)
            {
                lbFeature.Items.Add(element);
            }


            txthoadon.Text = "HÓA ĐƠN #" + id;
            txtName.Text = name;
            txtSDT.Text = sdt;
            txtAddress.Text = address;
            txtXethue.Text = namecar;
            txtTimeIn.Text = timein;
            txtTimeOut.Text = timeout;
            txtPay.Text = typepay;
        }

        private void ThongTinHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
