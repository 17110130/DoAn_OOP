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
        public frmKhoSach()//string idsach)
        {
            InitializeComponent();
           // this.idsach = idsach;            
        }
        QLThuvien1DataContext db = new QLThuvien1DataContext();
       // private string idsach;
        
        private void frmKhoSach_Load(object sender, EventArgs e)
        {
            Load_datasach();
            Load_cbbtheloai();
            Load_cbbnhaxb();

        }
        public void Load_datasach()
        {
            dtgvKhoSach.DataSource = from s in db.ThongTinSaches select new { s.IDSach, s.IDTheLoai, s.TenSach,s.NhaXuatBan,s.NgayNhapKho,s.Gia,s.TonKho};
        }
        public void Load_cbbtheloai()
        {
            cbbTheLoai.DataSource = db.TheLoais.ToList();
            cbbTheLoai.DisplayMember = "TenTheLoai";
           // cbbTheLoai.ValueMember = "IDTheLoai";
            cbbTheLoai.SelectedIndex = -1;
        }
        public void Load_cbbnhaxb()
        {
            cbbNhaXuatBan.DataSource = db.NhaXuatBans.ToList();            
            cbbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            //cbbNhaXuatBan.ValueMember= "IDNhaXuatBan";
            cbbNhaXuatBan.SelectedIndex = -1;
        }

        private void dtgvKhoSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoaThongTin.Enabled = true;

            DataGridViewRow row = new DataGridViewRow();
            row = dtgvKhoSach.Rows[e.RowIndex];
            try
            {
                cbbTheLoai.Text = row.Cells[1].Value.ToString();
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[2].Value.ToString();
                cbbNhaXuatBan.Text = row.Cells[3].Value.ToString();
                dtpNgayNhapKho.Text = row.Cells[4].Value.ToString();
                txtGiaSach.Text = row.Cells[5].Value.ToString();
                txtTonKho.Text = row.Cells[6].Value.ToString();

            }
            catch (Exception) { }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Lam_moi();
        }

        public void Lam_moi()
        {
            this.cbbTheLoai.Text = "";
            this.txtMaSach.Text = "";
            this.txtTenSach.Text = "";
            this.cbbNhaXuatBan.Text = "";
            this.dtpNgayNhapKho.Text = "";
            this.txtGiaSach.Text = "";
            this.txtTonKho.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    ThongTinSach sach = new ThongTinSach();

                    var idtl = db.TheLoais.Where(p => p.TenTheLoai.Equals(cbbTheLoai.Text)).Select(x => x.IDTheLoai).Single();
                    var idnxb = db.NhaXuatBans.Where(p => p.TenNhaXuatBan.Equals(cbbNhaXuatBan.Text)).Select(x => x.IDNhaXuatBan).Single();

                    sach.IDTheLoai = idtl;
                    sach.IDSach = txtMaSach.Text;
                    sach.TenSach = txtTenSach.Text;
                    sach.NhaXuatBan = idnxb;
                    sach.NgayNhapKho = dtpNgayNhapKho.Value;
                    sach.Gia = txtGiaSach.Text;
                    sach.TonKho = int.Parse(txtTonKho.Text);

                    db.ThongTinSaches.InsertOnSubmit(sach);
                    db.SubmitChanges();

                    Load_datasach();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thêm được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }             
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QLThuvien1DataContext db = new QLThuvien1DataContext();
            ThongTinSach sach = new ThongTinSach();
            try
            {
                sach = db.ThongTinSaches.Where(s => s.IDSach == txtMaSach.Text).Single();
                sach.IDTheLoai = cbbTheLoai.Text;
                sach.TenSach = txtTenSach.Text;
                sach.NhaXuatBan = cbbNhaXuatBan.Text;
                sach.NgayNhapKho = dtpNgayNhapKho.Value;
                sach.Gia = txtGiaSach.Text;
                sach.TonKho = int.Parse(txtTonKho.Text);

                db.SubmitChanges();
                Load_datasach();
                Lam_moi();
            }
            catch(Exception)
            {
                MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }           

        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                ThongTinSach sach = new ThongTinSach();
                try
                {
                    sach = db.ThongTinSaches.Where(s => s.IDSach == txtMaSach.Text).Single();
                    //sach.IDTheLoai = cbbTheLoai.Text;
                    //sach.TenSach = txtTenSach.Text;
                    //sach.NhaXuatBan = cbbNhaXuatBan.Text;
                    //sach.NgayNhapKho = dtpNgayNhapKho.Value;
                    //sach.Gia = txtGiaSach.Text;
                    //sach.TonKho = int.Parse(txtTonKho.Text);

                    db.ThongTinSaches.DeleteOnSubmit(sach);
                    db.SubmitChanges();

                    Load_datasach();
                    Lam_moi();
                }
                catch (Exception) { MessageBox.Show("Không xóa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
