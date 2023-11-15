namespace ThueXeOTo.KhachHang
{
    partial class DanhSachKH
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
            dataKH = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typePayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            carBindingSource = new BindingSource(components);
            btnFix = new Button();
            btnDel = new Button();
            carDBContextBindingSource = new BindingSource(components);
            initDBcarBindingSource = new BindingSource(components);
            label2 = new Label();
            btnSearch = new Button();
            txbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initDBcarBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataKH
            // 
            dataKH.AllowUserToAddRows = false;
            dataKH.AllowUserToDeleteRows = false;
            dataKH.AutoGenerateColumns = false;
            dataKH.BackgroundColor = SystemColors.ControlLightLight;
            dataKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataKH.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameUserDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, nameCarDataGridViewTextBoxColumn, featureDataGridViewTextBoxColumn, timeInDataGridViewTextBoxColumn, timeOutDataGridViewTextBoxColumn, typePayDataGridViewTextBoxColumn });
            dataKH.DataSource = orderBindingSource;
            dataKH.Location = new Point(6, 55);
            dataKH.Margin = new Padding(3, 4, 3, 4);
            dataKH.Name = "dataKH";
            dataKH.ReadOnly = true;
            dataKH.RowHeadersWidth = 51;
            dataKH.RowTemplate.Height = 25;
            dataKH.Size = new Size(831, 491);
            dataKH.TabIndex = 10;
            dataKH.CellContentClick += dataKH_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Visible = false;
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            nameUserDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameUserDataGridViewTextBoxColumn.DataPropertyName = "NameUser";
            nameUserDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            nameUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            nameUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            sDTDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameCarDataGridViewTextBoxColumn
            // 
            nameCarDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameCarDataGridViewTextBoxColumn.DataPropertyName = "NameCar";
            nameCarDataGridViewTextBoxColumn.HeaderText = "Xe đang thuê";
            nameCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCarDataGridViewTextBoxColumn.Name = "nameCarDataGridViewTextBoxColumn";
            nameCarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // featureDataGridViewTextBoxColumn
            // 
            featureDataGridViewTextBoxColumn.DataPropertyName = "Feature";
            featureDataGridViewTextBoxColumn.HeaderText = "Feature";
            featureDataGridViewTextBoxColumn.MinimumWidth = 6;
            featureDataGridViewTextBoxColumn.Name = "featureDataGridViewTextBoxColumn";
            featureDataGridViewTextBoxColumn.ReadOnly = true;
            featureDataGridViewTextBoxColumn.Visible = false;
            featureDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            timeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn";
            timeInDataGridViewTextBoxColumn.HeaderText = "TimeIn";
            timeInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            timeInDataGridViewTextBoxColumn.ReadOnly = true;
            timeInDataGridViewTextBoxColumn.Visible = false;
            timeInDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            timeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut";
            timeOutDataGridViewTextBoxColumn.HeaderText = "TimeOut";
            timeOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            timeOutDataGridViewTextBoxColumn.Visible = false;
            timeOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // typePayDataGridViewTextBoxColumn
            // 
            typePayDataGridViewTextBoxColumn.DataPropertyName = "TypePay";
            typePayDataGridViewTextBoxColumn.HeaderText = "TypePay";
            typePayDataGridViewTextBoxColumn.MinimumWidth = 6;
            typePayDataGridViewTextBoxColumn.Name = "typePayDataGridViewTextBoxColumn";
            typePayDataGridViewTextBoxColumn.ReadOnly = true;
            typePayDataGridViewTextBoxColumn.Visible = false;
            typePayDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Database.Order);
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Database.Car);
            // 
            // btnFix
            // 
            btnFix.Location = new Point(525, 11);
            btnFix.Margin = new Padding(3, 4, 3, 4);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(69, 36);
            btnFix.TabIndex = 12;
            btnFix.Text = "Sửa";
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += btnFix_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(600, 11);
            btnDel.Margin = new Padding(3, 4, 3, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(70, 36);
            btnDel.TabIndex = 11;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // carDBContextBindingSource
            // 
            carDBContextBindingSource.DataSource = typeof(Database.CarDBContext);
            // 
            // initDBcarBindingSource
            // 
            initDBcarBindingSource.DataSource = typeof(Migrations.InitDBcar);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 20);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 16;
            label2.Text = "Nhập từ khóa";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(432, 11);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 36);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(111, 17);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(315, 27);
            txbSearch.TabIndex = 14;
            // 
            // DanhSachKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(843, 557);
            Controls.Add(dataKH);
            Controls.Add(btnFix);
            Controls.Add(btnDel);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Name = "DanhSachKH";
            Text = "DanhSachKH";
            Load += DanhSachKH_Load;
            ((System.ComponentModel.ISupportInitialize)dataKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initDBcarBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataKH;
        private BindingSource carBindingSource;
        private Button btnFix;
        private Button btnDel;
        private BindingSource carDBContextBindingSource;
        private BindingSource initDBcarBindingSource;
        private Label label2;
        private Button btnSearch;
        private TextBox txbSearch;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
    }
}