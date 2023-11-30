namespace ThueXeOTo
{
    partial class ThongTinThueXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNameUser = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtXethue = new Label();
            label7 = new Label();
            lbFeature = new ListBox();
            txtSDT = new TextBox();
            label6 = new Label();
            button1 = new Button();
            dtIN = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            dtOUT = new DateTimePicker();
            txtID = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(545, 51);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN THUÊ XE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 109);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ tên khách hàng: ";
            // 
            // txtNameUser
            // 
            txtNameUser.BackColor = Color.White;
            txtNameUser.Enabled = false;
            txtNameUser.Location = new Point(193, 102);
            txtNameUser.Name = "txtNameUser";
            txtNameUser.Size = new Size(279, 27);
            txtNameUser.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Enabled = false;
            txtAddress.Location = new Point(193, 160);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(279, 27);
            txtAddress.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(478, 109);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 7;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 228);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 9;
            label5.Text = "Tên xe thuê:";
            // 
            // txtXethue
            // 
            txtXethue.AutoSize = true;
            txtXethue.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtXethue.Location = new Point(193, 228);
            txtXethue.Name = "txtXethue";
            txtXethue.Size = new Size(46, 20);
            txtXethue.TabIndex = 10;
            txtXethue.Text = "Xe A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(20, 284);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 11;
            label7.Text = "Tính năng thêm:";
            // 
            // lbFeature
            // 
            lbFeature.BackColor = Color.White;
            lbFeature.BorderStyle = BorderStyle.None;
            lbFeature.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbFeature.FormattingEnabled = true;
            lbFeature.ItemHeight = 20;
            lbFeature.Location = new Point(193, 282);
            lbFeature.Name = "lbFeature";
            lbFeature.Size = new Size(242, 160);
            lbFeature.TabIndex = 12;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.White;
            txtSDT.Enabled = false;
            txtSDT.Location = new Point(601, 102);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(187, 27);
            txtSDT.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 167);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Địa chỉ:";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(626, 383);
            button1.Name = "button1";
            button1.Size = new Size(162, 55);
            button1.TabIndex = 15;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtIN
            // 
            dtIN.Location = new Point(546, 228);
            dtIN.Name = "dtIN";
            dtIN.Size = new Size(242, 27);
            dtIN.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(448, 233);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 17;
            label8.Text = "Ngày thuê:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(448, 282);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 19;
            label9.Text = "Ngày trả:";
            // 
            // dtOUT
            // 
            dtOUT.Location = new Point(546, 277);
            dtOUT.Name = "dtOUT";
            dtOUT.Size = new Size(242, 27);
            dtOUT.TabIndex = 18;
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(20, 339);
            txtID.Name = "txtID";
            txtID.Size = new Size(22, 20);
            txtID.TabIndex = 20;
            txtID.Text = "id";
            txtID.Visible = false;
            // 
            // ThongTinThueXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(dtOUT);
            Controls.Add(label8);
            Controls.Add(dtIN);
            Controls.Add(button1);
            Controls.Add(txtSDT);
            Controls.Add(label6);
            Controls.Add(lbFeature);
            Controls.Add(label7);
            Controls.Add(txtXethue);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtNameUser);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.CornflowerBlue;
            Name = "ThongTinThueXe";
            Text = "ThongTinThueXe";
            Load += ThongTinThueXe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox txtNameUser;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        public TextBox txtAddress;
        private Label label4;
        private Label label5;
        public Label txtXethue;
        private Label label7;
        public ListBox lbFeature;
        public TextBox txtSDT;
        private Label label6;
        public Button button1;
        public DateTimePicker dtIN;
        private Label label8;
        private Label label9;
        public DateTimePicker dtOUT;
        public Label txtID;
    }
}