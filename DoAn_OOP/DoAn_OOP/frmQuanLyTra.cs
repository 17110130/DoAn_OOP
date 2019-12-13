using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_OOP
{
    public partial class frmQuanLyTra : Form
    {
        public frmQuanLyTra()
        {
            InitializeComponent();
        }

        private void frmQuanLyTra_Load(object sender, EventArgs e)
        {
            Load_MaDG();          
        }

        public void Load_MaDG()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                cbMaDG.DataSource = db.DocGias.ToList();
                cbMaDG.DisplayMember = "IDDocGia";
                cbMaDG.SelectedIndex = -1;
            }
        }

        public void Lam_Moi()
        {
            cbMaDG.Text = "";
            lblHoTen.Text = "";
            lblDiaChi.Text = "";
            lblQuaHan.Text = "";
            lblSDT.Text = "";
            lblTongTien.Text = "";
            dtpNgSinh.Value = DateTime.Now;
            dtpHanTra.Value = DateTime.Now;
            dtpNgMuon.Value = DateTime.Now;
            Load_dtgvSachMuon();

        }
        public void Load_Data()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                
                lblHoTen.Text = db.DocGias.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).Select(z => z.HoTen).FirstOrDefault();
                var gt= db.DocGias.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).Select(z => z.GioiTinh).FirstOrDefault();
                if (gt == true)
                    radNam.Checked = true;
                else radNu.Checked = true;
                var ns = db.DocGias.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).Select(z => z.NgaySinh).FirstOrDefault();
                if (ns != null)
                    dtpNgSinh.Value = (DateTime)ns;

                lblDiaChi.Text= db.DocGias.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).Select(z => z.DiaChi).FirstOrDefault();
                lblSDT.Text= db.DocGias.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).Select(z => z.SDT).FirstOrDefault();

                var ngaymuon = db.PhieuMuons.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).Select(z => z.NgayMuon).FirstOrDefault();
                if (ngaymuon != null)
                {
                    dtpNgMuon.Value = (DateTime)ngaymuon;
                }
                var hantra = db.PhieuMuons.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).Select(z => z.NgayTra).FirstOrDefault();
                if ( hantra != null )
                    dtpHanTra.Value = (DateTime)hantra;

                var qh = 0;
                int[] arrDay = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int month = dtpHanTra.Value.Month;
                int day = dtpHanTra.Value.Day;
                if ( month  == DateTime.Now.Month )
                {
                    qh = DateTime.Now.Day - day;
                }
                else
                {
                    if (DateTime.Now.Month - month == 1)
                        qh = arrDay[month] - day + DateTime.Now.Day;
                }
                if (qh < 0)
                    qh = 0;
                lblQuaHan.Text = qh + "";

                Load_dtgvSachMuon();

                
            }

        }

        public void Load_dtgvSachMuon()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                dtgvSachMuon.DataSource = from s in db.PhieuMuons
                                          from t in db.ThongTinSaches
                                          where s.IDSach == t.IDSach && s.IDDocGia == cbMaDG.Text
                                          select new
                                          {
                                              MaSach = s.IDSach,
                                              TenSach = t.TenSach,
                                              SoLuong = s.SoLuong,

                                          };
            }             
        }

        private void cbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                string ms = dtgvSachMuon.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();
                string ts = dtgvSachMuon.SelectedCells[0].OwningRow.Cells["TenSach"].Value.ToString();

                var edit = (from s in db.PhieuMuons
                            where s.IDDocGia == cbMaDG.Text && s.IDSach == ms
                            select s).Single();
                                 

                edit.SoLuong = edit.SoLuong - 1;
                int qh = int.Parse(lblQuaHan.Text);
                double total = 0;
                if ( qh > 0 )
                {
                    total = 1000 * qh;
                }
                lblTongTien.Text = total + "    VND";


                if (edit.SoLuong == 0)
                    db.PhieuMuons.DeleteOnSubmit(edit);

                db.SubmitChanges();

                Load_dtgvSachMuon();
            }
              

        }

        
        private void btnXong_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                if ( cbMaDG.Text != "" )
                {
                    var x = (from s in db.PhieuMuons
                             where s.IDDocGia == cbMaDG.Text
                             select s).SingleOrDefault();

                    if (x == null)
                    {
                        var dg = db.DocGias.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).SingleOrDefault();
                        db.DocGias.DeleteOnSubmit(dg);
                        db.SubmitChanges();
                    }
                }
               
                Load_MaDG();
                Lam_Moi();
            }           
        }

        private void frmQuanLyTra_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                if (cbMaDG.Text != "")
                {
                    var x = (from s in db.PhieuMuons
                             where s.IDDocGia == cbMaDG.Text
                             select s).SingleOrDefault();

                    if (x == null)
                    {
                        var dg = db.DocGias.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).SingleOrDefault();
                        db.DocGias.DeleteOnSubmit(dg);
                        db.SubmitChanges();
                    }
                }
                Load_MaDG();
                Lam_Moi();
            }
        }
    }
}
