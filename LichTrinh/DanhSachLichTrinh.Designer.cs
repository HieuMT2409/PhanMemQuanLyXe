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
            nameUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            OrderID = new DataGridViewTextBoxColumn();
            nameCarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            featureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)dataLichTrinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataLichTrinh
            // 
            dataLichTrinh.AllowUserToAddRows = false;
            dataLichTrinh.AllowUserToDeleteRows = false;
            dataLichTrinh.AutoGenerateColumns = false;
            dataLichTrinh.BackgroundColor = Color.White;
            dataLichTrinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLichTrinh.Columns.AddRange(new DataGridViewColumn[] { nameUserDataGridViewTextBoxColumn, OrderID, nameCarDataGridViewTextBoxColumn, featureDataGridViewTextBoxColumn, timeInDataGridViewTextBoxColumn, timeOutDataGridViewTextBoxColumn });
            dataLichTrinh.DataSource = orderBindingSource;
            dataLichTrinh.Location = new Point(0, 0);
            dataLichTrinh.Margin = new Padding(3, 4, 3, 4);
            dataLichTrinh.Name = "dataLichTrinh";
            dataLichTrinh.ReadOnly = true;
            dataLichTrinh.RowHeadersWidth = 51;
            dataLichTrinh.RowTemplate.Height = 25;
            dataLichTrinh.Size = new Size(843, 492);
            dataLichTrinh.TabIndex = 11;
            dataLichTrinh.CellContentClick += dataKH_CellContentClick;
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
            // OrderID
            // 
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Visible = false;
            OrderID.Width = 125;
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
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Database.Order);
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPay.Location = new Point(718, 512);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(114, 54);
            btnPay.TabIndex = 12;
            btnPay.Text = "Trả xe";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // DanhSachLichTrinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 591);
            Controls.Add(btnPay);
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
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
        private Button btnPay;
        private DataGridViewTextBoxColumn nameUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn nameCarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn featureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
    }
}