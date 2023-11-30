using Microsoft.Data.SqlClient;
using System.Data;
using ThueXeOTo.Database;

namespace ThueXeOTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.SendToBack();
            password.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (CarDBContext context = new CarDBContext())
            {
                int userCount = context.Users
                    .Where(u => u.NameUser == username.Text && u.Password == password.Text)
                    .Count();

                if (userCount > 0)
                {
                    Home_New home = new Home_New();
                    home.UpdateLabel(username.Text);
                    home.Show();
                    home.FormClosed += (s, args) => this.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại.");
                }
            }
        }
    }
}