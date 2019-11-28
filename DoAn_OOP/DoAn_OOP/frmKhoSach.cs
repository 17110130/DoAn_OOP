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
    public partial class frmKhoSach : Form
    {
        public frmKhoSach(string idsach)
        {
            InitializeComponent();
            this.idsach = idsach;
        }
        QLThuvien1DataContext db = new QLThuvien1DataContext();
        private string idsach;
        
        private void frmKhoSach_Load(object sender, EventArgs e)
        {
            Load_datasach();
            Load_cbbtheloai();
            Load_cbbnhaxb();

        }
        public void Load_datasach()
        {
            dtgvKhoSach.DataSource = from s in db.ThongTinSaches select new { s.IDSach, s.IDTheLoai, s.TenSach,s.TacGia,s.NhaXuatBan,s.NgayNhapKho,s.Gia,s.TonKe};
        }
        public void Load_cbbtheloai()
        {
            cbbTheLoai.DataSource = db.TheLoais.ToList();
            cbbTheLoai.DisplayMember = "IDTheLoai";
            cbbTheLoai.SelectedIndex = -1;
        }
        public void Load_cbbnhaxb()
        {
            cbbNhaXuatBan.DataSource = db.NhaXuatBans.ToList();            
            cbbNhaXuatBan.DisplayMember = "IDNhaXuatBan";
            cbbNhaXuatBan.SelectedIndex = -1;
        }

        private void dtgvKhoSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvKhoSach.Rows[e.RowIndex];
            try
            {
                cbbTheLoai.Text = row.Cells[1].Value.ToString();
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[2].Value.ToString();
                txtTacGia.Text = row.Cells[3].Value.ToString();
                cbbNhaXuatBan.Text = row.Cells[4].Value.ToString();
                dtpNgayNhapKho.Text = row.Cells[5].Value.ToString();
                txtGiaSach.Text = row.Cells[6].Value.ToString();
                txtTonKho.Text = row.Cells[7].Value.ToString();

            }
            catch (Exception) { }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.cbbTheLoai.Text = "";
            this.txtMaSach.Text = "";
            this.txtTenSach.Text = "";
            this.txtTacGia.Text = "";
            this.cbbNhaXuatBan.Text = "";
            this.dtpNgayNhapKho.Text = "";
            this.txtGiaSach.Text = "";
            this.txtTonKho.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTinSach sach = new ThongTinSach();
            var id = db.ThongTinSaches.Count();
            id++;
            var mh = "MS";
            if (id < 10) mh = mh + "000" + id;
            else if (id < 100) mh = mh + "00" + id;
            else if (id < 1000) mh = mh + "0" + id;
            else mh = (mh + id).ToString();
            var idsach = txtMaSach.Text.Substring(0,0).ToUpper() + mh;

            try
            {
                sach.IDTheLoai = cbbTheLoai.Text;
                sach.IDSach = idsach;
                sach.TenSach = txtTenSach.Text;
                sach.TacGia = txtTacGia.Text;
                sach.NhaXuatBan = cbbNhaXuatBan.Text;
                sach.NgayNhapKho = DateTime.Parse(dtpNgayNhapKho.Text);
                sach.Gia = int.Parse(txtGiaSach.Text);
                sach.TonKe = int.Parse(txtTonKho.Text);
                db.ThongTinSaches.InsertOnSubmit(sach);
                db.SubmitChanges();
                Load_datasach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi1!!"); throw ex;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThongTinSach sach = new ThongTinSach();
            try
            {
                sach = db.ThongTinSaches.Where(s => s.IDSach == txtMaSach.Text).Single();
                sach.IDTheLoai = cbbTheLoai.Text;
                sach.TenSach = txtTenSach.Text;
                sach.TacGia = txtTacGia.Text;
                sach.NhaXuatBan = cbbNhaXuatBan.Text;
                sach.NgayNhapKho = DateTime.Parse(dtpNgayNhapKho.Text);
                sach.Gia = int.Parse(txtGiaSach.Text);
                sach.TonKe = int.Parse(txtTonKho.Text);
                db.SubmitChanges();
                Load_datasach();

            }
            catch(Exception)
            { 
                MessageBox.Show("lỗi rồi");                
            }            

        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            ThongTinSach sach = new ThongTinSach();
            try               
            {
                sach = db.ThongTinSaches.Where(s => s.IDSach == txtMaSach.Text).Single();
                sach.IDTheLoai = cbbTheLoai.Text;
                sach.TenSach = txtTenSach.Text;
                sach.TacGia = txtTacGia.Text;
                sach.NhaXuatBan = cbbNhaXuatBan.Text;
                sach.NgayNhapKho = DateTime.Parse(dtpNgayNhapKho.Text);
                sach.Gia = int.Parse(txtGiaSach.Text);
                sach.TonKe = int.Parse(txtTonKho.Text);
                db.ThongTinSaches.DeleteOnSubmit(sach);
                db.SubmitChanges();
                Load_datasach();
                this.cbbTheLoai.Text = "";
                this.txtMaSach.Text = "";
                this.txtTenSach.Text = "";
                this.txtTacGia.Text = "";
                this.cbbNhaXuatBan.Text = "";
                this.dtpNgayNhapKho.Text = "";
                this.txtGiaSach.Text = "";
                this.txtTonKho.Text = "";
            }
            catch (Exception) { MessageBox.Show("lỗi3"); }

        }
    }
}
