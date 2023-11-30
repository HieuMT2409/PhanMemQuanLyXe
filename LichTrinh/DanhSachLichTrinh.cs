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
using ThueXeOTo.OrderCar;

namespace ThueXeOTo.LichTrinh
{
    public partial class DanhSachLichTrinh : Form
    {
        public DanhSachLichTrinh()
        {
            InitializeComponent();

            dataLichTrinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var orders = context.Orders.ToList();

                this.dataLichTrinh.DataSource = orders;
            }
        }

        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataLichTrinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var orders = context.Orders.ToList();

                this.dataLichTrinh.DataSource = orders;
            }
        }

        public void Load_Data()
        {
            dataLichTrinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var orders = context.Orders.ToList();

                this.dataLichTrinh.DataSource = orders;
            }
        }

        private void DanhSachLichTrinh_Load(object sender, EventArgs e)
        {
            dataLichTrinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var orders = context.Orders.ToList();

                this.dataLichTrinh.DataSource = orders;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                // Lấy ID của dòng được chọn trong DataGridView
                if (dataLichTrinh.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataLichTrinh.SelectedRows[0];
                    if (selectedRow.Cells["OrderID"].Value != null)
                    {
                        int orderId = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);

                        ThanhToan thanhToan = new ThanhToan();
                        thanhToan.Update_Data(orderId);
                        thanhToan.ShowDialog();
                    }
                }
            }
        }
    }
}
