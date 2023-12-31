﻿using Microsoft.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ThueXeOTo.ControlCar
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new CarDBContext())
            {
                context.AddCar(txtName.Text, cbType.Text, txtCompany.Text, txtState.Text, txtPrice.Text + txtday.Text);

                this.Close();
            }
        }
    }
}
