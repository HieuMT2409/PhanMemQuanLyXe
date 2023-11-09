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
    public partial class TinhNangXe : Form
    {
        public TinhNangXe()
        {
            InitializeComponent();
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
                    if (chk.Checked )
                    {
                        list.Add(chk.Text);
                    }
                }else if (control is RadioButton) { 
                    RadioButton radio = (RadioButton)control;
                    if(radio.Checked)
                    {
                        list.Add((string)radio.Text);
                    }
                }
            }

            ThongTinThueXe thongTinThueXe = new ThongTinThueXe();

            thongTinThueXe.UpdateLabel(txtXe.Text);
            thongTinThueXe.UpdateData(list);

            thongTinThueXe.Show();
        }
    }
}
