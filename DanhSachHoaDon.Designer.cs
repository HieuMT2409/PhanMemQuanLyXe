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
            IdOrder = new DataGridViewTextBoxColumn();
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
            dataOrder.Columns.AddRange(new DataGridViewColumn[] { IdOrder, nameUserDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn, nameCarDataGridViewTextBoxColumn, typePayDataGridViewTextBoxColumn });
            dataOrder.DataSource = orderBindingSource;
            dataOrder.Dock = DockStyle.Fill;
            dataOrder.Location = new Point(0, 0);
            dataOrder.Margin = new Padding(3, 4, 3, 4);
            dataOrder.Name = "dataOrder";
            dataOrder.ReadOnly = true;
            dataOrder.RowHeadersWidth = 51;
            dataOrder.RowTemplate.Height = 25;
            dataOrder.Size = new Size(846, 557);
            dataOrder.TabIndex = 10;
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
            ClientSize = new Size(846, 557);
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
        private DataGridViewTextBoxColumn IdOrder;
        private DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
    }
}