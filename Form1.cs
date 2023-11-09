using Microsoft.Data.SqlClient;
using System.Data;

namespace ThueXeOTo
{
    public partial class Form1 : Form
    {
        string conectionString = @"Data Source=HIEUMT-2491310\HIEUMT; Integrated Security=true; Database=CarDB";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.SendToBack();
            password.PasswordChar = '*';

        }

        public string GetUser()
        {
            return username.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE NameUser = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username.Text);
                    command.Parameters.AddWithValue("@Password", password.Text);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        Home_New home = new Home_New();
                        //home.UpdateLabel(username.Text);

                        home.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại.");
                    }
                }
            }
        }
    }
}