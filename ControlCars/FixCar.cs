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
using ThueXeOTo.Database;

namespace ThueXeOTo.ControlCars
{
    public partial class FixCar : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        string ID;
        public FixCar()
        {
            InitializeComponent();
        }

        public void UpdateInfo(string id, string name, string type, string company, string price)
        {
            ID = id;
            txtName.Text = name;
            txtCompany.Text = company;
            cbType.Text = type;
            txtPrice.Text = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                context.UpdateCar(ID, txtName.Text, cbType.Text, txtCompany.Text, txtPrice.Text);

                this.Close();
            }
        }
    }
}
