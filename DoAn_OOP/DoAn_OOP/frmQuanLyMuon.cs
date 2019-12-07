using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn_OOP
{
    public partial class frmQuanLyMuon : Form
    {
        public frmQuanLyMuon()
        {
            InitializeComponent();
        }

        private void frmQuanLyMuon_Load(object sender, EventArgs e)
        {
            Load_MaDG();      
            Load_dtgvTimKiemSach();
            Load_dtgvTimKiemTheLoai();
            //Load_dtgvSachDaChon();
            dtpNgayMuonSach.Value = DateTime.Now;          
            dtpHanTraSach.Value = dtpNgayMuonSach.Value.AddDays(10);
        }

        public void Load_dtgvTimKiemSach()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                dtgvSachTimKiem.DataSource = from s in db.ThongTinSaches
                                             select new
                                             {
                                                 MaTheLoai = s.IDTheLoai,
                                                 MaSach = s.IDSach,
                                                 TenSach = s.TenSach,
                                                 Gia = s.Gia
                                             };
            }
        }

        public void Load_dtgvSachDaChon()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {            
                    dtgvSachDaChon.DataSource = from s in db.PhieuMuons
                                                from t in db.ThongTinSaches
                                                where s.IDSach == t.IDSach && s.IDDocGia == cbMaDG.Text
                                                select new
                                                {
                                                    MaSach = s.IDSach,
                                                    TenSach = t.TenSach,
                                                    SoLuong = s.SoLuong,
                                                    
                                                };
               
            }
        }

        public void Load_MaDG()
        {
            using ( QLThuvien1DataContext db = new QLThuvien1DataContext() )
            {
                cbMaDG.DataSource = db.DocGias.ToList();
                cbMaDG.DisplayMember = "IDDocGia";
                cbMaDG.SelectedIndex = -1;
            }
        }

        public void Load_dtgvTimKiemTheLoai()
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                dtgvTheLoaiTimKiem.DataSource = from s in db.TheLoais
                                                from t in db.ThongTinSaches
                                                where s.IDTheLoai == t.IDTheLoai
                                                select new
                                                {
                                                    MaTheLoai = s.IDTheLoai,
                                                    TenTheLoai = s.TenTheLoai,
                                                    MaSach = t.IDSach,
                                                    TenSach = t.TenSach
                                                };
            }
        }

        //public void CapNhat_TongTien()
        //{
        //    using (QLThuvien1DataContext db = new QLThuvien1DataContext())
        //    {
        //        double tongtien = 0;
        //        var total = db.PhieuMuons.Select(p => p.TongTien).ToArray();

        //        foreach(var c in total )
        //        {
        //            tongtien += double.Parse(c);
        //        }
        //    }
        //}

        private void txtTimKiemTheLoai_TextChanged(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext() )
            {
                if (txtTimKiemTheLoai.Text != "")
                {
                    dtgvTheLoaiTimKiem.DataSource = from s in db.TheLoais
                                                    from t in db.ThongTinSaches
                                                    where s.IDTheLoai == txtTimKiemTheLoai.Text && s.IDTheLoai == t.IDTheLoai
                                                    select new
                                                    {
                                                        MaTheLoai = s.IDTheLoai,
                                                        TenTheLoai = s.TenTheLoai,
                                                        MaSach = t.IDSach,
                                                        TenSach = t.TenSach
                                                    };
                }
                else
                {
                    Load_dtgvTimKiemTheLoai();
                }              
            }
        }

        

        private void txtTimKiemSach_TextChanged(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                if ( txtTimKiemSach.Text != "" )
                {
                    dtgvSachTimKiem.DataSource = from s in db.ThongTinSaches
                                                 where s.IDSach == txtTimKiemSach.Text
                                                 select new
                                                 {
                                                     MaTheLoai = s.IDTheLoai,
                                                     MaSach = s.IDSach,
                                                     TenSach = s.TenSach, 
                                                     Gia=s.Gia
                                                 };
                }
                else
                {
                    Load_dtgvTimKiemSach();
                }
            }
        }

        private void cbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_dtgvSachDaChon();
        }

        private void dtpHanTraSach_ValueChanged(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                ThamDinh td = new ThamDinh();
                string n = td.kiemtra_dtp("Hạn trả sách", dtpHanTraSach);

                if (n != "")
                {
                    MessageBox.Show(n);
                    return;
                }

                //var s = db.PhieuMuons.Where(p => p.IDDocGia.Equals(cbMaDG.Text)).FirstOrDefault();

                //s.NgayTra = dtpHanTraSach.Value;

                //db.SubmitChanges();
            }       
        }

        private void btnChon_Click(object sender, EventArgs e)
        {          
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                ThamDinh td = new ThamDinh();
                string n = td.kiemTraComboBox("Mã Độc Giả", cbMaDG);
                if ( n != "" )
                {
                    MessageBox.Show(n);
                    return;
                }
                else
                {
                    string mtl = dtgvSachTimKiem.SelectedCells[0].OwningRow.Cells["MaTheLoai"].Value.ToString();
                    string ms = dtgvSachTimKiem.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();
                    string tensach = dtgvSachTimKiem.SelectedCells[0].OwningRow.Cells["TenSach"].Value.ToString();
                    string idDocGia = cbMaDG.Text;

                    var x = (from s in db.PhieuMuons
                                  where s.IDDocGia == cbMaDG.Text && s.IDSach == ms
                                  select s).SingleOrDefault();                   

                    if ( x == null )
                    {
                        PhieuMuon p = new PhieuMuon();
                        p.IDDocGia = cbMaDG.Text;
                        p.IDSach = ms;
                        p.NgayMuon = DateTime.Now;
                        p.NgayTra = dtpHanTraSach.Value;
                        p.SoLuong = 1;

                        db.PhieuMuons.InsertOnSubmit(p);
                        db.SubmitChanges();
                    }
                    else
                    {
                        PhieuMuon add = db.PhieuMuons.Where(p => p.IDSach.Equals(ms)).SingleOrDefault();
                        add.SoLuong = add.SoLuong + 1;                     

                        db.SubmitChanges();
                    }
                    Load_dtgvSachDaChon();                  

                }
                

                
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                string ms = dtgvSachDaChon.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();

                //PhieuMuon delete = db.PhieuMuons.Where(p => p.IDSach.Equals(ms)).SingleOrDefault();
                var delete = (from s in db.PhieuMuons
                            where s.IDDocGia == cbMaDG.Text && s.IDSach == ms
                            select s).Single();
                delete.SoLuong--;
                

                if ( delete.SoLuong == 0 )
                    db.PhieuMuons.DeleteOnSubmit(delete);               

                db.SubmitChanges();
                Load_dtgvSachDaChon();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            //FileStream fw = null;
            //string msg = "";
            //byte[] msgByte = null;

            //fw = new FileStream("Bill.txt", FileMode.Create);

            //msgByte = Encoding.Default.GetBytes(msg);
            //fw.Write(msgByte, 0, msgByte.Length);
            //msg = "";

            //msg += "Mã độc giả: "+ cbMaDG.Text + "\r\n" + "Ngày mượn: " +  dtpNgayMuonSach.Value 
            //    + "\r\n" + "Hạn trả: "+ lblTotalBill.Text + "\r\n";

            //msgByte = Encoding.Default.GetBytes(msg);
            //fw.Write(msgByte, 0, msgByte.Length);

            //if (fw != null) fw.Close();

            //MessageBox.Show("The file Bill.txt have created!");
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

   
    }
}
