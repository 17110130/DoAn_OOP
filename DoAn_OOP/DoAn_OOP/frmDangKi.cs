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
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
            ptcHinhNenDangKi.Image = Image.FromFile(@"C:\Users\Admin\Desktop\DoAn_OOP\DoAn_OOP\anh.gif");
        }

        public string mhmk = "";
        public string mhnlmk = "";

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "")
            {
                MaHoaSHA1 mh = new MaHoaSHA1();

                mhmk = mh.EncodeSHA1(txtMatKhau.Text);
            }
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.Text != "")
            {
                MaHoaSHA1 mh = new MaHoaSHA1();

                mhnlmk = mh.EncodeSHA1(txtNhapLaiMatKhau.Text);
            }
        }

        private void Lam_Moi()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtNhapLaiMatKhau.Text = "";
            radPQ1.Checked = false;
            radPQ2.Checked = false;
            radPQ3.Checked = false;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                ThamDinh td = new ThamDinh();
                string n = "";
                n += td.kiemTra_Rong("Tên tài khoản", txtTenTaiKhoan);
                n += td.kiemTra_Rong("Mật khẩu", txtMatKhau);
                n += td.kiemTra_Rong("Nhập lại mật khẩu", txtNhapLaiMatKhau);
                n += td.Check_PhanQuyen(radPQ1, radPQ2, radPQ3);

                if ( n != "" )
                {
                    MessageBox.Show(n);
                    return;
                }

                var x = db.TaiKhoans.Where(z => z.TaiKhoan1.Equals(txtTenTaiKhoan.Text)).SingleOrDefault();

                if ( x != null )
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                    return;
                }

                if ( mhmk != mhnlmk )
                {
                    MessageBox.Show("Mật khẩu nhập lại khác với mật khẩu đã nhập!");
                    txtNhapLaiMatKhau.Text = "";
                    return;
                }

                TaiKhoan tk = new TaiKhoan();

                tk.TaiKhoan1 = txtTenTaiKhoan.Text;
                tk.MatKhau = mhmk;
                string p = "";
                if ( radPQ1.Checked == true )
                {
                    p = "1";
                }
                else
                {
                    if (radPQ2.Checked == true)
                        p = "2";
                    else p = "3";
                }

                tk.PhanQuyen = p;

                db.TaiKhoans.InsertOnSubmit(tk);
                db.SubmitChanges();
                MessageBox.Show("Tài khoản đã được tạo");
                Lam_Moi();
            }
        }

        
    }
}
