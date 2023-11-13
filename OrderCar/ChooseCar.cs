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
        public ChooseCar()
        {
            InitializeComponent();
        }

        private void HideItem()
        {
            dataDetailCar.Hide();
            btnBack.Hide();
            btnChoose.Hide();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataDetailCar.SelectedRows[0];
            string name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();

            TinhNangXe tinhNangXe = new TinhNangXe();

            tinhNangXe.UpdateLabel(name);

            tinhNangXe.TopLevel = false;
            this.Controls.Add(tinhNangXe);
            tinhNangXe.FormBorderStyle = FormBorderStyle.None;
            tinhNangXe.Dock = DockStyle.Fill;
            HideItem();
            tinhNangXe.Show();
        }

        private void ChooseCar_Load(object sender, EventArgs e)
        {
            dataDetailCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listcars listcars = new Listcars();

            listcars.TopLevel = false;
            this.Controls.Add(listcars);
            listcars.FormBorderStyle = FormBorderStyle.None;
            listcars.Dock = DockStyle.Fill;
            HideItem();
            listcars.Show();
        }
    }
}
