using ThueXeOTo.Database;

namespace ThueXeOTo
{
    partial class DanhSachXe
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
            dataCar = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            btnDel = new Button();
            btnFix = new Button();
            btnAdd = new Button();
            carDBContextBindingSource = new BindingSource(components);
            initDBcarBindingSource = new BindingSource(components);
            txbSearch = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initDBcarBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataCar
            // 
            dataCar.AllowUserToAddRows = false;
            dataCar.AllowUserToDeleteRows = false;
            dataCar.AutoGenerateColumns = false;
            dataCar.BackgroundColor = SystemColors.ControlLightLight;
            dataCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCar.Columns.AddRange(new DataGridViewColumn[] { Id, nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, companyDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn });
            dataCar.DataSource = carBindingSource;
            dataCar.Location = new Point(12, 60);
            dataCar.Margin = new Padding(3, 4, 3, 4);
            dataCar.Name = "dataCar";
            dataCar.ReadOnly = true;
            dataCar.RowHeadersWidth = 51;
            dataCar.RowTemplate.Height = 25;
            dataCar.Size = new Size(831, 491);
            dataCar.TabIndex = 2;
            dataCar.CellContentClick += dataCar_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "ID";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Tên Xe";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Loại Xe";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            companyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            companyDataGridViewTextBoxColumn.HeaderText = "Hãng Xe";
            companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // btnDel
            // 
            btnDel.Location = new Point(679, 16);
            btnDel.Margin = new Padding(3, 4, 3, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(70, 36);
            btnDel.TabIndex = 3;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnFix
            // 
            btnFix.Location = new Point(604, 16);
            btnFix.Margin = new Padding(3, 4, 3, 4);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(69, 36);
            btnFix.TabIndex = 4;
            btnFix.Text = "Sửa";
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += btnFix_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(530, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // carDBContextBindingSource
            // 
            carDBContextBindingSource.DataSource = typeof(CarDBContext);
            // 
            // initDBcarBindingSource
            // 
            initDBcarBindingSource.DataSource = typeof(Migrations.InitDBcar);
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(117, 22);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(315, 27);
            txbSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(438, 16);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 36);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "Nhập từ khóa";
            // 
            // DanhSachXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(843, 557);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnFix);
            Controls.Add(btnDel);
            Controls.Add(dataCar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DanhSachXe";
            Text = "DanhSachXe";
            Load += DanhSachXe_Load;
            ((System.ComponentModel.ISupportInitialize)dataCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initDBcarBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataCar;
        private Button btnDel;
        private Button btnFix;
        private Button btnAdd;
        private BindingSource carBindingSource;
        private BindingSource carDBContextBindingSource;
        private BindingSource initDBcarBindingSource;
        private Label label1;
        private TextBox txbSearch;
        private Button btnSearch;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}