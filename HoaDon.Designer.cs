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
            customerBindingSource = new BindingSource(components);
            customerBindingSource1 = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            lbCar = new ListBox();
            lbFeature = new ListBox();
            btnChoose = new Button();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).BeginInit();
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
            comboBoxCustomers.DataSource = customerBindingSource;
            comboBoxCustomers.DisplayMember = "Name";
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new Point(183, 120);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(202, 28);
            comboBoxCustomers.TabIndex = 2;
            comboBoxCustomers.ValueMember = "ID";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Database.Customer);
            // 
            // customerBindingSource1
            // 
            customerBindingSource1.DataSource = typeof(Database.Customer);
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
            button1.ForeColor = Color.Black;
            button1.Location = new Point(705, 523);
            button1.Name = "button1";
            button1.Size = new Size(130, 52);
            button1.TabIndex = 5;
            button1.Text = "Tạo đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbCar
            // 
            lbCar.FormattingEnabled = true;
            lbCar.ItemHeight = 20;
            lbCar.Location = new Point(34, 230);
            lbCar.Name = "lbCar";
            lbCar.Size = new Size(351, 264);
            lbCar.TabIndex = 6;
            // 
            // lbFeature
            // 
            lbFeature.FormattingEnabled = true;
            lbFeature.ItemHeight = 20;
            lbFeature.Location = new Point(441, 230);
            lbFeature.Name = "lbFeature";
            lbFeature.Size = new Size(394, 264);
            lbFeature.TabIndex = 7;
            // 
            // btnChoose
            // 
            btnChoose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChoose.ForeColor = Color.Black;
            btnChoose.Location = new Point(34, 523);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(130, 52);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "Chọn xe";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(861, 587);
            Controls.Add(btnChoose);
            Controls.Add(lbFeature);
            Controls.Add(lbCar);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxCustomers);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.CornflowerBlue;
            Name = "HoaDon";
            Text = "HoaDon";
            Load += HoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).EndInit();
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
        public ListBox lbCar;
        private ListBox lbFeature;
        public Button btnChoose;
        private BindingSource customerBindingSource1;
    }
}