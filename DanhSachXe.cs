using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
using System.Xml.Linq;
using ThueXeOTo.ControlCar;
using ThueXeOTo.ControlCars;
using ThueXeOTo.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThueXeOTo
{
    public partial class DanhSachXe : Form
    {
        public DanhSachXe()
        {
            InitializeComponent();
        }

        private void DanhSachXe_Load(object sender, EventArgs e)
        {
            dataCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                this.dataCar.DataSource = cars;
                this.dataCar.Refresh();
            }
        }

        public void UpdateLabel(string username)
        {
            txtRole.Text = username;
        }

        private void dataCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var query = from car in context.Cars
                            where EF.Functions.Like(car.Company, "%" + txbSearch.Text + "%")
                                  || EF.Functions.Like(car.Type, "%" + txbSearch.Text + "%")
                                  || EF.Functions.Like(car.Name, "%" + txbSearch.Text + "%")
                            select car;

                this.dataCar.DataSource = query.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            if (txtRole.Text == "admin")
            {
                AddCar addCar = new AddCar();

                addCar.FormClosed += (s, args) => LoadData();

                addCar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để thực hiện chức năng này. Vui lòng liên hệ quản trị viên để biết thêm thông tin!", "Không thể thực hiện chức năng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            Home_New home_New = new Home_New();
            if (txtRole.Text == "admin")
            {
                DataGridViewRow selectedRow = dataCar.SelectedRows[0];
                string id = selectedRow.Cells["Id"].Value.ToString();
                string name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                string type = selectedRow.Cells["typeDataGridViewTextBoxColumn"].Value.ToString();
                string company = selectedRow.Cells["companyDataGridViewTextBoxColumn"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();

                FixCar fixCar = new FixCar();
                fixCar.UpdateInfo(id, name, type, company, price);

                fixCar.FormClosed += (s, args) => LoadData();

                fixCar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để thực hiện chức năng này. Vui lòng liên hệ quản trị viên để biết thêm thông tin!", "Không thể thực hiện chức năng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadData()
        {
            dataCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                this.dataCar.DataSource = cars;
                this.dataCar.Refresh();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Home_New home_New = new Home_New();
            if (txtRole.Text == "admin")
            {
                using (var context = new CarDBContext())
                {
                    // Lấy ID của dòng được chọn trong DataGridView
                    if (dataCar.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataCar.SelectedRows[0];
                        if (selectedRow.Cells["Id"].Value != null)
                        {
                            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                            context.DeleteCar(id);

                            LoadData();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để thực hiện chức năng này. Vui lòng liên hệ quản trị viên để biết thêm thông tin!", "Không thể thực hiện chức năng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void carBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void carDBContextBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void initDBcarBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
