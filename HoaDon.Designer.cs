namespace ThueXeOTo
{
    partial class HoaDon
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            comboBoxCustomers = new ComboBox();
            customerBindingSource1 = new BindingSource(components);
            customerBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnChoose = new Button();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(298, 23);
            label1.Name = "label1";
            label1.Size = new Size(278, 53);
            label1.TabIndex = 0;
            label1.Text = "Tạo hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 120);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng:";
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.DataSource = customerBindingSource1;
            comboBoxCustomers.DisplayMember = "Name";
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new Point(183, 120);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(202, 28);
            comboBoxCustomers.TabIndex = 2;
            comboBoxCustomers.ValueMember = "ID";
            // 
            // customerBindingSource1
            // 
            customerBindingSource1.DataSource = typeof(Database.Customer);
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Database.Customer);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(138, 191);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 3;
            label3.Text = "Xe đã chọn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(554, 191);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 4;
            label4.Text = "Tính năng thêm";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(705, 523);
            button1.Name = "button1";
            button1.Size = new Size(130, 52);
            button1.TabIndex = 5;
            button1.Text = "Tạo đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(34, 230);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(351, 264);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(441, 230);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(394, 264);
            listBox2.TabIndex = 7;
            // 
            // btnChoose
            // 
            btnChoose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChoose.Location = new Point(34, 523);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(130, 52);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "Chọn xe";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += button2_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(861, 587);
            Controls.Add(btnChoose);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxCustomers);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HoaDon";
            Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public ComboBox comboBoxCustomers;
        private BindingSource customerBindingSource;
        private Label label3;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        public Button btnChoose;
        private BindingSource customerBindingSource1;
    }
}