﻿namespace ThueXeOTo.OrderCar
{
    partial class ChooseCar
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
            dataDetailCar = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            companyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource = new BindingSource(components);
            btnChoose = new Button();
            txtID = new Label();
            txtName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataDetailCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataDetailCar
            // 
            dataDetailCar.AllowUserToAddRows = false;
            dataDetailCar.AllowUserToDeleteRows = false;
            dataDetailCar.AutoGenerateColumns = false;
            dataDetailCar.BackgroundColor = Color.White;
            dataDetailCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDetailCar.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, companyDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn });
            dataDetailCar.DataSource = carBindingSource;
            dataDetailCar.Dock = DockStyle.Fill;
            dataDetailCar.Location = new Point(0, 0);
            dataDetailCar.Name = "dataDetailCar";
            dataDetailCar.ReadOnly = true;
            dataDetailCar.RowHeadersWidth = 51;
            dataDetailCar.RowTemplate.Height = 29;
            dataDetailCar.Size = new Size(800, 450);
            dataDetailCar.TabIndex = 0;
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
            carBindingSource.DataSource = typeof(Database.Car);
            // 
            // btnChoose
            // 
            btnChoose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChoose.Location = new Point(663, 376);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(116, 62);
            btnChoose.TabIndex = 1;
            btnChoose.Text = "Chọn Xe";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.Location = new Point(197, 397);
            txtID.Name = "txtID";
            txtID.Size = new Size(22, 20);
            txtID.TabIndex = 3;
            txtID.Text = "id";
            txtID.Visible = false;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(280, 397);
            txtName.Name = "txtName";
            txtName.Size = new Size(46, 20);
            txtName.TabIndex = 4;
            txtName.Text = "name";
            txtName.Visible = false;
            // 
            // ChooseCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(btnChoose);
            Controls.Add(dataDetailCar);
            Name = "ChooseCar";
            Text = "ChooseCar";
            Load += ChooseCar_Load;
            ((System.ComponentModel.ISupportInitialize)dataDetailCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataDetailCar;
        private BindingSource carBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        public Button btnChoose;
        private Label txtID;
        private Label txtName;
    }
}