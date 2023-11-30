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
            label9 = new Label();
            label8 = new Label();
            lbFeature = new ListBox();
            label7 = new Label();
            txtXethue = new Label();
            label5 = new Label();
            label2 = new Label();
            txtName = new Label();
            txtTimeIn = new Label();
            txtTimeOut = new Label();
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(472, 158);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 37;
            label9.Text = "Ngày trả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(472, 109);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 35;
            label8.Text = "Ngày thuê:";
            // 
            // lbFeature
            // 
            lbFeature.BackColor = Color.White;
            lbFeature.BorderStyle = BorderStyle.None;
            lbFeature.Enabled = false;
            lbFeature.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbFeature.FormattingEnabled = true;
            lbFeature.ItemHeight = 20;
            lbFeature.Location = new Point(189, 216);
            lbFeature.Name = "lbFeature";
            lbFeature.Size = new Size(242, 160);
            lbFeature.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 216);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 29;
            label7.Text = "Tính năng thêm:";
            // 
            // txtXethue
            // 
            txtXethue.AutoSize = true;
            txtXethue.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtXethue.Location = new Point(189, 158);
            txtXethue.Name = "txtXethue";
            txtXethue.Size = new Size(46, 20);
            txtXethue.TabIndex = 28;
            txtXethue.Text = "Xe A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 158);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 27;
            label5.Text = "Tên xe thuê:";
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
            // txtTimeIn
            // 
            txtTimeIn.AutoSize = true;
            txtTimeIn.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimeIn.Location = new Point(595, 109);
            txtTimeIn.Name = "txtTimeIn";
            txtTimeIn.Size = new Size(46, 20);
            txtTimeIn.TabIndex = 43;
            txtTimeIn.Text = "Xe A";
            // 
            // txtTimeOut
            // 
            txtTimeOut.AutoSize = true;
            txtTimeOut.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimeOut.Location = new Point(595, 158);
            txtTimeOut.Name = "txtTimeOut";
            txtTimeOut.Size = new Size(46, 20);
            txtTimeOut.TabIndex = 44;
            txtTimeOut.Text = "Xe A";
            // 
            // ThongTinHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTimeOut);
            Controls.Add(txtTimeIn);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lbFeature);
            Controls.Add(label7);
            Controls.Add(txtXethue);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txthoadon);
            ForeColor = Color.CornflowerBlue;
            Name = "ThongTinHoaDon";
            Text = "ThongTinHoaDon";
            Load += ThongTinHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txthoadon;
        private Label label9;
        private Label label8;
        public ListBox lbFeature;
        private Label label7;
        public Label txtXethue;
        private Label label5;
        private Label label2;
        public Label txtName;
        public Label txtTimeIn;
        public Label txtTimeOut;
    }
}