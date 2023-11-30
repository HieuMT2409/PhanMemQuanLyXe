namespace ThueXeOTo.Report
{
    partial class BaoCaoThongKe
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
            dataDoanhthu = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            company = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            reportBindingSource = new BindingSource(components);
            txtDoanhthu = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtTXe = new Label();
            txtTDT = new Label();
            txtSoXe = new Label();
            txtTien = new Label();
            button4 = new Button();
            flButton = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataDoanhthu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataDoanhthu
            // 
            dataDoanhthu.AutoGenerateColumns = false;
            dataDoanhthu.BackgroundColor = Color.White;
            dataDoanhthu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDoanhthu.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameCarDataGridViewTextBoxColumn, company, type, TimeIn, TimeOut, Price });
            dataDoanhthu.DataSource = reportBindingSource;
            dataDoanhthu.Location = new Point(0, 71);
            dataDoanhthu.Name = "dataDoanhthu";
            dataDoanhthu.RowHeadersWidth = 51;
            dataDoanhthu.RowTemplate.Height = 29;
            dataDoanhthu.Size = new Size(866, 200);
            dataDoanhthu.TabIndex = 0;
            dataDoanhthu.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCarDataGridViewTextBoxColumn
            // 
            nameCarDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameCarDataGridViewTextBoxColumn.DataPropertyName = "NameCar";
            nameCarDataGridViewTextBoxColumn.HeaderText = "Tên xe";
            nameCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCarDataGridViewTextBoxColumn.Name = "nameCarDataGridViewTextBoxColumn";
            // 
            // company
            // 
            company.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            company.DataPropertyName = "Company";
            company.HeaderText = "Hãng xe";
            company.MinimumWidth = 6;
            company.Name = "company";
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            type.DataPropertyName = "Type";
            type.HeaderText = "Loại xe";
            type.MinimumWidth = 6;
            type.Name = "type";
            // 
            // TimeIn
            // 
            TimeIn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeIn.DataPropertyName = "TimeIn";
            TimeIn.HeaderText = "Thời gian thuê";
            TimeIn.MinimumWidth = 6;
            TimeIn.Name = "TimeIn";
            // 
            // TimeOut
            // 
            TimeOut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeOut.DataPropertyName = "TimeOut";
            TimeOut.HeaderText = "Thời gian trả";
            TimeOut.MinimumWidth = 6;
            TimeOut.Name = "TimeOut";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Giá tiền";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // reportBindingSource
            // 
            reportBindingSource.DataSource = typeof(Database.Report);
            // 
            // txtDoanhthu
            // 
            txtDoanhthu.AutoSize = true;
            txtDoanhthu.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtDoanhthu.Location = new Point(262, 18);
            txtDoanhthu.Name = "txtDoanhthu";
            txtDoanhthu.Size = new Size(322, 32);
            txtDoanhthu.TabIndex = 1;
            txtDoanhthu.Text = "BÁO CÁO DOANH THU";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(96, 573);
            button1.Name = "button1";
            button1.Size = new Size(128, 69);
            button1.TabIndex = 2;
            button1.Text = "Hãng xe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(262, 573);
            button2.Name = "button2";
            button2.Size = new Size(128, 69);
            button2.TabIndex = 3;
            button2.Text = "Mẫu xe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(431, 573);
            button3.Name = "button3";
            button3.Size = new Size(128, 69);
            button3.TabIndex = 4;
            button3.Text = "Thời gian thuê";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtTXe
            // 
            txtTXe.AutoSize = true;
            txtTXe.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTXe.Location = new Point(12, 316);
            txtTXe.Name = "txtTXe";
            txtTXe.Size = new Size(127, 25);
            txtTXe.TabIndex = 5;
            txtTXe.Text = "Tổng số xe:";
            txtTXe.Click += txtTXe_Click;
            // 
            // txtTDT
            // 
            txtTDT.AutoSize = true;
            txtTDT.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTDT.Location = new Point(12, 365);
            txtTDT.Name = "txtTDT";
            txtTDT.Size = new Size(187, 25);
            txtTDT.TabIndex = 6;
            txtTDT.Text = "Tổng doanh thu: ";
            txtTDT.Click += txtTDT_Click;
            // 
            // txtSoXe
            // 
            txtSoXe.AutoSize = true;
            txtSoXe.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoXe.Location = new Point(506, 316);
            txtSoXe.Name = "txtSoXe";
            txtSoXe.Size = new Size(0, 25);
            txtSoXe.TabIndex = 7;
            // 
            // txtTien
            // 
            txtTien.AutoSize = true;
            txtTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTien.Location = new Point(506, 365);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(0, 25);
            txtTien.TabIndex = 8;
            txtTien.Click += txtTien_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(605, 573);
            button4.Name = "button4";
            button4.Size = new Size(128, 69);
            button4.TabIndex = 9;
            button4.Text = "Biểu đồ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // flButton
            // 
            flButton.Location = new Point(12, 425);
            flButton.Name = "flButton";
            flButton.Size = new Size(846, 55);
            flButton.TabIndex = 10;
            // 
            // BaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(870, 655);
            Controls.Add(flButton);
            Controls.Add(button4);
            Controls.Add(txtTien);
            Controls.Add(txtSoXe);
            Controls.Add(txtTDT);
            Controls.Add(txtTXe);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDoanhthu);
            Controls.Add(dataDoanhthu);
            ForeColor = Color.Black;
            Name = "BaoCaoThongKe";
            Load += BaoCaoThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dataDoanhthu).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataDoanhthu;
        private BindingSource reportBindingSource;
        private Label txtDoanhthu;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label txtTXe;
        private Label txtTDT;
        private Label txtSoXe;
        private Label txtTien;
        private Button button4;
        private FlowLayoutPanel flButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn company;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewTextBoxColumn Price;
    }
}