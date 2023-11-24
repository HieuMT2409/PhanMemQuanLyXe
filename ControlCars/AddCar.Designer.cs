namespace ThueXeOTo.ControlCar
{
    partial class AddCar
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
            txtName = new TextBox();
            label3 = new Label();
            cbType = new ComboBox();
            txtCompany = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtState = new TextBox();
            button1 = new Button();
            txtPrice = new TextBox();
            label6 = new Label();
            txtday = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 18);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 0;
            label1.Text = "THÊM XE MỚI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 96);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên Xe:";
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(353, 96);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 3;
            label3.Text = "Loại Xe:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "4 Chỗ (Mini)", "4 Chỗ (Sedan)", "4 Chỗ (Hatchback)", "5 Chỗ (SUV Gầm cao)", "7 Chỗ (SUV Gầm cao)", "7 Chỗ (MPV Gầm thấp)", "Bán tải" });
            cbType.Location = new Point(442, 91);
            cbType.Name = "cbType";
            cbType.Size = new Size(178, 28);
            cbType.TabIndex = 4;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(114, 161);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(219, 27);
            txtCompany.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 165);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 5;
            label4.Text = "Hãng Xe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 225);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 7;
            label5.Text = "Trạng thái:";
            // 
            // txtState
            // 
            txtState.BackColor = Color.White;
            txtState.BorderStyle = BorderStyle.None;
            txtState.Enabled = false;
            txtState.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtState.Location = new Point(128, 226);
            txtState.Name = "txtState";
            txtState.Size = new Size(154, 23);
            txtState.TabIndex = 8;
            txtState.Text = "Trống";
            // 
            // button1
            // 
            button1.Location = new Point(270, 275);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 9;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(449, 161);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(79, 27);
            txtPrice.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(353, 165);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 10;
            label6.Text = "Giá Thuê:";
            // 
            // txtday
            // 
            txtday.AutoSize = true;
            txtday.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtday.Location = new Point(534, 162);
            txtday.Name = "txtday";
            txtday.Size = new Size(118, 22);
            txtday.TabIndex = 12;
            txtday.Text = " triệu / 1 ngày";
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(660, 345);
            Controls.Add(txtday);
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
            Name = "AddCar";
            Text = "AddCar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private ComboBox cbType;
        private TextBox txtCompany;
        private Label label4;
        private Label label5;
        private TextBox txtState;
        private Button button1;
        private TextBox txtPrice;
        private Label label6;
        private Label txtday;
    }
}