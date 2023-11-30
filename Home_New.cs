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
using ThueXeOTo.Input_Output;
using ThueXeOTo.KhachHang;
using ThueXeOTo.LichTrinh;
using ThueXeOTo.OrderCar;
using ThueXeOTo.Report;

namespace ThueXeOTo
{
    public partial class Home_New : Form
    {

        public DanhSachXe danhSachXe = new DanhSachXe();
        public DanhSachHoaDon danhsachHoaDon = new DanhSachHoaDon();
        public HoaDon hoaDon = new HoaDon();
        public Listcars listcars = new Listcars();
        public ThongTinThueXe thongtinthuexe = new ThongTinThueXe();
        public DanhSachKH danhSachKH = new DanhSachKH();
        public DanhSachLichTrinh danhSachLichTrinh = new DanhSachLichTrinh();
        public TinhNangXe tinhNangXe = new TinhNangXe();
        public BaoCaoThongKe thongKe = new BaoCaoThongKe();
        public InOut inOut = new InOut();
        public int count = 0;

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
            danhsachHoaDon.Load_Data();
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
            hoaDon.btnChoose.Click -= HoaDon_ButtonClick;
            hoaDon.btnChoose.Click += HoaDon_ButtonClick;
            hoaDon.Show();
        }

        private void DanhSachHoaDon_ButtonClick(object sender, EventArgs e)
        {
            count++;
            LoadHoaDonForm();
        }

        public void HoaDon_ButtonClick(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)hoaDon.comboBoxCustomers.SelectedItem;
            listcars.UpdateLabel(selectedCustomer.ID, selectedCustomer.Name);
            LoadListCarForm();
        }
        private void DataOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = danhsachHoaDon.dataOrder.SelectedRows[0];
            string id = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            string name = selectedRow.Cells["nameUserDataGridViewTextBoxColumn"].Value.ToString();
            string nameCar = selectedRow.Cells["nameCarDataGridViewTextBoxColumn"].Value.ToString();
            string feature = selectedRow.Cells["Feature"].Value.ToString();
            string timein = selectedRow.Cells["TimeIn"].Value.ToString();
            string timeout = selectedRow.Cells["TimeOut"].Value.ToString();

            ThongTinHoaDon thongTinHoaDon = new ThongTinHoaDon();

            thongTinHoaDon.UpdateData(id, name, nameCar, feature, timein, timeout);
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
            danhSachXe.Load_data();
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
            thongtinthuexe.Reset();
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
            danhSachLichTrinh.Load_Data();
            danhSachLichTrinh.Show();
        }

        //Tính năng xe
        public void LoadTinhNangForm()
        {
            tinhNangXe.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(tinhNangXe);
            tinhNangXe.FormBorderStyle = FormBorderStyle.None;
            tinhNangXe.Dock = DockStyle.Fill;
            tinhNangXe.Reset();
            tinhNangXe.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoadDanhSachLTForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadDanhSachLTForm();

        }

        //Báo cáo thống kê
        public void LoadThongKeForm()
        {
            thongKe.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(thongKe);
            thongKe.FormBorderStyle = FormBorderStyle.None;
            thongKe.Dock = DockStyle.Fill;
            thongKe.LoadData();
            thongKe.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadThongKeForm();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoadThongKeForm();
        }

        //Nhập - Xuất dữ liệu
        public void LoadInOutForm()
        {
            inOut.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(inOut);
            inOut.FormBorderStyle = FormBorderStyle.None;
            inOut.Dock = DockStyle.Fill;
            inOut.LoadData();
            inOut.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LoadInOutForm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadInOutForm();
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
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
