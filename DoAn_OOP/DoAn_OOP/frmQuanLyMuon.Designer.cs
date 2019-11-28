namespace DoAn_OOP
{
    partial class frmQuanLyMuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHanTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.dtpNgayMuonSach = new System.Windows.Forms.DateTimePicker();
            this.dtpHanTraSach = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvSachDaChon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiemTheLoai = new System.Windows.Forms.TextBox();
            this.dtgvTheLoaiTimKiem = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.dtgvSachTimKiem = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaChon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheLoaiTimKiem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpHanTraSach);
            this.groupBox1.Controls.Add(this.dtpNgayMuonSach);
            this.groupBox1.Controls.Add(this.cbMaDG);
            this.groupBox1.Controls.Add(this.txtHanTra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Mươn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Độc Giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hạn Trả:";
            // 
            // txtHanTra
            // 
            this.txtHanTra.Location = new System.Drawing.Point(116, 101);
            this.txtHanTra.Name = "txtHanTra";
            this.txtHanTra.Size = new System.Drawing.Size(41, 22);
            this.txtHanTra.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày";
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(116, 24);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(294, 23);
            this.cbMaDG.TabIndex = 7;
            // 
            // dtpNgayMuonSach
            // 
            this.dtpNgayMuonSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuonSach.Location = new System.Drawing.Point(116, 63);
            this.dtpNgayMuonSach.Name = "dtpNgayMuonSach";
            this.dtpNgayMuonSach.Size = new System.Drawing.Size(294, 22);
            this.dtpNgayMuonSach.TabIndex = 8;
            // 
            // dtpHanTraSach
            // 
            this.dtpHanTraSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTraSach.Location = new System.Drawing.Point(246, 101);
            this.dtpHanTraSach.Name = "dtpHanTraSach";
            this.dtpHanTraSach.Size = new System.Drawing.Size(164, 22);
            this.dtpHanTraSach.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvSachDaChon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(475, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 224);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục sách đã chọn:";
            // 
            // dtgvSachDaChon
            // 
            this.dtgvSachDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSachDaChon.Location = new System.Drawing.Point(3, 18);
            this.dtgvSachDaChon.Name = "dtgvSachDaChon";
            this.dtgvSachDaChon.Size = new System.Drawing.Size(449, 203);
            this.dtgvSachDaChon.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(933, 291);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra Cứu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvTheLoaiTimKiem);
            this.panel1.Controls.Add(this.txtTimKiemTheLoai);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 270);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm thể loại:";
            // 
            // txtTimKiemTheLoai
            // 
            this.txtTimKiemTheLoai.Location = new System.Drawing.Point(163, 20);
            this.txtTimKiemTheLoai.Name = "txtTimKiemTheLoai";
            this.txtTimKiemTheLoai.Size = new System.Drawing.Size(260, 22);
            this.txtTimKiemTheLoai.TabIndex = 1;
            // 
            // dtgvTheLoaiTimKiem
            // 
            this.dtgvTheLoaiTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTheLoaiTimKiem.Location = new System.Drawing.Point(32, 57);
            this.dtgvTheLoaiTimKiem.Name = "dtgvTheLoaiTimKiem";
            this.dtgvTheLoaiTimKiem.Size = new System.Drawing.Size(394, 156);
            this.dtgvTheLoaiTimKiem.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChon);
            this.panel2.Controls.Add(this.dtgvSachTimKiem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTimKiemSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(475, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 270);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm sách:";
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(139, 20);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(299, 22);
            this.txtTimKiemSach.TabIndex = 1;
            // 
            // dtgvSachTimKiem
            // 
            this.dtgvSachTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachTimKiem.Location = new System.Drawing.Point(25, 57);
            this.dtgvSachTimKiem.Name = "dtgvSachTimKiem";
            this.dtgvSachTimKiem.Size = new System.Drawing.Size(413, 156);
            this.dtgvSachTimKiem.TabIndex = 3;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(349, 219);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(89, 42);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyMuon";
            this.Text = "Quản Lý Mượn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaChon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheLoaiTimKiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayMuonSach;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.TextBox txtHanTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHanTraSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvSachDaChon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvTheLoaiTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvSachTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Button btnChon;
    }
}