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
        public Home_New()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DanhSachXe danhSachXe = new DanhSachXe();
            danhSachXe.TopLevel = false;
            panel1.Controls.Add(danhSachXe);
            danhSachXe.FormBorderStyle = FormBorderStyle.None;
            danhSachXe.Dock = DockStyle.Fill;
            danhSachXe.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DanhSachXe danhSachXe = new DanhSachXe();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TinhNangXe tinhNangXe = new TinhNangXe();

        }
    }
}
