﻿namespace DoAn_OOP
{
    partial class frmNhaXuatBan
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
            this.dtgvNhaXB = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiemNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeletenxb = new System.Windows.Forms.Button();
            this.btnUpdatenxb = new System.Windows.Forms.Button();
            this.btnClearnxb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNXB = new System.Windows.Forms.Button();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhaXB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvNhaXB
            // 
            this.dtgvNhaXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhaXB.Location = new System.Drawing.Point(9, 16);
            this.dtgvNhaXB.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvNhaXB.Name = "dtgvNhaXB";
            this.dtgvNhaXB.RowHeadersWidth = 51;
            this.dtgvNhaXB.RowTemplate.Height = 24;
            this.dtgvNhaXB.Size = new System.Drawing.Size(569, 374);
            this.dtgvNhaXB.TabIndex = 0;
            this.dtgvNhaXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhaXB_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTimKiemNXB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDeletenxb);
            this.panel1.Controls.Add(this.btnUpdatenxb);
            this.panel1.Controls.Add(this.btnClearnxb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddNXB);
            this.panel1.Controls.Add(this.txtTenNXB);
            this.panel1.Controls.Add(this.txtMaNXB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(590, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 374);
            this.panel1.TabIndex = 1;
            // 
            // txtTimKiemNXB
            // 
            this.txtTimKiemNXB.Location = new System.Drawing.Point(135, 256);
            this.txtTimKiemNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemNXB.Name = "txtTimKiemNXB";
            this.txtTimKiemNXB.Size = new System.Drawing.Size(174, 23);
            this.txtTimKiemNXB.TabIndex = 14;
            this.txtTimKiemNXB.TextChanged += new System.EventHandler(this.txtTimKiemNXB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm kiếm";
            // 
            // btnDeletenxb
            // 
            this.btnDeletenxb.Enabled = false;
            this.btnDeletenxb.Location = new System.Drawing.Point(239, 320);
            this.btnDeletenxb.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletenxb.Name = "btnDeletenxb";
            this.btnDeletenxb.Size = new System.Drawing.Size(68, 25);
            this.btnDeletenxb.TabIndex = 12;
            this.btnDeletenxb.Text = "Xóa";
            this.btnDeletenxb.UseVisualStyleBackColor = true;
            this.btnDeletenxb.Click += new System.EventHandler(this.btnDeletenxb_Click);
            // 
            // btnUpdatenxb
            // 
            this.btnUpdatenxb.Enabled = false;
            this.btnUpdatenxb.Location = new System.Drawing.Point(167, 320);
            this.btnUpdatenxb.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatenxb.Name = "btnUpdatenxb";
            this.btnUpdatenxb.Size = new System.Drawing.Size(68, 25);
            this.btnUpdatenxb.TabIndex = 11;
            this.btnUpdatenxb.Text = "Sửa";
            this.btnUpdatenxb.UseVisualStyleBackColor = true;
            this.btnUpdatenxb.Click += new System.EventHandler(this.btnUpdatenxb_Click);
            // 
            // btnClearnxb
            // 
            this.btnClearnxb.Location = new System.Drawing.Point(22, 320);
            this.btnClearnxb.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearnxb.Name = "btnClearnxb";
            this.btnClearnxb.Size = new System.Drawing.Size(68, 25);
            this.btnClearnxb.TabIndex = 10;
            this.btnClearnxb.Text = "Làm mới";
            this.btnClearnxb.UseVisualStyleBackColor = true;
            this.btnClearnxb.Click += new System.EventHandler(this.btnClearnxb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "NHÀ XUẤT BẢN";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(135, 206);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(174, 23);
            this.txtSdt.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(135, 158);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(174, 23);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // btnAddNXB
            // 
            this.btnAddNXB.Location = new System.Drawing.Point(94, 320);
            this.btnAddNXB.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNXB.Name = "btnAddNXB";
            this.btnAddNXB.Size = new System.Drawing.Size(68, 25);
            this.btnAddNXB.TabIndex = 4;
            this.btnAddNXB.Text = "Thêm";
            this.btnAddNXB.UseVisualStyleBackColor = true;
            this.btnAddNXB.Click += new System.EventHandler(this.btnAddNXB_Click);
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(135, 115);
            this.txtTenNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(174, 23);
            this.txtTenNXB.TabIndex = 3;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(135, 65);
            this.txtMaNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(174, 23);
            this.txtMaNXB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà xuất bản";
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvNhaXB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhaXuatBan";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhaXB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNhaXB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeletenxb;
        private System.Windows.Forms.Button btnUpdatenxb;
        private System.Windows.Forms.Button btnClearnxb;
        private System.Windows.Forms.TextBox txtTimKiemNXB;
        private System.Windows.Forms.Label label6;
    }
}