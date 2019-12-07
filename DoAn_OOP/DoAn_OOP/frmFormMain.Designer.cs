namespace DoAn_OOP
{
    partial class frmFormMain
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
            this.btnQuanLyKhoSach = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnQuanLyTra = new System.Windows.Forms.Button();
            this.btnQuanLyMuon = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnNhaXuatBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyKhoSach
            // 
            this.btnQuanLyKhoSach.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLyKhoSach.FlatAppearance.BorderSize = 2;
            this.btnQuanLyKhoSach.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhoSach.Location = new System.Drawing.Point(132, 66);
            this.btnQuanLyKhoSach.Name = "btnQuanLyKhoSach";
            this.btnQuanLyKhoSach.Size = new System.Drawing.Size(216, 186);
            this.btnQuanLyKhoSach.TabIndex = 0;
            this.btnQuanLyKhoSach.Text = "Quản Lý Kho Sách";
            this.btnQuanLyKhoSach.UseVisualStyleBackColor = true;
            this.btnQuanLyKhoSach.Click += new System.EventHandler(this.btnQuanLyKhoSach_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Location = new System.Drawing.Point(350, 66);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(216, 186);
            this.btnDocGia.TabIndex = 0;
            this.btnDocGia.Text = "Quản Lý Độc Giả";
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnQuanLyTra
            // 
            this.btnQuanLyTra.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTra.Location = new System.Drawing.Point(350, 253);
            this.btnQuanLyTra.Name = "btnQuanLyTra";
            this.btnQuanLyTra.Size = new System.Drawing.Size(216, 186);
            this.btnQuanLyTra.TabIndex = 0;
            this.btnQuanLyTra.Text = "Quản Lý Trả";
            this.btnQuanLyTra.UseVisualStyleBackColor = true;
            this.btnQuanLyTra.Click += new System.EventHandler(this.btnQuanLyTra_Click);
            // 
            // btnQuanLyMuon
            // 
            this.btnQuanLyMuon.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMuon.Location = new System.Drawing.Point(132, 253);
            this.btnQuanLyMuon.Name = "btnQuanLyMuon";
            this.btnQuanLyMuon.Size = new System.Drawing.Size(216, 186);
            this.btnQuanLyMuon.TabIndex = 1;
            this.btnQuanLyMuon.Text = "Quản Lý Mượn";
            this.btnQuanLyMuon.UseVisualStyleBackColor = true;
            this.btnQuanLyMuon.Click += new System.EventHandler(this.btnQuanLyMuon_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.Location = new System.Drawing.Point(568, 66);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(216, 186);
            this.btnTheLoai.TabIndex = 0;
            this.btnTheLoai.Text = "Thể Loại";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnNhaXuatBan
            // 
            this.btnNhaXuatBan.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaXuatBan.Location = new System.Drawing.Point(568, 253);
            this.btnNhaXuatBan.Name = "btnNhaXuatBan";
            this.btnNhaXuatBan.Size = new System.Drawing.Size(216, 186);
            this.btnNhaXuatBan.TabIndex = 0;
            this.btnNhaXuatBan.Text = "Nhà Xuất Bản";
            this.btnNhaXuatBan.UseVisualStyleBackColor = true;
            this.btnNhaXuatBan.Click += new System.EventHandler(this.btnNhaXuatBan_Click);
            // 
            // frmFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.btnQuanLyMuon);
            this.Controls.Add(this.btnQuanLyTra);
            this.Controls.Add(this.btnNhaXuatBan);
            this.Controls.Add(this.btnTheLoai);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.btnQuanLyKhoSach);
            this.Name = "frmFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thư viện";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyKhoSach;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnQuanLyTra;
        private System.Windows.Forms.Button btnQuanLyMuon;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnNhaXuatBan;
    }
}

