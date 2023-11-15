namespace ThueXeOTo.LichTrinh
{
    partial class DanhSachLichTrinh
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
            dataLichTrinh = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataLichTrinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataLichTrinh
            // 
            dataLichTrinh.AllowUserToAddRows = false;
            dataLichTrinh.AllowUserToDeleteRows = false;
            dataLichTrinh.AutoGenerateColumns = false;
            dataLichTrinh.BackgroundColor = SystemColors.ControlLightLight;
            dataLichTrinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLichTrinh.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameUserDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, nameCarDataGridViewTextBoxColumn, featureDataGridViewTextBoxColumn, timeInDataGridViewTextBoxColumn, timeOutDataGridViewTextBoxColumn, typePayDataGridViewTextBoxColumn });
            dataLichTrinh.DataSource = orderBindingSource;
            dataLichTrinh.Location = new Point(1, 1);
            dataLichTrinh.Margin = new Padding(3, 4, 3, 4);
            dataLichTrinh.Name = "dataLichTrinh";
            dataLichTrinh.ReadOnly = true;
            dataLichTrinh.RowHeadersWidth = 51;
            dataLichTrinh.RowTemplate.Height = 25;
            dataLichTrinh.Size = new Size(842, 491);
            dataLichTrinh.TabIndex = 11;
            dataLichTrinh.CellContentClick += dataKH_CellContentClick;
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
            sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            sDTDataGridViewTextBoxColumn.ReadOnly = true;
            sDTDataGridViewTextBoxColumn.Visible = false;
            sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Visible = false;
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCarDataGridViewTextBoxColumn
            // 
            nameCarDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameCarDataGridViewTextBoxColumn.DataPropertyName = "NameCar";
            nameCarDataGridViewTextBoxColumn.HeaderText = "Xe thuê";
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
            timeInDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn";
            timeInDataGridViewTextBoxColumn.HeaderText = "Thời gian thuê";
            timeInDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            timeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            timeOutDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut";
            timeOutDataGridViewTextBoxColumn.HeaderText = "Thời gian trả";
            timeOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typePayDataGridViewTextBoxColumn
            // 
            typePayDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typePayDataGridViewTextBoxColumn.DataPropertyName = "TypePay";
            typePayDataGridViewTextBoxColumn.HeaderText = "Thanh toán";
            typePayDataGridViewTextBoxColumn.MinimumWidth = 6;
            typePayDataGridViewTextBoxColumn.Name = "typePayDataGridViewTextBoxColumn";
            typePayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Database.Order);
            // 
            // DanhSachLichTrinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(843, 557);
            Controls.Add(dataLichTrinh);
            Name = "DanhSachLichTrinh";
            Text = "DanhSachLichTrinh";
            Load += DanhSachLichTrinh_Load;
            ((System.ComponentModel.ISupportInitialize)dataLichTrinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataLichTrinh;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
    }
}