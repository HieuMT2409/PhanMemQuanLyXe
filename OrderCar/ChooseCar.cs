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
    public partial class ChooseCar : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        public ChooseCar()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataDetailCar.SelectedRows[0];
            string name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();

            TinhNangXe tinhNangXe = new TinhNangXe();

            tinhNangXe.UpdateLabel(name);

            tinhNangXe.Show();
        }

        private void ChooseCar_Load(object sender, EventArgs e)
        {
            dataDetailCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listcars listcars = new Listcars();
            this.Hide();
            listcars.ShowItem();
        }
    }
}
