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
        TinhNangXe tinhNangXe = new TinhNangXe();

        public ChooseCar()
        {
            InitializeComponent();
        }

        public void UpdateLabel(string id, string name)
        {
            txtID.Text = id;
            txtName.Text = name;
        }

        private void ShowForm()
        {
            Home_New homeForm = this.ParentForm as Home_New;

            if (homeForm != null)
            {
                tinhNangXe.TopLevel = false;
                homeForm.panel1.Controls.Clear();
                homeForm.panel1.Controls.Add(tinhNangXe);
                tinhNangXe.FormBorderStyle = FormBorderStyle.None;
                tinhNangXe.Dock = DockStyle.Fill;
                tinhNangXe.UpdateLabel(txtID.Text, txtName.Text);
                tinhNangXe.Reset();
                tinhNangXe.Show();


            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataDetailCar.SelectedRows[0];
            string name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            string state = selectedRow.Cells["stateDataGridViewTextBoxColumn"].Value.ToString();

            if (state == "Trống")
            {
                tinhNangXe.UpdateLabel(name);

                ShowForm();
            }
            else
            {
                MessageBox.Show("Xe đang được thuê, vui lòng tham khảo loại khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ChooseCar_Load(object sender, EventArgs e)
        {
            dataDetailCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_New homeForm = this.ParentForm as Home_New;

            if (homeForm != null)
            {
                Listcars listcars = new Listcars();
                listcars.TopLevel = false;
                homeForm.panel1.Controls.Clear();
                homeForm.panel1.Controls.Add(listcars);
                listcars.FormBorderStyle = FormBorderStyle.None;
                listcars.Dock = DockStyle.Fill;
                listcars.Show();
            }
        }
    }
}
