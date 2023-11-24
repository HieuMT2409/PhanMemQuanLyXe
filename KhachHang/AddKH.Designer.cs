namespace ThueXeOTo.KhachHang
{
    partial class AddKH
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
            txtSDT = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(307, 215);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 22;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(544, 92);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(157, 27);
            txtSDT.TabIndex = 19;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(413, 96);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 18;
            label4.Text = "Số điện thoại:";
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 96);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 14;
            label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 24);
            label1.Name = "label1";
            label1.Size = new Size(326, 35);
            label1.TabIndex = 13;
            label1.Text = "THÊM KHÁCH HÀNG";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(172, 144);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(366, 27);
            txtAddress.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 148);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 23;
            label3.Text = "Địa chỉ:";
            // 
            // AddKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(732, 288);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtSDT);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddKH";
            Text = "AddKH";
            Load += AddKH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private Label label3;
    }
}