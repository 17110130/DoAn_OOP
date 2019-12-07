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
            dtgvDocGia.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void Load_datadocgia()
        {            
            dtgvDocGia.DataSource = from s in db.DocGias select new { s.IDDocGia, s.HoTen, s.GioiTinh, s.NgaySinh, s.DiaChi, s.SDT};
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    DocGia d = db.DocGias.Where(p => p.IDDocGia.Equals(txtMaDocGia.Text)).Single();

                    d.HoTen = txtHoTen.Text;
                    d.GioiTinh = radNam.Checked ? true : false;
                    d.NgaySinh = dtpNgaySinh.Value;
                    d.DiaChi = txtDiaChi.Text;
                    d.SDT = txtSDT.Text;

                    db.SubmitChanges();

                    Load_datadocgia();
                    Lam_moi();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    string n = "";
                    ThamDinh td = new ThamDinh();

                    n += td.kiemTra_Rong("Mã độc giả", txtMaDocGia);
                    n += td.kiemTra_Rong("Họ tên", txtHoTen);
                    n += td.Check_radio(radNam, radNu);
                    
                    if ( n != "" )
                    {
                        MessageBox.Show(n);
                        return;
                    }
                  
                    var idDG = txtMaDocGia.Text;
                    var t = db.DocGias.Where(p => p.IDDocGia.Equals(idDG)).Select(s => s.IDDocGia).SingleOrDefault();

                    if ( t == idDG )
                    {
                        MessageBox.Show("Mã độc giả đã tồn tại!");
                        txtMaDocGia.Text = "";
                        return;
                    }
                    DocGia d = new DocGia();

                    d.IDDocGia = txtMaDocGia.Text;
                    d.HoTen = txtHoTen.Text;
                    var sex = radNam.Checked ? true : false;
                    d.GioiTinh = sex;
                    if (dtpNgaySinh.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                        d.NgaySinh = null;
                    else d.NgaySinh = (DateTime)dtpNgaySinh.Value;
                    d.DiaChi = txtDiaChi.Text;
                    d.SDT = txtSDT.Text;

                    db.DocGias.InsertOnSubmit(d);
                    db.SubmitChanges();

                    Load_datadocgia();
                    Lam_moi();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Xoa_DocGia()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                //var t = db.PhieuMuons.Where(p => p.IDDocGia.Equals(txtMaDocGia.Text)).Select(z => z);

                //if ( t.Count() == 0 )
                //{
                    try
                    {
                        DocGia d = db.DocGias.Where(p => p.IDDocGia.Equals(txtMaDocGia.Text)).SingleOrDefault();

                        db.DocGias.DeleteOnSubmit(d);
                        db.SubmitChanges();

                        Load_datadocgia();
                        Lam_moi();
                    }
                    catch (Exception)
                    { MessageBox.Show("Không xóa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                //}
                //else
                //{
                //    MessageBox.Show("Không thể xóa độc giả vì có phiếu mượn chưa trả")
                //}
                
                            
            }
        }

        public void Lam_moi()
        {
            txtMaDocGia.Text = "";
            txtHoTen.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Lam_moi();
        }

        private void dtgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;        

            DataGridViewRow row = new DataGridViewRow();
            row = dtgvDocGia.Rows[e.RowIndex];
            try
            {
                txtMaDocGia.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                var gioitinh = row.Cells[2].Value.ToString();
                if (gioitinh == "True")
                    radNam.Checked = true;
                else radNu.Checked = true;
                var ns = row.Cells[3].Value;
                dtpNgaySinh.Value = (DateTime)ns;
                txtDiaChi.Text= row.Cells[4].Value.ToString();
                txtSDT.Text= row.Cells[5].Value.ToString();               
            }
            catch (Exception) { }
        }
    }
}
