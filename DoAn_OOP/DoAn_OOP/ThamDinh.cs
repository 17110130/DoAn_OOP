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
        public string kiemTraComboBox(string name, ComboBox cbo)
        {
            if (cbo.SelectedIndex == -1)
            {
                return "Hãy chọn " + name + "\n";
            }
            return "";
        }

        public string kiemTra_Rong(string s, TextBox txt)
        {
            if (txt.Text == "")
                return s + " Không được để trống!\n";
            return "";
        }

        public string kiemtra_dtp(string s, DateTimePicker dtp)
        {
            int nam = dtp.Value.Year;
            int thang = dtp.Value.Month;
            int ngay = dtp.Value.Day;

            if ( nam < DateTime.Now.Year )
            {
                return s + " không thể chọn nhỏ hơn ngày tháng năm hiện tại\n";            
            }
            else
            {
                if (nam == DateTime.Now.Year)
                {
                    if (thang < DateTime.Now.Month)
                        return s + " không thể chọn nhỏ hơn ngày tháng năm hiện tại\n";
                    else
                        if ( thang == DateTime.Now.Month )
                            if ( ngay < DateTime.Now.Day )
                                return s + " không thể chọn nhỏ hơn ngày tháng năm hiện tại\n";                        
                }                         
            }
            return "";
        }

        public string Check_radio(RadioButton rad1, RadioButton rad2)
        {
            if (rad1.Checked == false && rad2.Checked == false)
                return "Hãy chọn giới tính!\n";
            return "";
        }

        public string Check_PhanQuyen(RadioButton r1,RadioButton r2,RadioButton r3)
        {
            if (r1.Checked == false && r2.Checked == false && r3.Checked == false)
                return "Hãy chọn phân quyền!\n";
            return "";
        }
    }
}
