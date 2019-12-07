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
            this.btnTra = new System.Windows.Forms.Button();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvSachDaChon = new System.Windows.Forms.DataGridView();
            this.dtpHanTraSach = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuonSach = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChon = new System.Windows.Forms.Button();
            this.dtgvSachTimKiem = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvTheLoaiTimKiem = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTheLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaChon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachTimKiem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheLoaiTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKetThuc);
            this.groupBox1.Controls.Add(this.btnTra);
            this.groupBox1.Controls.Add(this.cbMaDG);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpHanTraSach);
            this.groupBox1.Controls.Add(this.dtpNgayMuonSach);
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
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Location = new System.Drawing.Point(824, 197);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(89, 42);
            this.btnTra.TabIndex = 17;
            this.btnTra.Text = "Trả";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(136, 35);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(268, 23);
            this.cbMaDG.TabIndex = 16;
            this.cbMaDG.SelectedIndexChanged += new System.EventHandler(this.cbMaDG_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvSachDaChon);
            this.groupBox2.Location = new System.Drawing.Point(475, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 178);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục sách đã chọn:";
            // 
            // dtgvSachDaChon
            // 
            this.dtgvSachDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSachDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSachDaChon.Location = new System.Drawing.Point(3, 18);
            this.dtgvSachDaChon.Name = "dtgvSachDaChon";
            this.dtgvSachDaChon.Size = new System.Drawing.Size(449, 157);
            this.dtgvSachDaChon.TabIndex = 0;
            // 
            // dtpHanTraSach
            // 
            this.dtpHanTraSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTraSach.Location = new System.Drawing.Point(136, 112);
            this.dtpHanTraSach.Name = "dtpHanTraSach";
            this.dtpHanTraSach.Size = new System.Drawing.Size(268, 22);
            this.dtpHanTraSach.TabIndex = 8;
            this.dtpHanTraSach.ValueChanged += new System.EventHandler(this.dtpHanTraSach_ValueChanged);
            // 
            // dtpNgayMuonSach
            // 
            this.dtpNgayMuonSach.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayMuonSach.Enabled = false;
            this.dtpNgayMuonSach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuonSach.Location = new System.Drawing.Point(136, 74);
            this.dtpNgayMuonSach.Name = "dtpNgayMuonSach";
            this.dtpNgayMuonSach.Size = new System.Drawing.Size(268, 22);
            this.dtpNgayMuonSach.TabIndex = 8;
            this.dtpNgayMuonSach.Value = new System.DateTime(2019, 12, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hạn Trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Độc Giả:";
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
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(349, 219);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(89, 42);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dtgvSachTimKiem
            // 
            this.dtgvSachTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSachTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSachTimKiem.Location = new System.Drawing.Point(15, 57);
            this.dtgvSachTimKiem.Name = "dtgvSachTimKiem";
            this.dtgvSachTimKiem.Size = new System.Drawing.Size(423, 156);
            this.dtgvSachTimKiem.TabIndex = 3;
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
            this.txtTimKiemSach.TextChanged += new System.EventHandler(this.txtTimKiemSach_TextChanged);
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
            // dtgvTheLoaiTimKiem
            // 
            this.dtgvTheLoaiTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTheLoaiTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTheLoaiTimKiem.Location = new System.Drawing.Point(9, 57);
            this.dtgvTheLoaiTimKiem.Name = "dtgvTheLoaiTimKiem";
            this.dtgvTheLoaiTimKiem.Size = new System.Drawing.Size(417, 156);
            this.dtgvTheLoaiTimKiem.TabIndex = 2;
            // 
            // txtTimKiemTheLoai
            // 
            this.txtTimKiemTheLoai.BackColor = System.Drawing.Color.Bisque;
            this.txtTimKiemTheLoai.Location = new System.Drawing.Point(163, 20);
            this.txtTimKiemTheLoai.Name = "txtTimKiemTheLoai";
            this.txtTimKiemTheLoai.Size = new System.Drawing.Size(260, 22);
            this.txtTimKiemTheLoai.TabIndex = 1;
            this.txtTimKiemTheLoai.TextChanged += new System.EventHandler(this.txtTimKiemTheLoai_TextChanged);
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
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(315, 163);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(89, 42);
            this.btnKetThuc.TabIndex = 18;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // frmQuanLyMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(933, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mượn";
            this.Load += new System.EventHandler(this.frmQuanLyMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachDaChon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSachTimKiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheLoaiTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayMuonSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHanTraSach;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.DataGridView dtgvSachDaChon;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnKetThuc;
    }
}