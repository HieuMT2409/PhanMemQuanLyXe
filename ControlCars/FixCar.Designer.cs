namespace ThueXeOTo.ControlCars
{
    partial class FixCar
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
            button1 = new Button();
            txtState = new TextBox();
            label5 = new Label();
            txtCompany = new TextBox();
            label4 = new Label();
            cbType = new ComboBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 19);
            label1.Name = "label1";
            label1.Size = new Size(303, 35);
            label1.TabIndex = 1;
            label1.Text = "SỬA THÔNG TIN XE";
            // 
            // button1
            // 
            button1.Location = new Point(254, 287);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 18;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtState
            // 
            txtState.BackColor = Color.White;
            txtState.BorderStyle = BorderStyle.None;
            txtState.Enabled = false;
            txtState.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtState.Location = new Point(128, 217);
            txtState.Name = "txtState";
            txtState.Size = new Size(154, 23);
            txtState.TabIndex = 17;
            txtState.Text = "Trống";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 217);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 16;
            label5.Text = "Trạng thái:";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(114, 149);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(219, 27);
            txtCompany.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 153);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 14;
            label4.Text = "Hãng Xe:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "4 Chỗ (Mini)", "4 Chỗ (Sedan)", "4 Chỗ (Hatchback)", "5 Chỗ (SUV Gầm cao)", "7 Chỗ (SUV Gầm cao)", "7 Chỗ (MPV Gầm thấp)", "Bán tải" });
            cbType.Location = new Point(442, 79);
            cbType.Name = "cbType";
            cbType.Size = new Size(178, 28);
            cbType.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(353, 84);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 12;
            label3.Text = "Loại Xe:";
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 10;
            label2.Text = "Tên Xe:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(449, 149);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(171, 27);
            txtPrice.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(353, 153);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 19;
            label6.Text = "Giá Thuê:";
            // 
            // FixCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(655, 357);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtState);
            Controls.Add(label5);
            Controls.Add(txtCompany);
            Controls.Add(label4);
            Controls.Add(cbType);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FixCar";
            Text = "FixCar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtState;
        private Label label5;
        private TextBox txtCompany;
        private Label label4;
        private ComboBox cbType;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPrice;
        private Label label6;
    }
}