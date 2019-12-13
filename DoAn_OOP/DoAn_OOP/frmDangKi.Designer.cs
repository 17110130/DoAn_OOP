namespace DoAn_OOP
{
    partial class frmDangKi
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
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptcHinhNenDangKi = new System.Windows.Forms.PictureBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.radPQ1 = new System.Windows.Forms.RadioButton();
            this.radPQ2 = new System.Windows.Forms.RadioButton();
            this.radPQ3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHinhNenDangKi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPQ3);
            this.groupBox1.Controls.Add(this.radPQ2);
            this.groupBox1.Controls.Add(this.radPQ1);
            this.groupBox1.Controls.Add(this.txtNhapLaiMatKhau);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(164, 91);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '*';
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(336, 22);
            this.txtNhapLaiMatKhau.TabIndex = 1;
            this.txtNhapLaiMatKhau.TextChanged += new System.EventHandler(this.txtNhapLaiMatKhau_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(164, 54);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(336, 22);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(164, 18);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(336, 22);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(32, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phân quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // ptcHinhNenDangKi
            // 
            this.ptcHinhNenDangKi.BackColor = System.Drawing.Color.Silver;
            this.ptcHinhNenDangKi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcHinhNenDangKi.Location = new System.Drawing.Point(0, 0);
            this.ptcHinhNenDangKi.Name = "ptcHinhNenDangKi";
            this.ptcHinhNenDangKi.Size = new System.Drawing.Size(543, 254);
            this.ptcHinhNenDangKi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcHinhNenDangKi.TabIndex = 0;
            this.ptcHinhNenDangKi.TabStop = false;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Snow;
            this.btnTao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(263, 184);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(109, 35);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo Tài Khoản";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // radPQ1
            // 
            this.radPQ1.AutoSize = true;
            this.radPQ1.Location = new System.Drawing.Point(164, 128);
            this.radPQ1.Name = "radPQ1";
            this.radPQ1.Size = new System.Drawing.Size(32, 19);
            this.radPQ1.TabIndex = 2;
            this.radPQ1.TabStop = true;
            this.radPQ1.Text = "1";
            this.radPQ1.UseVisualStyleBackColor = true;
            // 
            // radPQ2
            // 
            this.radPQ2.AutoSize = true;
            this.radPQ2.Location = new System.Drawing.Point(286, 128);
            this.radPQ2.Name = "radPQ2";
            this.radPQ2.Size = new System.Drawing.Size(32, 19);
            this.radPQ2.TabIndex = 2;
            this.radPQ2.TabStop = true;
            this.radPQ2.Text = "2";
            this.radPQ2.UseVisualStyleBackColor = true;
            // 
            // radPQ3
            // 
            this.radPQ3.AutoSize = true;
            this.radPQ3.Location = new System.Drawing.Point(403, 128);
            this.radPQ3.Name = "radPQ3";
            this.radPQ3.Size = new System.Drawing.Size(32, 19);
            this.radPQ3.TabIndex = 2;
            this.radPQ3.TabStop = true;
            this.radPQ3.Text = "3";
            this.radPQ3.UseVisualStyleBackColor = true;
            // 
            // frmDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 254);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptcHinhNenDangKi);
            this.Name = "frmDangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Tài Khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcHinhNenDangKi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcHinhNenDangKi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.RadioButton radPQ3;
        private System.Windows.Forms.RadioButton radPQ2;
        private System.Windows.Forms.RadioButton radPQ1;
    }
}