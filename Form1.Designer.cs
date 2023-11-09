namespace ThueXeOTo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            password = new TextBox();
            logo = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Elephant", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(320, 67);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(278, 38);
            label1.TabIndex = 0;
            label1.Text = "REFUND CAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 169);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 228);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Location = new Point(284, 164);
            username.Name = "username";
            username.Size = new Size(329, 27);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Location = new Point(284, 223);
            password.Name = "password";
            password.Size = new Size(329, 27);
            password.TabIndex = 4;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(245, 35);
            logo.Name = "logo";
            logo.Size = new Size(106, 84);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderColor = Color.Lime;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.White;
            btnLogin.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(302, 303);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(203, 53);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 451);
            Controls.Add(btnLogin);
            Controls.Add(logo);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ThueXeOTo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private PictureBox logo;
        private Button btnLogin;
    }
}