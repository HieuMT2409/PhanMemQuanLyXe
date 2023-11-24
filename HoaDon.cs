using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThueXeOTo.Database;

namespace ThueXeOTo
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();

            using (CarDBContext context = new CarDBContext())
            {
                var customersList = context.Customers.ToList();

                comboBoxCustomers.DataSource = customersList;
                comboBoxCustomers.DisplayMember = "Name";
                comboBoxCustomers.ValueMember = "ID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
