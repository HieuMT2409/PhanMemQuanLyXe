namespace ThueXeOTo.OrderCar
{
    partial class ThongTinHoaDon
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
            txthoadon = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            lbFeature = new ListBox();
            label7 = new Label();
            txtXethue = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtName = new Label();
            txtAddress = new Label();
            txtSDT = new Label();
            txtTimeIn = new Label();
            txtTimeOut = new Label();
            txtPay = new Label();
            SuspendLayout();
            // 
            // txthoadon
            // 
            txthoadon.AutoSize = true;
            txthoadon.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txthoadon.Location = new Point(249, 36);
            txthoadon.Name = "txthoadon";
            txthoadon.Size = new Size(208, 45);
            txthoadon.TabIndex = 2;
            txthoadon.Text = "HÓA ĐƠN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(474, 269);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 39;
            label10.Text = "Thanh toán:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(474, 216);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 37;
            label9.Text = "Ngày trả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(474, 167);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 35;
            label8.Text = "Ngày thuê:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 167);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 31;
            label6.Text = "Địa chỉ:";
            // 
            // lbFeature
            // 
            lbFeature.BackColor = Color.White;
            lbFeature.BorderStyle = BorderStyle.None;
            lbFeature.Enabled = false;
            lbFeature.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbFeature.FormattingEnabled = true;
            lbFeature.ItemHeight = 20;
            lbFeature.Location = new Point(189, 282);
            lbFeature.Name = "lbFeature";
            lbFeature.Size = new Size(242, 160);
            lbFeature.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 284);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 29;
            label7.Text = "Tính năng thêm:";
            // 
            // txtXethue
            // 
            txtXethue.AutoSize = true;
            txtXethue.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtXethue.Location = new Point(189, 228);
            txtXethue.Name = "txtXethue";
            txtXethue.Size = new Size(46, 20);
            txtXethue.TabIndex = 28;
            txtXethue.Text = "Xe A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 228);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 27;
            label5.Text = "Tên xe thuê:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(474, 109);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 25;
            label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 109);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 23;
            label2.Text = "Họ tên khách hàng: ";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(189, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(46, 20);
            txtName.TabIndex = 40;
            txtName.Text = "Xe A";
            // 
            // txtAddress
            // 
            txtAddress.AutoSize = true;
            txtAddress.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(189, 167);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(46, 20);
            txtAddress.TabIndex = 41;
            txtAddress.Text = "Xe A";
            // 
            // txtSDT
            // 
            txtSDT.AutoSize = true;
            txtSDT.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(597, 109);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(46, 20);
            txtSDT.TabIndex = 42;
            txtSDT.Text = "Xe A";
            // 
            // txtTimeIn
            // 
            txtTimeIn.AutoSize = true;
            txtTimeIn.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimeIn.Location = new Point(597, 167);
            txtTimeIn.Name = "txtTimeIn";
            txtTimeIn.Size = new Size(46, 20);
            txtTimeIn.TabIndex = 43;
            txtTimeIn.Text = "Xe A";
            // 
            // txtTimeOut
            // 
            txtTimeOut.AutoSize = true;
            txtTimeOut.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimeOut.Location = new Point(597, 216);
            txtTimeOut.Name = "txtTimeOut";
            txtTimeOut.Size = new Size(46, 20);
            txtTimeOut.TabIndex = 44;
            txtTimeOut.Text = "Xe A";
            // 
            // txtPay
            // 
            txtPay.AutoSize = true;
            txtPay.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPay.Location = new Point(597, 269);
            txtPay.Name = "txtPay";
            txtPay.Size = new Size(46, 20);
            txtPay.TabIndex = 45;
            txtPay.Text = "Xe A";
            // 
            // ThongTinHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPay);
            Controls.Add(txtTimeOut);
            Controls.Add(txtTimeIn);
            Controls.Add(txtSDT);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(lbFeature);
            Controls.Add(label7);
            Controls.Add(txtXethue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txthoadon);
            Name = "ThongTinHoaDon";
            Text = "ThongTinHoaDon";
            Load += ThongTinHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txthoadon;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        public ListBox lbFeature;
        private Label label7;
        public Label txtXethue;
        private Label label5;
        private Label label4;
        private Label label2;
        public Label txtName;
        public Label txtAddress;
        public Label txtSDT;
        public Label txtTimeIn;
        public Label txtTimeOut;
        public Label txtPay;
    }
}