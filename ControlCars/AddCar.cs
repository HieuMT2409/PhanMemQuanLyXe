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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ThueXeOTo.ControlCar
{
    public partial class AddCar : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        public AddCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu
                string query = "INSERT INTO Cars(Name, Type, Company, State) VALUES (@name, @type, @company, @state)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text;
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = cbType.Text;
                    command.Parameters.Add("@company", SqlDbType.NVarChar).Value = txtCompany.Text;
                    command.Parameters.Add("@state", SqlDbType.NVarChar).Value = txtState.Text;
                    int rowCount = command.ExecuteNonQuery();
                    this.Close();
                }
            }
        }
    }
}
