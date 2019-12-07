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
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace DoAn_OOP
{
    public partial class frmKhoSach : Form
    {
        public frmKhoSach()//string idsach)
        {
            InitializeComponent();
           // this.idsach = idsach;            
        }
        QLThuvien1DataContext db = new QLThuvien1DataContext();
       // private string idsach;
        
        private void frmKhoSach_Load(object sender, EventArgs e)
        {
            Load_datasach();
            Load_cbbtheloai();
            Load_cbbnhaxb();

        }
        public void Load_datasach()
        {
            dtgvKhoSach.DataSource = from s in db.ThongTinSaches select new { s.IDSach, s.IDTheLoai, s.TenSach,s.NhaXuatBan,s.NgayNhapKho,s.Gia,s.TonKho};
        }
        public void Load_cbbtheloai()
        {
            cbbTheLoai.DataSource = db.TheLoais.ToList();
            cbbTheLoai.DisplayMember = "TenTheLoai";
           // cbbTheLoai.ValueMember = "IDTheLoai";
            cbbTheLoai.SelectedIndex = -1;
        }
        public void Load_cbbnhaxb()
        {
            cbbNhaXuatBan.DataSource = db.NhaXuatBans.ToList();            
            cbbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            //cbbNhaXuatBan.ValueMember= "IDNhaXuatBan";
            cbbNhaXuatBan.SelectedIndex = -1;
        }

        private void dtgvKhoSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoaThongTin.Enabled = true;

            DataGridViewRow row = new DataGridViewRow();
            row = dtgvKhoSach.Rows[e.RowIndex];
            try
            {
                cbbTheLoai.Text = row.Cells[1].Value.ToString();
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[2].Value.ToString();
                cbbNhaXuatBan.Text = row.Cells[3].Value.ToString();
                dtpNgayNhapKho.Text = row.Cells[4].Value.ToString();
                txtGiaSach.Text = row.Cells[5].Value.ToString();
                txtTonKho.Text = row.Cells[6].Value.ToString();

            }
            catch (Exception) { }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Lam_moi();
        }

        public void Lam_moi()
        {
            this.cbbTheLoai.Text = "";
            this.txtMaSach.Text = "";
            this.txtTenSach.Text = "";
            this.cbbNhaXuatBan.Text = "";
            this.dtpNgayNhapKho.Text = "";
            this.txtGiaSach.Text = "";
            this.txtTonKho.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                try
                {
                    ThongTinSach sach = new ThongTinSach();

                    var idtl = db.TheLoais.Where(p => p.TenTheLoai.Equals(cbbTheLoai.Text)).Select(x => x.IDTheLoai).Single();
                    var idnxb = db.NhaXuatBans.Where(p => p.TenNhaXuatBan.Equals(cbbNhaXuatBan.Text)).Select(x => x.IDNhaXuatBan).Single();

                    sach.IDTheLoai = idtl;
                    sach.IDSach = txtMaSach.Text;
                    sach.TenSach = txtTenSach.Text;
                    sach.NhaXuatBan = idnxb;
                    sach.NgayNhapKho = dtpNgayNhapKho.Value;
                    sach.Gia = txtGiaSach.Text;
                    sach.TonKho = int.Parse(txtTonKho.Text);

                    db.ThongTinSaches.InsertOnSubmit(sach);
                    db.SubmitChanges();

                    Load_datasach();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thêm được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }             
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QLThuvien1DataContext db = new QLThuvien1DataContext();
            ThongTinSach sach = new ThongTinSach();
            try
            {
                sach = db.ThongTinSaches.Where(s => s.IDSach == txtMaSach.Text).Single();
                sach.IDTheLoai = cbbTheLoai.Text;
                sach.TenSach = txtTenSach.Text;
                sach.NhaXuatBan = cbbNhaXuatBan.Text;
                sach.NgayNhapKho = dtpNgayNhapKho.Value;
                sach.Gia = txtGiaSach.Text;
                sach.TonKho = int.Parse(txtTonKho.Text);

                db.SubmitChanges();
                Load_datasach();
                Lam_moi();
            }
            catch(Exception)
            {
                MessageBox.Show("Không sửa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }           

        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            using (QLThuvien1DataContext db = new QLThuvien1DataContext())
            {
                ThongTinSach sach = new ThongTinSach();
                try
                {
                    sach = db.ThongTinSaches.Where(s => s.IDSach == txtMaSach.Text).Single();
                    //sach.IDTheLoai = cbbTheLoai.Text;
                    //sach.TenSach = txtTenSach.Text;
                    //sach.NhaXuatBan = cbbNhaXuatBan.Text;
                    //sach.NgayNhapKho = dtpNgayNhapKho.Value;
                    //sach.Gia = txtGiaSach.Text;
                    //sach.TonKho = int.Parse(txtTonKho.Text);

                    db.ThongTinSaches.DeleteOnSubmit(sach);
                    db.SubmitChanges();

                    Load_datasach();
                    Lam_moi();
                }
                catch (Exception) { MessageBox.Show("Không xóa được!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            //string filePath = "";
            //// tạo SaveFileDialog để lưu file excel
            //SaveFileDialog dialog = new SaveFileDialog();

            //// chỉ lọc ra các file có định dạng Excel
            //dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            //// Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            //dialog.ShowDialog();

            //filePath = dialog.FileName;


            //// nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            //if (string.IsNullOrEmpty(filePath))
            //{
            //    MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
            //    return;
            //}

            //try
            //{
            //    using (ExcelPackage p = new ExcelPackage())
            //    {
            //        // đặt tên người tạo file
            //        p.Workbook.Properties.Author = "Phần mềm quản lý thư viện";

            //        // đặt tiêu đề cho file
            //        p.Workbook.Properties.Title = "Thống kê kho sách";

            //        //Tạo một sheet để làm việc trên đó
            //        p.Workbook.Worksheets.Add("Quản lý kho sách");

            //        // lấy sheet vừa add ra để thao tác
            //        ExcelWorksheet ws = p.Workbook.Worksheets[1];

            //        // đặt tên cho sheet
            //        ws.Name = "Quản lý kho sách";
            //        // fontsize mặc định cho cả sheet
            //        ws.Cells.Style.Font.Size = 14;
            //        // font family mặc định cho cả sheet
            //        ws.Cells.Style.Font.Name = "Calibri";

            //        // Tạo danh sách các column header
            //        string[] arrColumnHeader = {
            //                                    "IDTheLoai",
            //                                    "IDSach",
            //                                    "TenSach",
            //                                    "NhaXuatBan",
            //                                    "NgayNhapKho",
            //                                    "Gia",
            //                                    "TonKho",
                                               
            //    };

            //        // lấy ra số lượng cột cần dùng dựa vào số lượng header
            //        var countColHeader = arrColumnHeader.Count();

            //        // merge các column lại từ column 1 đến số column header
            //        // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
            //        ws.Cells[1, 1].Value = "QUẢN LÝ KHO SÁCH";
            //        ws.Cells[1, 1, 1, countColHeader].Merge = true;
            //        // in đậm
            //        ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
            //        // font size
            //        ws.Cells[1, 1, 1, countColHeader].Style.Font.Size = 25;
            //        // căn giữa
            //        ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            //        int colIndex = 1;
            //        int rowIndex = 2;

            //        //tạo các header từ column header đã tạo từ bên trên
            //        ws.Column(1).Width = 30;
            //        ws.Column(2).Width = 30;
            //        ws.Column(3).Width = 15;
            //        ws.Column(4).Width = 15;
            //        ws.Column(5).Width = 15;
            //        ws.Column(6).Width = 15;
            //        ws.Column(7).Width = 15;
            //        ws.Column(8).Width = 15;
            //        ws.Column(9).Width = 30;
            //        ws.Column(10).Width = 40;

            //        foreach (var item in arrColumnHeader)
            //        {
            //            var cell = ws.Cells[rowIndex, colIndex];
            //            var fill = cell.Style.Fill;
            //            fill.PatternType = ExcelFillStyle.Solid;
            //            fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);


            //            //căn chỉnh các border
            //            var border = cell.Style.Border;
            //            border.Bottom.Style =
            //                border.Top.Style =
            //                border.Left.Style =
            //                border.Right.Style = ExcelBorderStyle.Thin;
            //            cell.Value = item;
            //            colIndex++;
            //        }
                    
                  
            //        //Lưu file lại
            //        Byte[] bin = p.GetAsByteArray();
            //        File.WriteAllBytes(filePath, bin);
            //    }
            //    MessageBox.Show("Xuất file excel thành công!");
            //}
            //catch (Exception EE)
            //{
            //    MessageBox.Show("Có lỗi khi lưu file!");
            //}
        }
    }
}
