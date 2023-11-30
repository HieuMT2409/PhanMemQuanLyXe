namespace ThueXeOTo.Input_Output
{
    partial class InOut
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
            data = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            btnXuat = new Button();
            btnImport = new Button();
            reportBindingSource = new BindingSource(components);
            datacar = new DataGridView();
            carBindingSource = new BindingSource(components);
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reportBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datacar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // data
            // 
            data.AllowUserToAddRows = false;
            data.AllowUserToDeleteRows = false;
            data.AutoGenerateColumns = false;
            data.BackgroundColor = Color.White;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn });
            data.DataSource = customerBindingSource;
            data.Location = new Point(1, 2);
            data.Name = "data";
            data.ReadOnly = true;
            data.RowHeadersWidth = 51;
            data.RowTemplate.Height = 29;
            data.Size = new Size(864, 336);
            data.TabIndex = 0;
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
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
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
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Database.Customer);
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXuat.Location = new Point(12, 352);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(180, 59);
            btnXuat.TabIndex = 1;
            btnXuat.Text = "Xuất dữ liệu khách hàng";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImport.Location = new Point(733, 352);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(125, 59);
            btnImport.TabIndex = 2;
            btnImport.Text = "Import dữ liệu";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // reportBindingSource
            // 
            reportBindingSource.DataSource = typeof(Database.Report);
            // 
            // datacar
            // 
            datacar.AllowUserToAddRows = false;
            datacar.AllowUserToDeleteRows = false;
            datacar.AutoGenerateColumns = false;
            datacar.BackgroundColor = Color.White;
            datacar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datacar.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Type, State, Company, Price });
            datacar.DataSource = carBindingSource;
            datacar.Location = new Point(1, 2);
            datacar.Name = "datacar";
            datacar.ReadOnly = true;
            datacar.RowHeadersWidth = 51;
            datacar.RowTemplate.Height = 29;
            datacar.Size = new Size(864, 336);
            datacar.TabIndex = 3;
            datacar.Visible = false;
            datacar.CellContentClick += datacar_CellContentClick;
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Database.Car);
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
            Name.HeaderText = "Tên Xe";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Loại Xe";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // State
            // 
            State.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            State.DataPropertyName = "State";
            State.HeaderText = "Trạng Thái";
            State.MinimumWidth = 6;
            State.Name = "State";
            State.ReadOnly = true;
            // 
            // Company
            // 
            Company.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Company.DataPropertyName = "Company";
            Company.HeaderText = "Hãng Xe";
            Company.MinimumWidth = 6;
            Company.Name = "Company";
            Company.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Giá Thuê";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // InOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(870, 423);
            Controls.Add(datacar);
            Controls.Add(btnImport);
            Controls.Add(btnXuat);
            Controls.Add(data);
            Text = "Nhập - Xuất dữ liệu";
            Load += InOut_Load;
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reportBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)datacar).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Button btnXuat;
        private Button btnImport;
        private BindingSource reportBindingSource;
        private DataGridView datacar;
        private BindingSource carBindingSource;
        private DataGridViewTextBoxColumn ID;
        private new DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Price;
    }
}