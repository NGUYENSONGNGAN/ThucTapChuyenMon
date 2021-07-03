using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ThucTapCM.DAO;
using DataTable = System.Data.DataTable;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace ThucTapCM
{
    public partial class ThongTinBaoHanh : Form
    {
        int MaHDBH = HBBanHang.MHDBH;
        public ThongTinBaoHanh()
        {
            InitializeComponent();
            load();
        }
        DateTime newtime;
        void load()
        {
            String selectTKBH = "execute  TKTGBHGV";
            DataTable BH = DataProvider.Instance.ExecuteQuery(selectTKBH);
            gvTKBH.DataSource = BH;
        }
        String maHD;
        string sanpham;
        string cauhinh;
        string mausac;
        private void gvTKBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvTKBH.CurrentRow.Index;
            maHD = gvTKBH.Rows[r].Cells[0].Value.ToString();
            sanpham = gvTKBH.Rows[r].Cells[1].Value.ToString();
            cauhinh = gvTKBH.Rows[r].Cells[2].Value.ToString();
            mausac = gvTKBH.Rows[r].Cells[3].Value.ToString();
        }

        private void btnXCT_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(maHD) <=0)
            {
                MessageBox.Show("Bạn phải chọn thông tin để xóa","Error");
            }
            else if(Convert.ToInt32(maHD) >=1)
            {
                string masp = "select MaSP from SanPham  where TenSp =N'" + Convert.ToString(sanpham.Trim()) + "'";
                DataTable xmasp = DataProvider.Instance.ExecuteQuery(masp);
                Console.WriteLine(xmasp.Rows.Count);
                int ma = Convert.ToInt32(xmasp.Rows[0]["MaSP"].ToString());

                string mach = "select MaCauHinh from SP_CauHinh where TenCauHinh =N'" + Convert.ToString(cauhinh.Trim()) + "'";
                DataTable xmach = DataProvider.Instance.ExecuteQuery(mach);
                int maCH = Convert.ToInt32(xmach.Rows[0]["MaCauHinh"].ToString());

                string mamau = "select MaMau from SP_Mau where TenMau =N'" + Convert.ToString(mausac.Trim()) + "'";
                DataTable xmamau = DataProvider.Instance.ExecuteQuery(mamau);
                int maMau = Convert.ToInt32(xmamau.Rows[0]["MaMau"].ToString());

                DataProvider.Instance.ExecuteNonQuery("delete TKTGBH where MaHDBH = @ma and masp = @masp and mach = @mach and mamau = @mamau ", new object[] { Convert.ToInt32(maHD), Convert.ToInt32(ma.ToString()), Convert.ToInt32(maCH.ToString()), Convert.ToInt32(maMau.ToString()) });
               
                MessageBox.Show("Delete Success !", "Success");
                load();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void txtseach_OnValueChanged(object sender, EventArgs e)
        {
            DataTable seach = DataProvider.Instance.ExecuteQuery("execute  SeachBH @Ten ", new object[] { txtseach.Text });
            gvTKBH.DataSource = seach;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {



            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 4] = "Bảng Thống Thời Gian Bảo Hành Các Sản Phẩm  ";
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã Hóa Đơn";
            worksheet.Cells[3, 3] = "Tên Sản Phẩm";
            worksheet.Cells[3, 4] = "Tên Cấu Hình";
            worksheet.Cells[3, 5] = "Tên Màu";
            worksheet.Cells[3, 6] = "Thời Hạn Bảo hành";

            for (int i = 0; i < gvTKBH.RowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = gvTKBH.Rows[i].Cells[j].Value;
                }
            }
            int dem = gvTKBH.RowCount;


            // Định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Đinh dạng cột
            worksheet.Range["A1"].ColumnWidth = 7;
            worksheet.Range["B1"].ColumnWidth = 25;
            worksheet.Range["C1"].ColumnWidth = 45;
            worksheet.Range["D1"].ColumnWidth = 50;
            worksheet.Range["E1"].ColumnWidth = 30;
            worksheet.Range["F1"].ColumnWidth = 31;



            // Định dạng font chữ
            //     worksheet.Range["A1", "J100"].Font.Name = "";
            worksheet.Range["A1", "A100"].Font.Size = 24;
            worksheet.Range["A3", "J100"].Font.Size = 16;
            worksheet.Range["A1", "F1"].MergeCells = true;
            worksheet.Range["A1", "F1"].Font.Bold = true;

            //worksheet.Range["A3", "J3"].MergeCells = true;
            worksheet.Range["A3", "F3"].Font.Bold = true;

            // kẻ bảng
            worksheet.Range["A3", "F" + (dem + 3)].Borders.LineStyle = 1;


            //Định dạng dòng text
            worksheet.Range["A1", "F1"].HorizontalAlignment = 3;
            worksheet.Range["A3", "F3"].HorizontalAlignment = 3;
            worksheet.Range["A4", "F" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["B4", "F" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["C4", "F" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["D4", "F" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["E4", "F" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["F4", "F" + (dem + 4)].HorizontalAlignment = 3;

        }
    }
}
