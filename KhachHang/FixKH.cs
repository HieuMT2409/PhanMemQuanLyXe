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
using ThueXeOTo.Database;

namespace ThueXeOTo.KhachHang
{
    public partial class FixKH : Form
    {
        string ID;
        public FixKH()
        {
            InitializeComponent();
        }

        public void UpdateInfo(string id, string name, string sdt, string address)
        {
            ID = id;
            txtName.Text = name;
            txtSDT.Text = sdt;
            txtAddress.Text = address;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                context.UpdateCustomer(ID, txtName.Text, txtSDT.Text, txtAddress.Text);

                this.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtIN_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
