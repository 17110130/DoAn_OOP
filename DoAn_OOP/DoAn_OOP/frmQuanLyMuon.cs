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
    public partial class frmQuanLyMuon : Form
    {
        public frmQuanLyMuon()
        {
            InitializeComponent();
        }

        private void frmQuanLyMuon_Load(object sender, EventArgs e)
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

        private void txtTimKiemTheLoai_TextChanged(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                if (txtTimKiemTheLoai.Text != "" )
                    dtgvTheLoaiTimKiem.DataSource = db.TheLoais.Where(p => p.IDTheloai.Equals(txtTimKiemTheLoai.Text));
            }
        }

        private void txtTimKiemSach_TextChanged(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                if ( txtTimKiemSach.Text != "" )
                {
                    dtgvSachTimKiem.DataSource = from s in db.ThongTinSaches
                                                 where s.IDSach == txtTimKiemSach.Text
                                                 select new
                                                 {
                                                     MaSach = s.IDSach,
                                                     TenSach = s.TenSach,
                                                     TacGia = s.TacGia
                                                 };

                }
            }
        }
    }
}
