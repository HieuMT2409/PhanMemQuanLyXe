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
    public partial class AddKH : Form
    {
        public AddKH()
        {
            InitializeComponent();
        }

        private void AddKH_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                context.AddCustomer(txtName.Text, txtSDT.Text, txtAddress.Text);

                this.Close();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
