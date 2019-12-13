using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_OOP
{
    public partial class frmDangNhap : Form
    {
        public static string PQ;

        public frmDangNhap()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile(@"C: \Users\Admin\Desktop\DoAn_OOP\DoAn_OOP\anh4.gif");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                var l = (from t in db.TaiKhoans
                         where t.TaiKhoan1 == txtTaiKhoan.Text && t.MatKhau == txtMatKhau.Text
                         select t).FirstOrDefault();
               
                if ( l == null )
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {               
                    PQ = db.TaiKhoans.Where(p => p.TaiKhoan1.Equals(txtTaiKhoan.Text)).Select(z => z.PhanQuyen).SingleOrDefault();

                    var x = EncodeSHA1(txtMatKhau.Text);

                    MessageBox.Show("Bạn đang đăng nhập với tài khoản " + txtTaiKhoan.Text + " và mật khẩu được mã hóa SHA là: " + x);
                    frmFormMain main = new frmFormMain();
                    main.ShowDialog();
                    this.Close();
                }
            }
        }

        private string EncodeSHA1(string pass)

        {

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);

            bs = sha1.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)

            {

                s.Append(b.ToString("x1").ToLower());

            }

            pass = s.ToString();

            return pass;

        }
    }
}
