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
using ThueXeOTo.KhachHang;
using ThueXeOTo.LichTrinh;
using ThueXeOTo.OrderCar;

namespace ThueXeOTo
{
    public partial class Home_New : Form
    {
        DanhSachXe danhSachXe = new DanhSachXe();
        DanhSachHoaDon danhsachHoaDon = new DanhSachHoaDon();
        HoaDon hoaDon = new HoaDon();
        Listcars listcars = new Listcars();
        ThongTinThueXe thongtinthuexe = new ThongTinThueXe();
        DanhSachKH danhSachKH = new DanhSachKH();
        DanhSachLichTrinh danhSachLichTrinh = new DanhSachLichTrinh();
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

        private void Home_New_Load(object sender, EventArgs e)
        {
            danhSachXe.UpdateLabel(txtRole.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateLabel(string username)
        {
            txtRole.Text = username;
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

        //Listcar
        public void LoadListCarForm()
        {
            listcars.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(listcars);
            listcars.FormBorderStyle = FormBorderStyle.None;
            listcars.Dock = DockStyle.Fill;
            listcars.Show();
        }

        //Hóa đơn
        public void LoadHoaDonForm()
        {
            hoaDon.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(hoaDon);
            hoaDon.FormBorderStyle = FormBorderStyle.None;
            hoaDon.Dock = DockStyle.Fill;
            hoaDon.btnChoose.Click += HoaDon_ButtonClick;
            hoaDon.Show();
        }

        private void DanhSachHoaDon_ButtonClick(object sender, EventArgs e)
        {
            LoadHoaDonForm();
        }

        private void HoaDon_ButtonClick(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)hoaDon.comboBoxCustomers.SelectedItem;
            ThongTinThueXe thongTinThueXe = new ThongTinThueXe();
            thongTinThueXe.UpdateInfo(selectedCustomer.ID, selectedCustomer.Name);
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

        //Danh sách Khách hàng
        public void LoadDanhSachKHForm()
        {
            danhSachKH.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(danhSachKH);
            danhSachKH.FormBorderStyle = FormBorderStyle.None;
            danhSachKH.Dock = DockStyle.Fill;


            danhSachKH.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadDanhSachKHForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoadDanhSachKHForm();

        }


        //Danh sách lịch trình
        public void LoadDanhSachLTForm()
        {
            danhSachLichTrinh.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(danhSachLichTrinh);
            danhSachLichTrinh.FormBorderStyle = FormBorderStyle.None;
            danhSachLichTrinh.Dock = DockStyle.Fill;

            danhSachLichTrinh.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoadDanhSachLTForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadDanhSachLTForm();

        }

        private void txtRole_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
