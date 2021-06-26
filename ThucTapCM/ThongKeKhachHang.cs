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
    public partial class ThongKeKhachHang : Form
    {
        public ThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void ThongKeKhachHang_Load(object sender, EventArgs e)
        {
            
            string query = "execute TKKH";
            DataTable tkkh = DataProvider.Instance.ExecuteQuery(query);
            gvTKKH.DataSource = tkkh;

            string query1 = "Select * from LoaiKH";
            DataTable SP = DataProvider.Instance.ExecuteQuery(query1);

            cbxLoaikhachhang.DisplayMember = "TenLKH";
            cbxLoaikhachhang.ValueMember = "MaLKH";
            cbxLoaikhachhang.DataSource = SP;
            //cbxLoaikhachhang.SelectedValue = 1;


        }

        private void cbxLoaikhachhang_SelectedValueChanged(object sender, EventArgs e)
        {
            string demkh = "execute demsokh @ma ";
            DataTable sokhachhang = DataProvider.Instance.ExecuteQuery(demkh, new object[] { Convert.ToInt32(cbxLoaikhachhang.SelectedValue) });
            lbsoluong.Text = Convert.ToString(sokhachhang.Rows.Count);
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
            worksheet.Cells[1, 4] = "Bảng Thống Kê Khách Hàng Đã Mua Gì ";
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã Hóa Đơn";
            worksheet.Cells[3, 3] = "Khách Hàng";
            worksheet.Cells[3, 4] = "Sản Phẩm";
            worksheet.Cells[3, 5] = "Màu";
            worksheet.Cells[3, 6] = "Size";
            worksheet.Cells[3, 7] = "Số Lượng";

            for (int i = 0; i < gvTKKH.RowCount; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = gvTKKH.Rows[i].Cells[j].Value;
                }
            }
            int dem = gvTKKH.RowCount;


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
            worksheet.Range["C1"].ColumnWidth = 29;
            worksheet.Range["D1"].ColumnWidth = 33;
            worksheet.Range["E1"].ColumnWidth = 31;
            worksheet.Range["F1"].ColumnWidth = 22;
            worksheet.Range["G1"].ColumnWidth = 23;


            // Định dạng font chữ
            //     worksheet.Range["A1", "J100"].Font.Name = "";
            worksheet.Range["A1", "A100"].Font.Size = 24;
            worksheet.Range["A3", "J100"].Font.Size = 16;
            worksheet.Range["A1", "G1"].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;

            //worksheet.Range["A3", "J3"].MergeCells = true;
            worksheet.Range["A3", "G3"].Font.Bold = true;

            // kẻ bảng
            worksheet.Range["A3", "G" + (dem + 3)].Borders.LineStyle = 1;


            //Định dạng dòng text
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A3", "G3"].HorizontalAlignment = 3;
            worksheet.Range["A4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["B4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["C4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["D4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["E4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["F4", "G" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["G4", "G" + (dem + 4)].HorizontalAlignment = 3;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
