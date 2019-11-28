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
            this.button1 = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
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
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(568, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 186);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thể Loại";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(568, 253);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(216, 186);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // frmFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.btnQuanLyMuon);
            this.Controls.Add(this.btnQuanLyTra);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThongKe;
    }
}

