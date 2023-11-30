using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ThueXeOTo.Database;

namespace ThueXeOTo.Report
{
    //Để có thể thực hiện chức năng này cần cài đặt thêm extensions Microsoft RDLC Report Designer và package Reporting Service
    public partial class BaoCaoThongKe : Form
    {
        public BaoCaoThongKe()
        {
            InitializeComponent();

            UpdateData("null");
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            dataDoanhthu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var reports = context.Reports.ToList();

                this.dataDoanhthu.DataSource = reports;
                this.dataDoanhthu.Refresh();
            }
        }

        public void LoadData()
        {
            dataDoanhthu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            using (var context = new CarDBContext())
            {
                var reports = context.Reports.ToList();

                this.dataDoanhthu.DataSource = reports;
                this.dataDoanhthu.Refresh();
            }
        }

        public void UpdateData(string s)
        {
            using (var context = new CarDBContext())
            {
                switch (s)
                {
                    case "null":
                        double total = 0;
                        int count = 0;
                        var reports = context.Reports.ToList();
                        foreach (var item in reports)
                        {
                            string[] price = item.Price.Split(" ");
                            total += double.Parse(price[0]);
                            count++;

                        }

                        txtDoanhthu.Text = "BÁO CÁO DOANH THU TỔNG";
                        txtSoXe.Text = count.ToString();
                        txtTien.Text = total.ToString("N0") + " đồng";
                        break;
                    case "Hãng xe":
                        var companaies = context.Reports.GroupBy(c => c.Company).Select(group => group.First()).ToList();

                        dataDoanhthu.DataSource = companaies;
                        dataDoanhthu.Columns["type"].Visible = false;
                        dataDoanhthu.Columns["TimeIn"].Visible = false;
                        dataDoanhthu.Columns["TimeOut"].Visible = false;

                        txtDoanhthu.Location = new Point(152, 20);
                        txtDoanhthu.Text = "BÁO CÁO DOANH THU THEO " + s.ToUpper();
                        break;
                    case "Mẫu xe":
                        var types = context.Reports.GroupBy(c => c.Type).Select(group => group.First()).ToList();

                        dataDoanhthu.DataSource = types;
                        dataDoanhthu.Columns["company"].Visible = false;
                        dataDoanhthu.Columns["TimeIn"].Visible = false;
                        dataDoanhthu.Columns["TimeOut"].Visible = false;

                        txtDoanhthu.Location = new Point(152, 20);
                        txtDoanhthu.Text = "BÁO CÁO DOANH THU THEO " + s.ToUpper();
                        break;
                    case "Thời gian thuê":
                        var times = context.Reports.ToList();

                        dataDoanhthu.DataSource = times;
                        dataDoanhthu.Columns["company"].Visible = false;
                        dataDoanhthu.Columns["type"].Visible = false;

                        txtDoanhthu.Location = new Point(152, 20);
                        txtDoanhthu.Text = "BÁO CÁO DOANH THU THEO " + s.ToUpper();
                        break;
                }

            }
        }

        private void Company_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text;


                using (var context = new CarDBContext())
                {
                    double total = 0;
                    int count = 0;
                    var reports = context.Reports.Where(c => c.Company == buttonText).ToList();
                    foreach (var item in reports)
                    {
                        string[] price = item.Price.Split(" ");
                        total += double.Parse(price[0]);
                        count++;

                    }
                    txtTXe.Text = "Tổng số xe hãng " + buttonText + ": ";
                    txtTDT.Text = "Tổng doanh thu hãng " + buttonText + ": ";
                    txtSoXe.Text = count.ToString();
                    txtTien.Text = total.ToString("N0") + " đồng";
                }
            }
        }
        private void Type_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text;


                using (var context = new CarDBContext())
                {
                    double total = 0;
                    int count = 0;
                    var reports = context.Reports.Where(c => c.Type == buttonText).ToList();
                    foreach (var item in reports)
                    {
                        string[] price = item.Price.Split(" ");
                        total += double.Parse(price[0]);
                        count++;

                    }
                    txtTXe.Text = "Tổng số xe loại " + buttonText + ": ";
                    txtTDT.Text = "Tổng doanh thu loại " + buttonText + ": ";
                    txtSoXe.Text = count.ToString();
                    txtTien.Text = total.ToString("N0") + " đồng";
                }
            }
        }

        private void Time_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string buttonText = clickedButton.Text;
                string[] time = buttonText.Split(" - ");

                using (var context = new CarDBContext())
                {
                    double total = 0;
                    int count = 0;
                    DateTime startTime = DateTime.Parse(time[0]);
                    DateTime endTime = DateTime.Parse(time[1]);

                    var reports = context.Reports.Where(c => c.TimeIn.Date >= startTime.Date && c.TimeOut.Date <= endTime.Date).ToList();
                    foreach (var item in reports)
                    {
                        string[] price = item.Price.Split(" ");
                        total += double.Parse(price[0]);
                        count++;

                    }
                    txtSoXe.Text = count.ToString();
                    txtTien.Text = total.ToString("N0") + " đồng";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData(button1.Text);

            flButton.Controls.Clear();
            using (var context = new CarDBContext())
            {
                var cars = context.Reports.GroupBy(c => c.Company).Select(group => group.First()).ToList();

                foreach (var item in cars)
                {
                    Button button = new Button();
                    button.Text = item.Company;
                    button.Size = new Size(103, 52);

                    button.Click += Company_Click;

                    flButton.Controls.Add(button);

                    flButton.Controls.Add(new Panel() { Width = 10, Height = 1, Margin = new Padding(0) });

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData(button2.Text);

            flButton.Controls.Clear();
            using (var context = new CarDBContext())
            {
                var cars = context.Reports.GroupBy(c => c.Type).Select(group => group.First()).ToList();

                foreach (var item in cars)
                {
                    Button button = new Button();
                    button.Text = item.Type;
                    button.Size = new Size(103, 52);

                    button.Click += Type_Click;

                    flButton.Controls.Add(button);

                    flButton.Controls.Add(new Panel() { Width = 10, Height = 1, Margin = new Padding(0) });

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateData(button3.Text);

            flButton.Controls.Clear();
            using (var context = new CarDBContext())
            {
                var cars = context.Reports.GroupBy(c => c.TimeOut.Date).Select(group => group.First()).ToList();

                foreach (var item in cars)
                {
                    Button button = new Button();
                    button.Text = item.TimeIn + " - " + item.TimeOut; //xử lý lại chỗ tính tiền thời gian
                    button.Size = new Size(200, 52);

                    button.Click += Time_Click;

                    flButton.Controls.Add(button);

                    flButton.Controls.Add(new Panel() { Width = 10, Height = 1, Margin = new Padding(0) });

                }
            }
        }

        private void txtTDT_Click(object sender, EventArgs e)
        {

        }

        private void txtTien_Click(object sender, EventArgs e)
        {
        }

        private void txtTXe_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được phát triển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
