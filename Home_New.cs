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
using ThueXeOTo.OrderCar;

namespace ThueXeOTo
{
    public partial class Home_New : Form
    {
        DanhSachXe danhSachXe = new DanhSachXe();
        DanhSachHoaDon danhsachHoaDon = new DanhSachHoaDon();
        Listcars listcars = new Listcars();
        ThongTinThueXe thongtinthuexe = new ThongTinThueXe();
        ChooseCar chooseCar = new ChooseCar();
        public Home_New()
        {
            InitializeComponent();

            //render danh sách xe cho màn hình home
            danhSachXe.TopLevel = false;
            panel1.Controls.Add(danhSachXe);
            danhSachXe.FormBorderStyle = FormBorderStyle.None;
            danhSachXe.Dock = DockStyle.Fill;
            danhSachXe.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void UpdateLabel(string username)
        {
            user.Text = username;
        }

        // Danh sách hóa đơn
        public void LoadDanhSachHoaDonForm()
        {
            danhsachHoaDon.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(danhsachHoaDon);
            danhsachHoaDon.FormBorderStyle = FormBorderStyle.None;
            danhsachHoaDon.Dock = DockStyle.Fill;
            danhsachHoaDon.btnAdd.Click += DanhSachHoaDon_ButtonClick;

            danhsachHoaDon.dataOrder.CellDoubleClick += DataOrder_CellDoubleClick;
            danhsachHoaDon.Show();
        }

        //List Car
        public void LoadListCarForm()
        {
            listcars.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(listcars);
            listcars.FormBorderStyle = FormBorderStyle.None;
            listcars.Dock = DockStyle.Fill;
            listcars.Show();
        }

        private void DanhSachHoaDon_ButtonClick(object sender, EventArgs e)
        {
            LoadListCarForm();
        }

        private void DataOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = danhsachHoaDon.dataOrder.SelectedRows[0];
            string id = selectedRow.Cells["IdOrder"].Value.ToString();
            string name = selectedRow.Cells["nameUserDataGridViewTextBoxColumn"].Value.ToString();
            string sdt = selectedRow.Cells["sDTDataGridViewTextBoxColumn"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string nameCar = selectedRow.Cells["nameCarDataGridViewTextBoxColumn"].Value.ToString();
            string feature = selectedRow.Cells["Feature"].Value.ToString();
            string timein = selectedRow.Cells["TimeIn"].Value.ToString();
            string timeout = selectedRow.Cells["TimeOut"].Value.ToString();
            string pay = selectedRow.Cells["typePayDataGridViewTextBoxColumn"].Value.ToString();

            ThongTinHoaDon thongTinHoaDon = new ThongTinHoaDon();

            thongTinHoaDon.UpdateData(id, name, sdt, address, nameCar, feature, timein, timeout, pay);
            thongTinHoaDon.Show();

        }

        //Danh Sách Xe
        public void LoadDanhSachXeForm()
        {
            danhSachXe.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(danhSachXe);
            danhSachXe.FormBorderStyle = FormBorderStyle.None;
            danhSachXe.Dock = DockStyle.Fill;
            danhSachXe.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadDanhSachXeForm();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            LoadDanhSachXeForm();
        }

        //Đơn Đặt Xe

        private void label4_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDonForm();
        }

        public void pictureBox5_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDonForm();
        }

        //Thông tin thuê xe
        public void LoadThongTinXeForm()
        {
            thongtinthuexe.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(thongtinthuexe);
            thongtinthuexe.FormBorderStyle = FormBorderStyle.None;
            thongtinthuexe.Dock = DockStyle.Fill;
            thongtinthuexe.Show();
        }
    }
}
