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

namespace ThueXeOTo.KhachHang
{

    public partial class DanhSachKH : Form
    {
        DanhSachHoaDon danhSachHoaDon = new DanhSachHoaDon();


        public DanhSachKH()
        {
            InitializeComponent();
        }

        private void DanhSachKH_Load(object sender, EventArgs e)
        {
            dataKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var cars = context.Customers.ToList();

                this.dataKH.DataSource = cars;
                this.dataKH.Refresh();
            }

            this.Activated += (s, args) => LoadCars();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var query = from customer in context.Customers
                            where EF.Functions.Like(customer.Name, "%" + txbSearch.Text + "%")
                               || EF.Functions.Like(customer.SDT, "%" + txbSearch.Text + "%")
                               || EF.Functions.Like(customer.Address, "%" + txbSearch.Text + "%")
                            select customer;

                dataKH.DataSource = query.ToList();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataKH.SelectedRows[0];
            string id = selectedRow.Cells["ID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            string sdt = selectedRow.Cells["SDT"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();

            FixKH fixKH = new FixKH();
            fixKH.UpdateInfo(id, name, sdt, address);

            fixKH.FormClosed += (s, args) => LoadData();

            fixKH.ShowDialog();
        }

        private void LoadData()
        {
            dataKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var cars = context.Customers.ToList();

                this.dataKH.DataSource = cars;
                this.dataKH.Refresh();
            }
        }

        private void LoadCars()
        {
            Home_New homeForm = this.ParentForm as Home_New;
            if (homeForm != null)
            {
                homeForm.LoadDanhSachXeForm();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Home_New home_New = this.ParentForm as Home_New;
            if (home_New.txtRole.Text == "admin")
            {
                using (var context = new CarDBContext())
                {
                    // Lấy ID của dòng được chọn trong DataGridView
                    if (dataKH.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataKH.SelectedRows[0];
                        if (selectedRow.Cells["ID"].Value != null)
                        {
                            int customerId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                            // Gọi phương thức xóa trong DbContext
                            context.DeleteCustomerAndCar(customerId);

                            // Load lại dữ liệu sau khi xóa
                            LoadData();
                            danhSachHoaDon.dataOrder.Refresh();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để thực hiện chức năng này. Vui lòng liên hệ quản trị viên để biết thêm thông tin!", "Không thể thực hiện chức năng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void dataKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddKH addCustomer = new AddKH();

            addCustomer.FormClosed += (s, args) => LoadData();

            addCustomer.ShowDialog();
        }
    }
}
