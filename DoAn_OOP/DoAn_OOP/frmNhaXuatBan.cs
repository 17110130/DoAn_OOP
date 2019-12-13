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
        public frmNhaXuatBan()
        {
            InitializeComponent();         
        }
        QLThuvien1DataContext db = new QLThuvien1DataContext();
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            Load_data_NXB();
            dtgvNhaXB.Columns["IDNhaXuatBan"].HeaderText = "Mã nhà xuất bản";
            dtgvNhaXB.Columns["TenNhaXuatBan"].HeaderText = "Tên nhà xuất bản";
            dtgvNhaXB.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvNhaXB.Columns["SDT"].HeaderText = "Số điện thoại";
            dtgvNhaXB.Columns["IDNhaXuatBan"].Width = 115;
            dtgvNhaXB.Columns["TenNhaXuatBan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvNhaXB.Columns["DiaChi"].Width = 80;
            dtgvNhaXB.Columns["SDT"].Width = 100;

            //if ( frmDangNhap.PQ == "2" )
            //{
            //    btnAddNXB.Enabled = false;
            //    btnDeletenxb.Enabled = false;
            //}
            //else
            //{
            //    if ( frmDangNhap.PQ == "3" )
            //    {
            //        btnAddNXB.Enabled = false;
            //        btnDeletenxb.Enabled = false;
            //        btnClearnxb.Enabled = false;
            //        btnUpdatenxb.Enabled = false;
            //    }
            //}
        }
        public void Load_data_NXB()
        {
            dtgvNhaXB.DataSource = from s in db.NhaXuatBans
                                   select new
                                   {
                                       s.IDNhaXuatBan,
                                       s.TenNhaXuatBan,
                                       s.DiaChi,
                                       s.SDT
                                   };
        }

        private void dtgvNhaXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdatenxb.Enabled = true;
            btnDeletenxb.Enabled = true;
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
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    string n = "";
                    ThamDinh td = new ThamDinh();

                    n += td.kiemTra_Rong("Mã nhà xuất bản", txtMaNXB);
                    n += td.kiemTra_Rong("Tên nhà xuất bản", txtTenNXB);
                    
                    if ( n != "" )
                    {
                        MessageBox.Show(n);
                        return;
                    }

                    var idnxb = txtMaNXB.Text;
                    var t = db.NhaXuatBans.Where(p => p.IDNhaXuatBan.Equals(idnxb)).Select(z => z.IDNhaXuatBan).SingleOrDefault();

                    if ( t == idnxb )
                    {
                        MessageBox.Show("Mã nhà xuất bản đã tồn tại!");
                        txtMaNXB.Text = "";
                        return;
                    }

                    NhaXuatBan nxb = new NhaXuatBan();

                    nxb.IDNhaXuatBan = txtMaNXB.Text;
                    nxb.TenNhaXuatBan = txtTenNXB.Text;
                    nxb.DiaChi = txtDiaChi.Text;
                    nxb.SDT = txtSdt.Text;

                    db.NhaXuatBans.InsertOnSubmit(nxb);
                    db.SubmitChanges();

                    Load_data_NXB();
                    Lam_moi();
                   
                }
                catch (Exception ex) { MessageBox.Show("Không thêm được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public void Lam_moi()
        {
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtTimKiemNXB.Enabled = false;
            btnUpdatenxb.Enabled = false;
            btnDeletenxb.Enabled = false;
        }

        private void btnClearnxb_Click(object sender, EventArgs e)
        {
            Lam_moi();
        }

        private void btnUpdatenxb_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    NhaXuatBan nxb = db.NhaXuatBans.Where(p => p.IDNhaXuatBan.Equals(txtMaNXB.Text)).Single();

                    nxb.TenNhaXuatBan = txtTenNXB.Text;
                    nxb.DiaChi = txtDiaChi.Text;
                    nxb.SDT = txtSdt.Text;

                    db.SubmitChanges();
                    Load_data_NXB();

                    Lam_moi();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeletenxb_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                var ts = db.ThongTinSaches.Where(x => x.NhaXuatBan.Equals(txtMaNXB.Text)).Select(t => t);

                if ( ts.Count() == 0 )
                {
                    try
                    {
                        NhaXuatBan de = db.NhaXuatBans.Where(p => p.IDNhaXuatBan.Equals(txtMaNXB.Text)).SingleOrDefault();

                        db.NhaXuatBans.DeleteOnSubmit(de);
                        db.SubmitChanges();

                        Load_data_NXB();
                        Lam_moi();

                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Không xóa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa vì bảng thông tin sách đang sử dụng nhà xuất bản này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }                     
        }

        private void txtTimKiemNXB_TextChanged(object sender, EventArgs e)
        {
            dtgvNhaXB.DataSource = from s in db.NhaXuatBans
                                   where s.IDNhaXuatBan == txtTimKiemNXB.Text
                                   select new
                                   {
                                       s.IDNhaXuatBan,
                                       s.TenNhaXuatBan,
                                       s.DiaChi,
                                       s.SDT
                                   };

        }
    }
}
