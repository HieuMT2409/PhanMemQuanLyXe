using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThueXeOTo.Database;
using ThueXeOTo.OrderCar;

namespace ThueXeOTo
{

    public partial class Listcars : Form
    {
        public ChooseCar chooseCar = new ChooseCar();
        public Listcars()
        {
            InitializeComponent();
        }

        private void ShowForm()
        {
            Home_New homeForm = this.ParentForm as Home_New;

            if (homeForm != null)
            {
                chooseCar.TopLevel = false;
                homeForm.panel1.Controls.Clear();
                homeForm.panel1.Controls.Add(chooseCar);
                chooseCar.FormBorderStyle = FormBorderStyle.None;
                chooseCar.Dock = DockStyle.Fill;
                chooseCar.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                List<Car> carsList = context.Cars.Where(c => c.Type == "4 Chỗ (Mini)").ToList();

                chooseCar.dataDetailCar.DataSource = carsList;
            }

            ShowForm();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                List<Car> carsList = context.Cars.Where(c => c.Type == "4 Chỗ (Sedan)").ToList();

                chooseCar.dataDetailCar.DataSource = carsList;
            }
            ShowForm();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                List<Car> carsList = context.Cars.Where(c => c.Type == "4 Chỗ (Hatchback)").ToList();

                chooseCar.dataDetailCar.DataSource = carsList;
            }
            ShowForm();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                List<Car> carsList = context.Cars.Where(c => c.Type == "5 Chỗ (SUV Gầm cao)").ToList();

                chooseCar.dataDetailCar.DataSource = carsList;
            }
            ShowForm();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                List<Car> carsList = context.Cars.Where(c => c.Type == "7 Chỗ (SUV Gầm cao)").ToList();

                chooseCar.dataDetailCar.DataSource = carsList;
            }
            ShowForm();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                List<Car> carsList = context.Cars.Where(c => c.Type == "7 Chỗ (MPV Gầm thấp)").ToList();

                chooseCar.dataDetailCar.DataSource = carsList;
            }
            ShowForm();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                var cars = context.Cars.ToList();

                List<Car> carsList = context.Cars.Where(c => c.Type == "Bán tải").ToList();

                chooseCar.dataDetailCar.DataSource = carsList;
            }
            ShowForm();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
