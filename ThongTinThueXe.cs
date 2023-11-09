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
    public partial class ThongTinThueXe : Form
    {
        public ThongTinThueXe()
        {
            InitializeComponent();
        }

        private void ThongTinThueXe_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabel(string text)
        {
            txtXethue.Text = text;
        }

        public void UpdateData(List<string> data)
        {
            foreach (string item in data)
            {
                listBox1.Items.Add(item);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
