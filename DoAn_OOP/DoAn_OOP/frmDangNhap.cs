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

            //Tạo tài khoản lần đầu
            //using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            //{
            //    TaiKhoan t = new TaiKhoan();
            //    MaHoaSHA1 m = new MaHoaSHA1();

            //    t.TaiKhoan1 = "admin";
            //    t.MatKhau = m.EncodeSHA1("123");
            //    t.PhanQuyen = "1";

            //    db.TaiKhoans.InsertOnSubmit(t);
            //    db.SubmitChanges();
            //}
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {           
                using (QLThuvien1DataContext db = new QLThuvien1DataContext())
                {
                    MaHoaSHA1 mh1 = new MaHoaSHA1();
                    var l = (from t in db.TaiKhoans
                                where t.TaiKhoan1 == txtTaiKhoan.Text && t.MatKhau == mh1.EncodeSHA1(txtMatKhau.Text)
                                select t).FirstOrDefault();

                    if (l == null)
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        PQ = db.TaiKhoans.Where(p => p.TaiKhoan1.Equals(txtTaiKhoan.Text)).Select(z => z.PhanQuyen).SingleOrDefault();

                        MaHoaSHA1 mh = new MaHoaSHA1();
                        var x = mh.EncodeSHA1(txtMatKhau.Text);

                        MessageBox.Show("Bạn đang đăng nhập với tài khoản " + txtTaiKhoan.Text + " và mật khẩu được mã hóa SHA là: " + x);
                        frmFormMain main = new frmFormMain();
                        main.ShowDialog();
                        this.Close();
                    }
                }          
        }
    }
}
