namespace ThueXeOTo.KhachHang
{
    partial class FixKH
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
            button1 = new Button();
            txtNamecar = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSDT = new TextBox();
            label9 = new Label();
            dtOUT = new DateTimePicker();
            label8 = new Label();
            dtIN = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(379, 266);
            button1.Name = "button1";
            button1.Size = new Size(147, 60);
            button1.TabIndex = 28;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNamecar
            // 
            txtNamecar.BackColor = Color.White;
            txtNamecar.BorderStyle = BorderStyle.None;
            txtNamecar.Enabled = false;
            txtNamecar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamecar.Location = new Point(612, 158);
            txtNamecar.Name = "txtNamecar";
            txtNamecar.Size = new Size(154, 23);
            txtNamecar.TabIndex = 27;
            txtNamecar.Text = "Trống";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(481, 157);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 26;
            label5.Text = "Xe thuê:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(189, 158);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(219, 27);
            txtAddress.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 157);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 24;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(481, 87);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 22;
            label3.Text = "Số điện thoại:";
            // 
            // txtName
            // 
            txtName.Location = new Point(189, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 20;
            label2.Text = "Tên Khách Hàng:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(474, 35);
            label1.TabIndex = 19;
            label1.Text = "SỬA THÔNG TIN KHÁCH HÀNG";
            label1.Click += label1_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(612, 83);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(178, 27);
            txtSDT.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(481, 220);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 33;
            label9.Text = "Ngày trả:";
            // 
            // dtOUT
            // 
            dtOUT.Location = new Point(612, 213);
            dtOUT.Name = "dtOUT";
            dtOUT.Size = new Size(242, 27);
            dtOUT.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 220);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 31;
            label8.Text = "Ngày thuê:";
            // 
            // dtIN
            // 
            dtIN.Location = new Point(189, 213);
            dtIN.Name = "dtIN";
            dtIN.Size = new Size(249, 27);
            dtIN.TabIndex = 30;
            // 
            // FixKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(887, 338);
            Controls.Add(label9);
            Controls.Add(dtOUT);
            Controls.Add(label8);
            Controls.Add(dtIN);
            Controls.Add(txtSDT);
            Controls.Add(button1);
            Controls.Add(txtNamecar);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FixKH";
            Text = "FixKH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNamecar;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtSDT;
        private Label label9;
        public DateTimePicker dtOUT;
        private Label label8;
        public DateTimePicker dtIN;
    }
}