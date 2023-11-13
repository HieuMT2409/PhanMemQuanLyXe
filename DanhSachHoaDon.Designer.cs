namespace ThueXeOTo
{
    partial class DanhSachHoaDon
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
            dataOrder = new DataGridView();
            orderBindingSource = new BindingSource(components);
            carBindingSource = new BindingSource(components);
            carDBContextBindingSource = new BindingSource(components);
            initDBcarBindingSource = new BindingSource(components);
            btnAdd = new Button();
            IdOrder = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Feature = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            nameUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typePayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initDBcarBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataOrder
            // 
            dataOrder.AllowUserToAddRows = false;
            dataOrder.AllowUserToDeleteRows = false;
            dataOrder.AutoGenerateColumns = false;
            dataOrder.BackgroundColor = SystemColors.ControlLightLight;
            dataOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataOrder.Columns.AddRange(new DataGridViewColumn[] { IdOrder, Address, Feature, TimeIn, TimeOut, nameUserDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn, nameCarDataGridViewTextBoxColumn, typePayDataGridViewTextBoxColumn });
            dataOrder.DataSource = orderBindingSource;
            dataOrder.Location = new Point(0, 0);
            dataOrder.Margin = new Padding(3, 4, 3, 4);
            dataOrder.Name = "dataOrder";
            dataOrder.ReadOnly = true;
            dataOrder.RowHeadersWidth = 51;
            dataOrder.RowTemplate.Height = 25;
            dataOrder.Size = new Size(858, 515);
            dataOrder.TabIndex = 10;
            dataOrder.CellContentClick += dataOrder_CellContentClick;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Database.Order);
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Database.Car);
            // 
            // carDBContextBindingSource
            // 
            carDBContextBindingSource.DataSource = typeof(Database.CarDBContext);
            // 
            // initDBcarBindingSource
            // 
            initDBcarBindingSource.DataSource = typeof(Migrations.InitDBcar);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(727, 522);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 53);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Tạo hóa đơn";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // IdOrder
            // 
            IdOrder.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdOrder.DataPropertyName = "ID";
            IdOrder.HeaderText = "ID";
            IdOrder.MinimumWidth = 6;
            IdOrder.Name = "IdOrder";
            IdOrder.ReadOnly = true;
            IdOrder.Visible = false;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Visible = false;
            Address.Width = 125;
            // 
            // Feature
            // 
            Feature.DataPropertyName = "Feature";
            Feature.HeaderText = "Feature";
            Feature.MinimumWidth = 6;
            Feature.Name = "Feature";
            Feature.ReadOnly = true;
            Feature.Visible = false;
            Feature.Width = 125;
            // 
            // TimeIn
            // 
            TimeIn.DataPropertyName = "TimeIn";
            TimeIn.HeaderText = "TimeIn";
            TimeIn.MinimumWidth = 6;
            TimeIn.Name = "TimeIn";
            TimeIn.ReadOnly = true;
            TimeIn.Visible = false;
            TimeIn.Width = 125;
            // 
            // TimeOut
            // 
            TimeOut.DataPropertyName = "TimeOut";
            TimeOut.HeaderText = "TimeOut";
            TimeOut.MinimumWidth = 6;
            TimeOut.Name = "TimeOut";
            TimeOut.ReadOnly = true;
            TimeOut.Visible = false;
            TimeOut.Width = 125;
            // 
            // nameUserDataGridViewTextBoxColumn
            // 
            nameUserDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameUserDataGridViewTextBoxColumn.DataPropertyName = "NameUser";
            nameUserDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            nameUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameUserDataGridViewTextBoxColumn.Name = "nameUserDataGridViewTextBoxColumn";
            nameUserDataGridViewTextBoxColumn.ReadOnly = true;
            nameUserDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
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
            // nameCarDataGridViewTextBoxColumn
            // 
            nameCarDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameCarDataGridViewTextBoxColumn.DataPropertyName = "NameCar";
            nameCarDataGridViewTextBoxColumn.HeaderText = "Tên xe";
            nameCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCarDataGridViewTextBoxColumn.Name = "nameCarDataGridViewTextBoxColumn";
            nameCarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typePayDataGridViewTextBoxColumn
            // 
            typePayDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typePayDataGridViewTextBoxColumn.DataPropertyName = "TypePay";
            typePayDataGridViewTextBoxColumn.HeaderText = "Hình thức thanh toán";
            typePayDataGridViewTextBoxColumn.MinimumWidth = 6;
            typePayDataGridViewTextBoxColumn.Name = "typePayDataGridViewTextBoxColumn";
            typePayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(861, 587);
            Controls.Add(btnAdd);
            Controls.Add(dataOrder);
            Name = "DanhSachHoaDon";
            Text = "DanhSachHoaDon";
            Load += DanhSachHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initDBcarBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataOrder;
        private BindingSource carBindingSource;
        private BindingSource carDBContextBindingSource;
        private BindingSource initDBcarBindingSource;
        private BindingSource orderBindingSource;
        public Button btnAdd;
        private DataGridViewTextBoxColumn IdOrder;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Feature;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
    }
}