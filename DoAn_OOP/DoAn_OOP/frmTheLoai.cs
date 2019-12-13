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
    public partial class frmTheLoai : Form
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            Load_data();

            if ( frmDangNhap.PQ == "2" )
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if ( frmDangNhap.PQ == "3" )
                {
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnLamMoi.Enabled = false;
                    btnSua.Enabled = false;
                }
            }
        }

        public void Load_data()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {              
                dtgvTheLoai.DataSource = from s in db.TheLoais
                                         select new
                                         {
                                             MaTheLoai = s.IDTheLoai,
                                             TenTheLoai = s.TenTheLoai
                                         };
            }
        }

        private void dtgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmDangNhap.PQ == "1")          
                btnXoa.Enabled = true;
           
            if ( frmDangNhap.PQ != "3" )
                btnSua.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvTheLoai.Rows[e.RowIndex];
                txtMaTL.Text = row.Cells[0].Value.ToString();
                txtTenTL.Text = row.Cells[1].Value.ToString();               
            }
            catch (Exception) { }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Lam_moi();
        }

        public void Lam_moi()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtTImKiem.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    string n = "";
                    ThamDinh td = new ThamDinh();
                    n += td.kiemTra_Rong("Mã thể loại", txtMaTL);
                    n += td.kiemTra_Rong("Tên thể loại", txtTenTL);

                    if ( n != "" )
                    {
                        MessageBox.Show(n);
                        return;
                    }

                    var t = db.TheLoais.Where(p => p.IDTheLoai.Equals(txtMaTL.Text)).Select(z => z.IDTheLoai).SingleOrDefault();

                    if ( t == txtMaTL.Text )
                    {
                        MessageBox.Show("Mã thể loại đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaTL.Text = "";
                        return;
                    }

                    TheLoai tl = new TheLoai();

                    tl.IDTheLoai = txtMaTL.Text;
                    tl.TenTheLoai = txtTenTL.Text;

                    db.TheLoais.InsertOnSubmit(tl);
                    db.SubmitChanges();

                    Load_data();
                    Lam_moi();
                }
                catch(Exception)
                {
                    MessageBox.Show("Không thêm được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    var t = db.TheLoais.Where(p => p.IDTheLoai.Equals(txtMaTL.Text)).Single();

                    t.TenTheLoai = txtTenTL.Text;

                    db.SubmitChanges();
                    Load_data();
                    Lam_moi();
                }
                catch(Exception)
                {
                    MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                var tl = db.ThongTinSaches.Where(x => x.NhaXuatBan.Equals(txtMaTL.Text)).Select(t => t);

                if (tl.Count() == 0)
                {
                    try
                    {
                        TheLoai de = db.TheLoais.Where(p => p.IDTheLoai.Equals(txtMaTL.Text)).SingleOrDefault();

                        db.TheLoais.DeleteOnSubmit(de);
                        db.SubmitChanges();

                        Load_data();
                        Lam_moi();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không xóa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa vì trong thể loại này còn chứa sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTImKiem_TextChanged(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                if (txtTImKiem.Text == "")
                {
                    Load_data();
                }
                else
                {
                    dtgvTheLoai.DataSource = from s in db.TheLoais
                                             where s.IDTheLoai==txtTImKiem.Text
                                             select new
                                             {
                                                 MaTheLoai = s.IDTheLoai,
                                                 TenTheLoai = s.TenTheLoai
                                             };
                }
            }
               
        }
    }
}
