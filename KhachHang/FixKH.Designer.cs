﻿namespace ThueXeOTo.KhachHang
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
            txtAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSDT = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 239);
            button1.Name = "button1";
            button1.Size = new Size(147, 60);
            button1.TabIndex = 28;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(189, 158);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(376, 27);
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
            label3.Location = new Point(440, 88);
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
            label1.Location = new Point(170, 21);
            label1.Name = "label1";
            label1.Size = new Size(474, 35);
            label1.TabIndex = 19;
            label1.Text = "SỬA THÔNG TIN KHÁCH HÀNG";
            label1.Click += label1_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(571, 84);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(178, 27);
            txtSDT.TabIndex = 29;
            // 
            // FixKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(759, 338);
            Controls.Add(txtSDT);
            Controls.Add(button1);
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
        private TextBox txtAddress;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtSDT;
    }
}