namespace ThueXeOTo
{
    partial class TinhNangXe
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
            label1 = new Label();
            cbBando = new CheckBox();
            cbCameraCaple = new CheckBox();
            cbCambien = new CheckBox();
            cbCuaso = new CheckBox();
            cbUSB = new CheckBox();
            cbNap = new CheckBox();
            label2 = new Label();
            cb360 = new CheckBox();
            cbLop = new CheckBox();
            cbGPS = new CheckBox();
            cbVar = new CheckBox();
            cbCameraHT = new CheckBox();
            cbBluetooth = new CheckBox();
            cbCanhbao = new CheckBox();
            cbCameraLui = new CheckBox();
            rbAll = new RadioButton();
            rbXang = new RadioButton();
            rbDau = new RadioButton();
            rbDien = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtXe = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 120);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "Tính năng";
            // 
            // cbBando
            // 
            cbBando.AutoSize = true;
            cbBando.Location = new Point(27, 153);
            cbBando.Name = "cbBando";
            cbBando.Size = new Size(82, 24);
            cbBando.TabIndex = 1;
            cbBando.Text = "Bản đồ ";
            cbBando.UseVisualStyleBackColor = true;
            // 
            // cbCameraCaple
            // 
            cbCameraCaple.AutoSize = true;
            cbCameraCaple.ForeColor = Color.Black;
            cbCameraCaple.Location = new Point(27, 183);
            cbCameraCaple.Name = "cbCameraCaple";
            cbCameraCaple.Size = new Size(126, 24);
            cbCameraCaple.TabIndex = 2;
            cbCameraCaple.Text = "Camera cập lề";
            cbCameraCaple.UseVisualStyleBackColor = true;
            // 
            // cbCambien
            // 
            cbCambien.AutoSize = true;
            cbCambien.Location = new Point(27, 213);
            cbCambien.Name = "cbCambien";
            cbCambien.Size = new Size(120, 24);
            cbCambien.TabIndex = 3;
            cbCambien.Text = "Cảm biến lốp";
            cbCambien.UseVisualStyleBackColor = true;
            // 
            // cbCuaso
            // 
            cbCuaso.AutoSize = true;
            cbCuaso.Location = new Point(27, 243);
            cbCuaso.Name = "cbCuaso";
            cbCuaso.Size = new Size(103, 24);
            cbCuaso.TabIndex = 4;
            cbCuaso.Text = "Cửa sổ trời";
            cbCuaso.UseVisualStyleBackColor = true;
            cbCuaso.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // cbUSB
            // 
            cbUSB.AutoSize = true;
            cbUSB.Location = new Point(27, 273);
            cbUSB.Name = "cbUSB";
            cbUSB.Size = new Size(119, 24);
            cbUSB.TabIndex = 5;
            cbUSB.Text = "Khe cắm USB";
            cbUSB.UseVisualStyleBackColor = true;
            // 
            // cbNap
            // 
            cbNap.AutoSize = true;
            cbNap.Location = new Point(27, 303);
            cbNap.Name = "cbNap";
            cbNap.Size = new Size(170, 24);
            cbNap.TabIndex = 6;
            cbNap.Text = "Nắp thùng xe bán tải";
            cbNap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 355);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 7;
            label2.Text = "Nhiên liệu";
            // 
            // cb360
            // 
            cb360.AutoSize = true;
            cb360.Location = new Point(236, 303);
            cb360.Name = "cb360";
            cb360.Size = new Size(110, 24);
            cb360.TabIndex = 13;
            cb360.Text = "Camera 360";
            cb360.UseVisualStyleBackColor = true;
            // 
            // cbLop
            // 
            cbLop.AutoSize = true;
            cbLop.Location = new Point(236, 273);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(125, 24);
            cbLop.TabIndex = 12;
            cbLop.Text = "Lốp dự phòng";
            cbLop.UseVisualStyleBackColor = true;
            // 
            // cbGPS
            // 
            cbGPS.AutoSize = true;
            cbGPS.Location = new Point(236, 243);
            cbGPS.Name = "cbGPS";
            cbGPS.Size = new Size(107, 24);
            cbGPS.TabIndex = 11;
            cbGPS.Text = "Định vị GPS";
            cbGPS.UseVisualStyleBackColor = true;
            // 
            // cbVar
            // 
            cbVar.AutoSize = true;
            cbVar.Location = new Point(236, 213);
            cbVar.Name = "cbVar";
            cbVar.Size = new Size(153, 24);
            cbVar.TabIndex = 10;
            cbVar.Text = "Cảm biến va chạm";
            cbVar.UseVisualStyleBackColor = true;
            // 
            // cbCameraHT
            // 
            cbCameraHT.AutoSize = true;
            cbCameraHT.Location = new Point(236, 183);
            cbCameraHT.Name = "cbCameraHT";
            cbCameraHT.Size = new Size(152, 24);
            cbCameraHT.TabIndex = 9;
            cbCameraHT.Text = "Camera hành trình";
            cbCameraHT.UseVisualStyleBackColor = true;
            // 
            // cbBluetooth
            // 
            cbBluetooth.AutoSize = true;
            cbBluetooth.Location = new Point(236, 153);
            cbBluetooth.Name = "cbBluetooth";
            cbBluetooth.Size = new Size(96, 24);
            cbBluetooth.TabIndex = 8;
            cbBluetooth.Text = "Bluetooth";
            cbBluetooth.UseVisualStyleBackColor = true;
            // 
            // cbCanhbao
            // 
            cbCanhbao.AutoSize = true;
            cbCanhbao.Location = new Point(456, 183);
            cbCanhbao.Name = "cbCanhbao";
            cbCanhbao.Size = new Size(141, 24);
            cbCanhbao.TabIndex = 15;
            cbCanhbao.Text = "Cảnh báo tốc độ";
            cbCanhbao.UseVisualStyleBackColor = true;
            // 
            // cbCameraLui
            // 
            cbCameraLui.AutoSize = true;
            cbCameraLui.Location = new Point(456, 153);
            cbCameraLui.Name = "cbCameraLui";
            cbCameraLui.Size = new Size(102, 24);
            cbCameraLui.TabIndex = 14;
            cbCameraLui.Text = "Camera lùi";
            cbCameraLui.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            rbAll.AutoSize = true;
            rbAll.Location = new Point(26, 394);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(70, 24);
            rbAll.TabIndex = 16;
            rbAll.TabStop = true;
            rbAll.Text = "Tất cả";
            rbAll.UseVisualStyleBackColor = true;
            // 
            // rbXang
            // 
            rbXang.AutoSize = true;
            rbXang.Location = new Point(169, 394);
            rbXang.Name = "rbXang";
            rbXang.Size = new Size(64, 24);
            rbXang.TabIndex = 17;
            rbXang.TabStop = true;
            rbXang.Text = "Xăng";
            rbXang.UseVisualStyleBackColor = true;
            // 
            // rbDau
            // 
            rbDau.AutoSize = true;
            rbDau.Location = new Point(302, 394);
            rbDau.Name = "rbDau";
            rbDau.Size = new Size(102, 24);
            rbDau.TabIndex = 18;
            rbDau.TabStop = true;
            rbDau.Text = "Dầu Diesel";
            rbDau.UseVisualStyleBackColor = true;
            // 
            // rbDien
            // 
            rbDien.AutoSize = true;
            rbDien.Location = new Point(455, 394);
            rbDien.Name = "rbDien";
            rbDien.Size = new Size(61, 24);
            rbDien.TabIndex = 19;
            rbDien.TabStop = true;
            rbDien.Text = "Điện";
            rbDien.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(236, 438);
            button1.Name = "button1";
            button1.Size = new Size(171, 44);
            button1.TabIndex = 20;
            button1.Text = "Thuê Xe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(159, 9);
            label3.Name = "label3";
            label3.Size = new Size(350, 51);
            label3.TabIndex = 21;
            label3.Text = "REFUND CAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 75);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 22;
            label4.Text = "Xe đang chọn: ";
            // 
            // txtXe
            // 
            txtXe.AutoSize = true;
            txtXe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtXe.Location = new Point(159, 75);
            txtXe.Name = "txtXe";
            txtXe.Size = new Size(51, 23);
            txtXe.TabIndex = 23;
            txtXe.Text = "Xe A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 97);
            label6.Name = "label6";
            label6.Size = new Size(598, 23);
            label6.TabIndex = 24;
            label6.Text = "------------------------------------------------------------------------------------";
            // 
            // TinhNangXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(680, 506);
            Controls.Add(label6);
            Controls.Add(txtXe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(rbDien);
            Controls.Add(rbDau);
            Controls.Add(rbXang);
            Controls.Add(rbAll);
            Controls.Add(cbCanhbao);
            Controls.Add(cbCameraLui);
            Controls.Add(cb360);
            Controls.Add(cbLop);
            Controls.Add(cbGPS);
            Controls.Add(cbVar);
            Controls.Add(cbCameraHT);
            Controls.Add(cbBluetooth);
            Controls.Add(label2);
            Controls.Add(cbNap);
            Controls.Add(cbUSB);
            Controls.Add(cbCuaso);
            Controls.Add(cbCambien);
            Controls.Add(cbCameraCaple);
            Controls.Add(cbBando);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "TinhNangXe";
            Text = "TinhNangXe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox cbBando;
        private CheckBox cbCameraCaple;
        private CheckBox cbCambien;
        private CheckBox cbCuaso;
        private CheckBox cbUSB;
        private CheckBox cbNap;
        private Label label2;
        private CheckBox cb360;
        private CheckBox cbLop;
        private CheckBox cbGPS;
        private CheckBox cbVar;
        private CheckBox cbCameraHT;
        private CheckBox cbBluetooth;
        private CheckBox cbCanhbao;
        private CheckBox cbCameraLui;
        private RadioButton rbAll;
        private RadioButton rbXang;
        private RadioButton rbDau;
        private RadioButton rbDien;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label txtXe;
        private Label label6;
    }
}