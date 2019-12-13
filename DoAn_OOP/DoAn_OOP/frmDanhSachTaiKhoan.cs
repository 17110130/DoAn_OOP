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
    public partial class frmDanhSachTaiKhoan : Form
    {
        public frmDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        public string c1 = "";

        public void Load_dtgvDs()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                dtgvDanhSachTaiKhoan.DataSource = db.TaiKhoans.Select(p => p);
                dtgvDanhSachTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void DanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_dtgvDs();
        }
     
        private void dtgvDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaTaiKhoan.Enabled = true;

            DataGridViewRow row = new DataGridViewRow();
            row = dtgvDanhSachTaiKhoan.Rows[e.RowIndex];
            try
            {
                c1 = row.Cells[0].Value.ToString();             
            }
            catch (Exception) { }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                MessageBox.Show("Bạn có chắc muốn xóa tài khoản này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop); ;


                var t = db.TaiKhoans.Where(p => p.TaiKhoan1.Equals(c1)).SingleOrDefault();

                db.TaiKhoans.DeleteOnSubmit(t);
                db.SubmitChanges();
                Load_dtgvDs();
            }
        }
    }
}
