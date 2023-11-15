using Microsoft.Data.SqlClient;
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

namespace ThueXeOTo.KhachHang
{
    public partial class FixKH : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        string ID;
        public FixKH()
        {
            InitializeComponent();
        }

        public void UpdateInfo(string id, string name, string sdt, string address, string nameCar, string timein, string timeout)
        {
            ID = id;
            txtName.Text = name;
            txtSDT.Text = sdt;
            txtAddress.Text = address;
            txtNamecar.Text = nameCar;
            dtIN.Text = timein;
            dtOUT.Text = timeout;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "UPDATE Orders SET NameUser = @name, SDT = @sdt, Address = @address, NameCar = @namecar, TimeIn = @timein, TimeOut = @timeout WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text;
                    command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = txtSDT.Text;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;
                    command.Parameters.Add("@namecar", SqlDbType.NVarChar).Value = txtNamecar.Text;
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
                    command.Parameters.Add("@timein", SqlDbType.DateTime2).Value = dtIN.Text;
                    command.Parameters.Add("@timeout", SqlDbType.DateTime2).Value = dtOUT.Text;

                    int rowCount = command.ExecuteNonQuery();

                    this.Close();
                }
                connection.Close();
            }
        }
    }
}
