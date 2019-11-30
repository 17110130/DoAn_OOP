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
    public partial class frmQuanLyTra : Form
    {
        public frmQuanLyTra()
        {
            InitializeComponent();
        }

        //public void Load_cbMaPM()
        //{
        //    using (QLThuvien1DataContext db = new QLThuvien1DataContext())
        //    {
        //        cbMaPM.DataSource = db.PhieuMuons.ToList();
        //        cbMaPM.DisplayMember = "IDPhieuMuon";
        //        cbMaPM.SelectedIndex = -1;
        //    }
        //}

        //public void Load_MaDG()
        //{
        //    using (QLThuvien1DataContext db = new QLThuvien1DataContext())
        //    {
        //        var cbb = this.cbMaPM.GetItemText(this.cbMaPM.SelectedItem);
        //        lblMaDG.Text = db.PhieuMuons.Where(p => p.IDPhieuMuon.Equals(cbb)).Select(t => t.IDDocGia).FirstOrDefault();
        //    }
        //}
    }
}
