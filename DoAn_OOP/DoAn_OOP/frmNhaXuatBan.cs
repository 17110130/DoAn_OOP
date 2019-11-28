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
            dtgvNhaXB.Columns["IDNhaXuatBan"].HeaderText = "Mã nhà xuất bản";
            dtgvNhaXB.Columns["TenNhaXuatBan"].HeaderText = "Tên nhà xuất bản";
            dtgvNhaXB.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvNhaXB.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvNhaXB.Columns["IDNhaXuatBan"].Width = 115;
            dtgvNhaXB.Columns["TenNhaXuatBan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvNhaXB.Columns["DiaChi"].Width = 80;
            dtgvNhaXB.Columns["SoDienThoai"].Width = 100;
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
            catch (Exception ex) { MessageBox.Show("Không thêm được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnClearnxb_Click(object sender, EventArgs e)
        {
            this.txtMaNXB.Clear();
            this.txtTenNXB.Clear();
            this.txtDiaChi.Clear();
            this.txtSdt.Clear();
        }

        private void btnUpdatenxb_Click(object sender, EventArgs e)
        {
            QLThuvien1DataContext db = new QLThuvien1DataContext();
            NhaXuatBan nxb = new NhaXuatBan();
            try
            {
                nxb = db.NhaXuatBans.Where(s => s.IDNhaXuatBan == txtMaNXB.Text).Single();
                nxb.TenNhaXuatBan = txtTenNXB.Text;
                nxb.DiaChi = txtDiaChi.Text;
                nxb.SoDienThoai = txtSdt.Text;
                db.SubmitChanges();
                Load_data_NXB();
            }
            catch(Exception)
            {
                MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeletenxb_Click(object sender, EventArgs e)
        {
            QLThuvien1DataContext db = new QLThuvien1DataContext();
            NhaXuatBan nxb = new NhaXuatBan();
            var id = from s in db.ThongTinSaches where (s.NhaXuatBan == txtMaNXB.Text) select s;
            var dem = id.Count();
            if (dem==0)
            {
                try
                {
                    nxb = db.NhaXuatBans.Where(s => s.IDNhaXuatBan == txtMaNXB.Text).Single();
                    nxb.TenNhaXuatBan = txtTenNXB.Text;
                    nxb.DiaChi = txtDiaChi.Text;
                    nxb.SoDienThoai = txtSdt.Text;
                    db.NhaXuatBans.DeleteOnSubmit(nxb);
                    db.SubmitChanges();
                    Load_data_NXB();
                    this.txtMaNXB.Clear();
                    this.txtTenNXB.Clear();
                    this.txtDiaChi.Clear();
                    this.txtSdt.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không xóa được vì mã nhà xuất bản còn sài bên bảng thông tin sách!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var list = (from s in db.NhaXuatBans where s.TenNhaXuatBan.Contains(txtTenNXB.Text) select s).ToList();
            dtgvNhaXB.DataSource = list;
        }
    }
}
