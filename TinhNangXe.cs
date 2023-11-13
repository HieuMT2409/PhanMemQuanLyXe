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

namespace ThueXeOTo
{
    public partial class TinhNangXe : Form
    {
        public TinhNangXe()
        {
            InitializeComponent();
        }
        private void HideItem()
        {
            cbBando.Visible = false;
            cbCameraCaple.Visible = false;
            cbCambien.Visible = false;
            cbCuaso.Visible = false;
            cbUSB.Visible = false;
            cbNap.Visible = false;
            cb360.Visible = false;
            cbLop.Visible = false;
            cbGPS.Visible = false;
            cbVar.Visible = false;
            cbCameraHT.Visible = false;
            cbBluetooth.Visible = false;
            cbCanhbao.Visible = false;
            cbCameraLui.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtXe.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            rbAll.Visible = false;
            rbXang.Visible = false;
            rbDau.Visible = false;
            rbDien.Visible = false;
            button1.Visible = false;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void UpdateLabel(string label)
        {
            txtXe.Text = label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox chk = (CheckBox)control;
                    if (chk.Checked)
                    {
                        list.Add(chk.Text);
                    }
                }
                else if (control is RadioButton)
                {
                    RadioButton radio = (RadioButton)control;
                    if (radio.Checked)
                    {
                        list.Add((string)radio.Text);
                    }
                }
            }

            ThongTinThueXe thongTinThueXe = new ThongTinThueXe();

            thongTinThueXe.UpdateLabel(txtXe.Text);
            thongTinThueXe.UpdateData(list);

            thongTinThueXe.TopLevel = false;
            this.Controls.Add(thongTinThueXe);
            thongTinThueXe.FormBorderStyle = FormBorderStyle.None;
            thongTinThueXe.Dock = DockStyle.Fill;
            HideItem();
            thongTinThueXe.Show();
        }

        private void txtXe_Click(object sender, EventArgs e)
        {

        }

        private void rbDien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbUSB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
