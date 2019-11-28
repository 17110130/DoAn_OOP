using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_OOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // tường chạy đi lần đầu nhập đúng hết dữ liệu
            //Xong sao nữa thắng
            // kiểu là nếu t nhập đúng dữ liệu là nó cho làm mọi thứ nhưng lỡ may t thêm lỗi cái là nó lỗi các chức năng khác luôn
            //Thắng chạy demo tui coi di
            //Xung đột cái id thôi mà
            //là nó xung đột chỗ nào tường chứ t thấy id bth mà
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmNhaXuatBan(null));
        }
    }
}
