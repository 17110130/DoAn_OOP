using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_OOP
{
    public class ThamDinh
    {
        public string kiemTra_Rong(string s, TextBox txt)
        {
            if (txt.Text == "")
                return s + " Không được để trống!\n";
            return "";
        }
    }
}
