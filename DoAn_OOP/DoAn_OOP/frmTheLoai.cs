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
        QLThuvien1DataContext db = new QLThuvien1DataContext();
        
        public frmTheLoai(string idtl)
        {
            InitializeComponent();
            this.idtl = idtl;
        }
        private string idtl;
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            Load_datatl();
            dtgvTheLoai.Columns["IDTheLoai"].HeaderText="Mã thể loại";
            dtgvTheLoai.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
            dtgvTheLoai.Columns["IDTheLoai"].Width = 100;
            dtgvTheLoai.Columns["TenTheLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void Load_datatl()
        {
            dtgvTheLoai.DataSource = from s in db.TheLoais select new { s.IDTheloai, s.TenTheLoai };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtTenTL.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            QLThuvien1DataContext db = new QLThuvien1DataContext();
            TheLoai tl = new TheLoai();
            var id = db.TheLoais.Count();
            id++;
            var mh = "TL";
            if (id < 10) mh = mh + "000" + id;
            else if (id < 100) mh = mh + "00" + id;
            else if (id < 1000) mh = mh + "0" + id;
            else mh = (mh + id).ToString();
            var idtl = txtID.Text.Substring(0, 0).ToUpper() + mh;
            try
            {
                tl.IDTheloai = idtl;
                tl.TenTheLoai = txtTenTL.Text;
                db.TheLoais.InsertOnSubmit(tl);
                db.SubmitChanges();
                Load_datatl();
            }
            catch(Exception)
            {
                MessageBox.Show("Không thêm được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QLThuvien1DataContext db = new QLThuvien1DataContext();
            TheLoai tl = new TheLoai();
            try
            {
                tl = db.TheLoais.Where(s => s.IDTheloai == txtID.Text).Single();
                tl.TenTheLoai = txtTenTL.Text;
                db.SubmitChanges();
                Load_datatl();
            }
            catch(Exception)
            {
                MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QLThuvien1DataContext db = new QLThuvien1DataContext();
            TheLoai tl = new TheLoai();
            ThongTinSach sach = new ThongTinSach();
            var id = from t in db.ThongTinSaches where(t.IDSach==txtID.Text)  select t.IDSach;
            var dem=id.Count();
            if(dem==0)
            {
                try
                {
                    tl = db.TheLoais.Where(s => s.IDTheloai == txtID.Text).Single();
                    tl.TenTheLoai = txtTenTL.Text;
                    db.TheLoais.DeleteOnSubmit(tl);
                    db.SubmitChanges();
                    Load_datatl();
                    this.txtID.Clear();
                    this.txtTenTL.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không xóa được vì thể loại này vẫn được sử bên thông tin sách!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void dtgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvTheLoai.Rows[e.RowIndex];
            try
            {
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenTL.Text = row.Cells[1].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Không load được dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            var list = (from s in db.TheLoais where s.TenTheLoai.Contains(txtTimkiem.Text) select s).ToList();
            dtgvTheLoai.DataSource = list;
        }
    }
}
