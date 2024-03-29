﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_OOP
{
    public partial class frmFormMain : Form
    {
        public frmFormMain()
        {
            InitializeComponent();

            if ( frmDangNhap.PQ == "2" )
            {
                btnNhaXuatBan.Enabled = false;
                btnTheLoai.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                
            }
            if ( frmDangNhap.PQ == "3" )
            {
                btnDocGia.Enabled = false;
                btnNhaXuatBan.Enabled = false;
                btnQuanLyMuon.Enabled = false;
                btnQuanLyTra.Enabled = false;
                btnTheLoai.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;

            }

        }

        private void btnQuanLyKhoSach_Click(object sender, EventArgs e)
        {
            frmKhoSach khosach = new frmKhoSach();
            khosach.ShowDialog();
            
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia dg = new frmDocGia();
            dg.ShowDialog();

        }

        private void btnQuanLyMuon_Click(object sender, EventArgs e)
        {
            frmQuanLyMuon qlm = new frmQuanLyMuon();
            qlm.ShowDialog();

        }

        private void btnQuanLyTra_Click(object sender, EventArgs e)
        {
            frmQuanLyTra qlt = new frmQuanLyTra();
            qlt.ShowDialog();

        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoai tl = new frmTheLoai();
            tl.ShowDialog();
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan nxb = new frmNhaXuatBan();
            nxb.ShowDialog();
        }

        private void tạoTàiKhoảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKi dk = new frmDangKi();

            dk.ShowDialog();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachTaiKhoan ds = new frmDanhSachTaiKhoan();
            ds.ShowDialog();
        }
    }
}
