using System;
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
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }
        QLThuvien1DataContext db = new QLThuvien1DataContext();
        DocGia dg = new DocGia();
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            Load_datadocgia();
            dtgvDocGia.Columns["IDDocGia"].HeaderText = "Mã độc giả";
            dtgvDocGia.Columns["HoTen"].HeaderText = "Tên độc giả";
            dtgvDocGia.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgvDocGia.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvDocGia.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvDocGia.Columns["SDT"].HeaderText = "Số điện thoại";
            dtgvDocGia.Columns["ThanhVien"].HeaderText = "Thành Viên";
            dtgvDocGia.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void Load_datadocgia()
        {            
            dtgvDocGia.DataSource = from s in db.DocGias select new { s.IDDocGia, s.HoTen, s.GioiTinh, s.NgaySinh, s.DiaChi, s.SDT, s.ThanhVien };
        }
    }
}
