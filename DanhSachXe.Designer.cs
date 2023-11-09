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
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            carDBContextBindingSource = new BindingSource(components);
            initDBcarBindingSource = new BindingSource(components);
            btnChoose = new Button();
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
            dataCar.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, companyDataGridViewTextBoxColumn });
            dataCar.DataSource = carBindingSource;
            dataCar.Location = new Point(0, 66);
            dataCar.Margin = new Padding(3, 4, 3, 4);
            dataCar.Name = "dataCar";
            dataCar.ReadOnly = true;
            dataCar.RowHeadersWidth = 51;
            dataCar.RowTemplate.Height = 25;
            dataCar.Size = new Size(843, 491);
            dataCar.TabIndex = 2;
            dataCar.CellContentClick += dataCar_CellContentClick;
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
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // button2
            // 
            button2.Location = new Point(508, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 3;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(409, 13);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(93, 50);
            button3.TabIndex = 4;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(311, 13);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(92, 50);
            button4.TabIndex = 5;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = true;
            // 
            // carDBContextBindingSource
            // 
            carDBContextBindingSource.DataSource = typeof(CarDBContext);
            // 
            // initDBcarBindingSource
            // 
            initDBcarBindingSource.DataSource = typeof(Migrations.InitDBcar);
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(688, 484);
            btnChoose.Margin = new Padding(3, 4, 3, 4);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(143, 50);
            btnChoose.TabIndex = 6;
            btnChoose.Text = "Chọn";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // DanhSachXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(843, 557);
            Controls.Add(btnChoose);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        }

        #endregion
        public DataGridView dataCar;
        private Button button2;
        private Button button3;
        private Button button4;
        private BindingSource carBindingSource;
        private BindingSource carDBContextBindingSource;
        private BindingSource initDBcarBindingSource;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private Button btnChoose;
        private Label label1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
    }
}