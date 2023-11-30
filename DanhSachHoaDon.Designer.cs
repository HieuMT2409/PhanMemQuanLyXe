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
            Address = new DataGridViewTextBoxColumn();
            Feature = new DataGridViewTextBoxColumn();
            TimeIn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TimeOut = new DataGridViewTextBoxColumn();
            nameUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            carBindingSource = new BindingSource(components);
            carDBContextBindingSource = new BindingSource(components);
            initDBcarBindingSource = new BindingSource(components);
            btnAdd = new Button();
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
            dataOrder.BackgroundColor = Color.White;
            dataOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataOrder.Columns.AddRange(new DataGridViewColumn[] { Address, Feature, TimeIn, dataGridViewTextBoxColumn1, TimeOut, nameUserDataGridViewTextBoxColumn, nameCarDataGridViewTextBoxColumn });
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            dataGridViewTextBoxColumn1.HeaderText = "Số hóa đơn";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
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
            // nameCarDataGridViewTextBoxColumn
            // 
            nameCarDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameCarDataGridViewTextBoxColumn.DataPropertyName = "NameCar";
            nameCarDataGridViewTextBoxColumn.HeaderText = "Tên xe";
            nameCarDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCarDataGridViewTextBoxColumn.Name = "nameCarDataGridViewTextBoxColumn";
            nameCarDataGridViewTextBoxColumn.ReadOnly = true;
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
            // DanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Feature;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCarDataGridViewTextBoxColumn;
    }
}