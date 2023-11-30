namespace ThueXeOTo.OrderCar
{
    partial class ThanhToan
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
            txtHoaDon = new Label();
            label1 = new Label();
            txtXe = new Label();
            label2 = new Label();
            txtNhienlieu = new Label();
            label5 = new Label();
            lbFeature = new ListBox();
            label4 = new Label();
            txtTotal = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // txtHoaDon
            // 
            txtHoaDon.AutoSize = true;
            txtHoaDon.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtHoaDon.Location = new Point(236, 24);
            txtHoaDon.Name = "txtHoaDon";
            txtHoaDon.Size = new Size(206, 53);
            txtHoaDon.TabIndex = 0;
            txtHoaDon.Text = "Hóa Đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 122);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên xe:";
            // 
            // txtXe
            // 
            txtXe.AutoSize = true;
            txtXe.BackColor = Color.White;
            txtXe.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtXe.Location = new Point(127, 122);
            txtXe.Name = "txtXe";
            txtXe.Size = new Size(59, 25);
            txtXe.TabIndex = 2;
            txtXe.Text = "Xe A";
            txtXe.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(494, 122);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 4;
            label2.Text = "Nhiên liệu: ";
            // 
            // txtNhienlieu
            // 
            txtNhienlieu.AutoSize = true;
            txtNhienlieu.BackColor = Color.Cornsilk;
            txtNhienlieu.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhienlieu.Location = new Point(609, 121);
            txtNhienlieu.Name = "txtNhienlieu";
            txtNhienlieu.Size = new Size(59, 26);
            txtNhienlieu.TabIndex = 5;
            txtNhienlieu.Text = "Xe A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 175);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 7;
            label5.Text = "Tính năng thêm:";
            // 
            // lbFeature
            // 
            lbFeature.BackColor = Color.White;
            lbFeature.FormattingEnabled = true;
            lbFeature.ItemHeight = 20;
            lbFeature.Location = new Point(35, 217);
            lbFeature.Name = "lbFeature";
            lbFeature.Size = new Size(683, 224);
            lbFeature.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 478);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 9;
            label4.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.BackColor = Color.White;
            txtTotal.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(507, 478);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(176, 25);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "00,000,000 đồng";
            // 
            // btnOK
            // 
            btnOK.ForeColor = Color.Black;
            btnOK.Location = new Point(609, 526);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(109, 53);
            btnOK.TabIndex = 11;
            btnOK.Text = "Thanh toán";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(753, 591);
            Controls.Add(btnOK);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(lbFeature);
            Controls.Add(label5);
            Controls.Add(txtNhienlieu);
            Controls.Add(label2);
            Controls.Add(txtXe);
            Controls.Add(label1);
            Controls.Add(txtHoaDon);
            ForeColor = Color.CornflowerBlue;
            Name = "ThanhToan";
            Text = "ThanhToan";
            Load += ThanhToan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtHoaDon;
        private Label label1;
        private Label txtXe;
        private Label label2;
        private Label txtNhienlieu;
        private Label label5;
        private ListBox lbFeature;
        private Label label4;
        private Label txtTotal;
        private Button btnOK;
    }
}