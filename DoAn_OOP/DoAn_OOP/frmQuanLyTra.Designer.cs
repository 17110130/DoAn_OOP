namespace DoAn_OOP
{
    partial class frmQuanLyTra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvSachMuon = new System.Windows.Forms.DataGridView();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgMuon = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 356);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTra);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblQuaHan);
            this.groupBox2.Controls.Add(this.dtpHanTra);
            this.groupBox2.Controls.Add(this.dtpNgMuon);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(474, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 312);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mượn:";
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(266, 262);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(89, 42);
            this.btnTra.TabIndex = 7;
            this.btnTra.Text = "Trả";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvSachMuon);
            this.groupBox3.Location = new System.Drawing.Point(14, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 153);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sách đã mượn:";
            // 
            // dtgvSachMuon
            // 
            this.dtgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSachMuon.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgvSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSachMuon.Location = new System.Drawing.Point(3, 18);
            this.dtgvSachMuon.Name = "dtgvSachMuon";
            this.dtgvSachMuon.Size = new System.Drawing.Size(380, 132);
            this.dtgvSachMuon.TabIndex = 0;
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.BackColor = System.Drawing.Color.Bisque;
            this.lblQuaHan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuaHan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblQuaHan.Location = new System.Drawing.Point(134, 79);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(230, 21);
            this.lblQuaHan.TabIndex = 5;
            this.lblQuaHan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(134, 48);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(230, 22);
            this.dtpHanTra.TabIndex = 3;
            // 
            // dtpNgMuon
            // 
            this.dtpNgMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgMuon.Location = new System.Drawing.Point(134, 18);
            this.dtpNgMuon.Name = "dtpNgMuon";
            this.dtpNgMuon.Size = new System.Drawing.Size(230, 22);
            this.dtpNgMuon.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Số ngày quá hạn:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Hạn trả:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ngày mượn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXong);
            this.groupBox1.Controls.Add(this.cbMaDG);
            this.groupBox1.Controls.Add(this.dtpNgSinh);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả:";
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgSinh.Location = new System.Drawing.Point(96, 101);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(230, 22);
            this.dtpNgSinh.TabIndex = 3;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(218, 77);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(42, 19);
            this.radNu.TabIndex = 2;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(99, 77);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(50, 19);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.Bisque;
            this.lblSDT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSDT.Location = new System.Drawing.Point(96, 162);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(230, 21);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.BackColor = System.Drawing.Color.Bisque;
            this.lblDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDiaChi.Location = new System.Drawing.Point(96, 133);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(230, 21);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Bisque;
            this.lblHoTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoTen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHoTen.Location = new System.Drawing.Point(96, 48);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(230, 21);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ĐG:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTongTien);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(135, 381);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(599, 60);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.Bisque;
            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongTien.Location = new System.Drawing.Point(3, 18);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(593, 39);
            this.lblTongTien.TabIndex = 0;
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(97, 17);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(230, 23);
            this.cbMaDG.TabIndex = 4;
            this.cbMaDG.SelectedIndexChanged += new System.EventHandler(this.cbMaDG_SelectedIndexChanged);
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(238, 205);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(89, 43);
            this.btnXong.TabIndex = 5;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // frmQuanLyTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(933, 536);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Trả";
            this.Load += new System.EventHandler(this.frmQuanLyTra_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpNgMuon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.DataGridView dtgvSachMuon;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.Button btnXong;
    }
}