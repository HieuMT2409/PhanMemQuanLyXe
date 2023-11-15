using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThueXeOTo.ControlCars
{
    public partial class FixCar : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        string ID;
        public FixCar()
        {
            InitializeComponent();
        }

        public void UpdateInfo(string id, string name, string type, string company)
        {
            ID = id;
            txtName.Text = name;
            txtCompany.Text = company;
            cbType.Text = type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "UPDATE Cars SET Name = @name, Type = @type, Company = @company WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text;
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
                    command.Parameters.Add("@company", SqlDbType.NVarChar).Value = txtCompany.Text;
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;

                    int rowCount = command.ExecuteNonQuery();
                    
                    this.Close();
                }
                connection.Close();
            }
        }
    }
}
