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
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            orderBindingSource = new BindingSource(components);
            carBindingSource = new BindingSource(components);
            btnFix = new Button();
            btnDel = new Button();
            carDBContextBindingSource = new BindingSource(components);
            initDBcarBindingSource = new BindingSource(components);
            label2 = new Label();
            btnSearch = new Button();
            txbSearch = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
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
            dataKH.Columns.AddRange(new DataGridViewColumn[] { ID, Name, SDT, Address, ordersDataGridViewTextBoxColumn });
            dataKH.DataSource = customerBindingSource;
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
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Tên khách hàng";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // SDT
            // 
            SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            ordersDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            ordersDataGridViewTextBoxColumn.HeaderText = "Số hóa đơn";
            ordersDataGridViewTextBoxColumn.MinimumWidth = 6;
            ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            ordersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Database.Customer);
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
            btnFix.Location = new Point(600, 11);
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
            btnDel.Location = new Point(675, 11);
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
            // btnAdd
            // 
            btnAdd.Location = new Point(524, 11);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 36);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // DanhSachKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(843, 557);
            Controls.Add(btnAdd);
            Controls.Add(dataKH);
            Controls.Add(btnFix);
            Controls.Add(btnDel);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Text = "DanhSachKH";
            Load += DanhSachKH_Load;
            ((System.ComponentModel.ISupportInitialize)dataKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
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
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private BindingSource customerBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private Button btnAdd;
    }
}