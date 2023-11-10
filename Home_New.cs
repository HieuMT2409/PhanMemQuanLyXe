using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThueXeOTo
{
    public partial class Home_New : Form
    {
        DanhSachXe danhSachXe = new DanhSachXe();
        Listcars listCar = new Listcars();
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

        //Danh Sách Xe
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            danhSachXe.TopLevel = false;
            panel1.Controls.Add(danhSachXe);
            danhSachXe.FormBorderStyle = FormBorderStyle.None;
            danhSachXe.Dock = DockStyle.Fill;
            listCar.Hide();
            danhSachXe.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            danhSachXe.TopLevel = false;
            panel1.Controls.Add(danhSachXe);
            danhSachXe.FormBorderStyle = FormBorderStyle.None;
            danhSachXe.Dock = DockStyle.Fill;
            listCar.Hide();
            danhSachXe.Show();
        }

        //Đơn Đặt Xe

        private void label4_Click(object sender, EventArgs e)
        {
            listCar.TopLevel = false;
            panel1.Controls.Add(listCar);
            listCar.FormBorderStyle = FormBorderStyle.None;
            listCar.Dock = DockStyle.Fill;
            danhSachXe.Hide();
            listCar.Show();
        }

        public void pictureBox5_Click(object sender, EventArgs e)
        {
            listCar.TopLevel = false;
            panel1.Controls.Add(listCar);
            listCar.FormBorderStyle = FormBorderStyle.None;
            listCar.Dock = DockStyle.Fill;
            danhSachXe.Hide();
            listCar.Show();
        }

       
    }
}
