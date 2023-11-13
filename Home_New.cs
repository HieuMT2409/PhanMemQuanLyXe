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
        public Home_New()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            danhSachXe.TopLevel = false;
            panel1.Controls.Add(danhSachXe);
            danhSachXe.FormBorderStyle = FormBorderStyle.None;
            danhSachXe.Dock = DockStyle.Fill;
            danhSachXe.Show();
        }

        public void UpdateLabel(string username)
        {
            user.Text = username;
        }

        public void LoadDanhSachXeForm()
        {
            danhSachXe.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(danhSachXe);
            danhSachXe.FormBorderStyle = FormBorderStyle.None;
            danhSachXe.Dock = DockStyle.Fill;
            danhSachXe.Show();
        }

        public void LoadDanhSachHoaDonForm()
        {
            danhsachHoaDon.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(danhsachHoaDon);
            danhsachHoaDon.FormBorderStyle = FormBorderStyle.None;
            danhsachHoaDon.Dock = DockStyle.Fill;
            danhsachHoaDon.Show();
        }

        //Danh Sách Xe
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

       
    }
}
