using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThueXeOTo.ControlCar;
using ThueXeOTo.ControlCars;
using ThueXeOTo.Database;

namespace ThueXeOTo
{
    public partial class DanhSachHoaDon : Form
    {

        public DanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            dataOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var cars = context.Orders.ToList();

                this.dataOrder.DataSource = cars;
                this.dataOrder.Refresh();
            }
        }

        public void Load_Data()
        {
            dataOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var cars = context.Orders.ToList();

                this.dataOrder.DataSource = cars;
                this.dataOrder.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void dataOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
