﻿using System;
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
using ThueXeOTo.OrderCar;

namespace ThueXeOTo
{
    public partial class TinhNangXe : Form
    {
        ThongTinThueXe thongTinThueXe = new ThongTinThueXe();

        public TinhNangXe()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
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
                thongTinThueXe.TopLevel = false;
                homeForm.panel1.Controls.Clear();
                homeForm.panel1.Controls.Add(thongTinThueXe);
                thongTinThueXe.FormBorderStyle = FormBorderStyle.None;
                thongTinThueXe.Dock = DockStyle.Fill;
                thongTinThueXe.Show();
            }
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
            bool radioButtonChecked = false;

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
                        radioButtonChecked = true;
                    }
                }
            }

            if (!radioButtonChecked)
            {
                MessageBox.Show("Vui lòng chọn loại nhiên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            thongTinThueXe.Reset();
            thongTinThueXe.UpdateData(list);
            thongTinThueXe.UpdateInfo(txtID.Text, txtName.Text, txtXe.Text);
            ShowForm();
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
