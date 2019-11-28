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
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan(string idnxb)
        {
            InitializeComponent();
            this.idnxb = idnxb;
        }
        private string idnxb;
        QLThuvien1DataContext db = new QLThuvien1DataContext();
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            Load_data_NXB();
        }
        public void Load_data_NXB()
        {
            dtgvNhaXB.DataSource = from s in db.NhaXuatBans
                                   select new
                                   {
                                       s.IDNhaXuatBan,
                                       s.TenNhaXuatBan,
                                       s.DiaChi,
                                       s.SoDienThoai
                                   };
        }

        private void dtgvNhaXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvNhaXB.Rows[e.RowIndex];
                txtMaNXB.Text = row.Cells[0].Value.ToString();
                txtTenNXB.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSdt.Text = row.Cells[3].Value.ToString();

            }
            catch (Exception) { }
           
        }

        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            var id = db.NhaXuatBans.Count();
            id++;
            var mh = "NXB";
            if (id < 10) mh = mh + "000" + id;
            else if (id < 100) mh = mh + "00" + id;
            else if (id < 1000) mh = mh + "0" + id;
            else mh = (mh + id).ToString();
            var idnxb = txtMaNXB.Text.Substring(0, 0).ToUpper() + mh;
            NhaXuatBan nxb = new NhaXuatBan();
            
            try
            {
                nxb.IDNhaXuatBan =idnxb;
                nxb.TenNhaXuatBan = txtTenNXB.Text;
                nxb.DiaChi = txtDiaChi.Text;
                nxb.SoDienThoai = txtSdt.Text;
                db.NhaXuatBans.InsertOnSubmit(nxb);
                db.SubmitChanges();
                Load_data_NXB();
            }
            catch (Exception ex) { MessageBox.Show("lỗi");throw ex; }

        }
    }
}
