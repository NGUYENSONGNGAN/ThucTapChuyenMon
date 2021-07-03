using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapCM.DAO;
using System.Data.SqlClient;

namespace ThucTapCM
{
    public partial class ThongKeThuChi : Form
    {
        public ThongKeThuChi()
        {
            InitializeComponent();
           
        }

        private void ThongKeThuChi_Load(object sender, EventArgs e)
        {

            btrThu.Checked = true;
            string selectnam = "Execute NamBanHang";
            DataTable namban = DataProvider.Instance.ExecuteQuery(selectnam);

            cbxNam.DisplayMember = "Nam";
            cbxNam.ValueMember = "Nam";
            cbxNam.DataSource = namban;

             
        }

        private void btrChi_CheckedChanged(object sender, EventArgs e)
        {
            string selectnam = "Execute NamNhapHang";
            DataTable namnhap = DataProvider.Instance.ExecuteQuery(selectnam);

            cbxNam.DisplayMember = "Nam";
            cbxNam.ValueMember = "Nam";
            cbxNam.DataSource = namnhap;
        }

        private void btrThu_CheckedChanged(object sender, EventArgs e)
        {
            string selectnam = "Execute NamBanHang";
            DataTable namban = DataProvider.Instance.ExecuteQuery(selectnam);
            cbxNam.DisplayMember = "Nam";
            cbxNam.ValueMember = "Nam";
            cbxNam.DataSource = namban;
            
        }

        private void cbxNam_SelectedValueChanged(object sender, EventArgs e)
        {
            if (btrThu.Checked )
            {
                string query = "execute DanhSachHDNTrongNam  @nam ";
                DataTable DSHDN = DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToInt32(cbxNam.SelectedValue) });
                gvthuchi.DataSource = DSHDN;

               
            }
            if (btrChi.Checked)
            {
                string query = "execute DanhSachHDXtTrongNam  @nam ";
                DataTable DSHDB = DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToInt32(cbxNam.SelectedValue) });
                gvthuchi.DataSource = DSHDB;
               
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            

                if (btrChi.Checked)
                {
                    // Dua du lieu vao excel
                    worksheet.Cells[1, 4] = "Bảng Thống Kê Tổng Tiền Nhập Của Năm " + cbxNam.SelectedValue.ToString();
                    worksheet.Cells[2, 3] = "";
                    worksheet.Cells[3, 1] = "STT";
                    worksheet.Cells[3, 2] = "Mã Hóa Đơn";
                    worksheet.Cells[3, 3] = "Ngày Nhập";
                    worksheet.Cells[3, 4] = "Số lượng Nhập";
                    worksheet.Cells[3, 5] = "Tổng Tiền";
                    worksheet.Cells[3, 6] = "Tên Nhà Cung Cấp";
                    worksheet.Cells[3, 7] = "Tên Nhân viên";

                for (int i = 0; i < gvthuchi.RowCount; i++)  //đếm stt
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            worksheet.Cells[i + 4, 1] = i + 1;
                            worksheet.Cells[i + 4, j + 2] = gvthuchi.Rows[i].Cells[j].Value;
                        }
                    }
                int dem = gvthuchi.RowCount;
                int tongtienchi = 0;
                /*foreach (var chi in dt.DanhSachHDNTrongNam(Convert.ToInt32(gvthuchi.SelectedValue)))
                {
                    tongtienchi = tongtienchi + Convert.ToInt32(chi.TongTien);
                }

                worksheet.Cells[dem + 4, 5] = "Tổng Tiền: ";
                worksheet.Cells[dem + 4, 6] = tongtienchi;
*/
                // Định dạng trang
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                    worksheet.PageSetup.LeftMargin = 0;
                    worksheet.PageSetup.RightMargin = 0;
                    worksheet.PageSetup.TopMargin = 0;
                    worksheet.PageSetup.BottomMargin = 0;

                    // Đinh dạng cột
                    worksheet.Range["A1"].ColumnWidth = 10;
                    worksheet.Range["B1"].ColumnWidth = 27;
                    worksheet.Range["C1"].ColumnWidth = 15;
                    worksheet.Range["D1"].ColumnWidth = 27;
                    worksheet.Range["E1"].ColumnWidth = 21;
                    worksheet.Range["F1"].ColumnWidth = 26;
                    worksheet.Range["G1"].ColumnWidth = 26;

                // Định dạng font chữ
                worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
                    worksheet.Range["A1", "A100"].Font.Size = 24;
                    worksheet.Range["A3", "J100"].Font.Size = 16;
                    worksheet.Range["A1", "H1"].MergeCells = true;
                    worksheet.Range["A1", "H1"].Font.Bold = true;


                    worksheet.Range["A3", "G3"].Font.Bold = true;

                    // kẻ bảng
                    worksheet.Range["A3", "G" + (dem + 3)].Borders.LineStyle = 1;


                    //Định dạng dòng text
                    worksheet.Range["A1", "F1"].HorizontalAlignment = 3;
                    worksheet.Range["A3", "F3"].HorizontalAlignment = 3;
                    worksheet.Range["A4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["B4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["C4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["D4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["E4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["F4", "F" + (dem + 4)].HorizontalAlignment = 3;
                    worksheet.Range["F4", "F" + (dem + 4)].HorizontalAlignment = 3;


            }
                else if (btrThu.Checked)
                {
                    // Dua du lieu vao excel
                    worksheet.Cells[1, 4] = "Bảng Thống Kê Tổng Tiền Bán Hàng Của Năm " + cbxNam.SelectedValue.ToString();
                    worksheet.Cells[2, 3] = "";
                    worksheet.Cells[3, 1] = "STT";
                    worksheet.Cells[3, 2] = "Mã Hóa Đơn";
                    worksheet.Cells[3, 3] = "Ngày Xuất";
                    worksheet.Cells[3, 4] = "Tổng Tiền";
                    worksheet.Cells[3, 5] = "Ghi Chú";
                    worksheet.Cells[3, 6] = "Tên Khách Hàng";
                    worksheet.Cells[3, 7] = "Tên Nhân Viên";

                    for (int i = 0; i < gvthuchi.RowCount; i++)  //đếm stt
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            worksheet.Cells[i + 4, 1] = i + 1;
                            worksheet.Cells[i + 4, j + 2] = gvthuchi.Rows[i].Cells[j].Value;
                        }
                    }
                    int dem = gvthuchi.RowCount;
                    int tongtienthu = 0;

                /* foreach (var thu in dt.DanhSachHDXtTrongNam(Convert.ToInt32(cbxNam.SelectedValue)))
                 {
                     tongtienthu = tongtienthu + Convert.ToInt32(thu.TongTien);
                 }*//*
                string query = "execute DanhSachHDXtTrongNam  @nam ";
                DataTable DSHDB = DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToInt32(cbxNam.SelectedValue) });
                for (int i = 0; i < DSHDB.Rows.Count; i++)
                {
                    tongtienthu = tongtienthu + float.Parse(DSHDB.Rows[i]["DonGia"].ToString());
                }

                worksheet.Cells[dem + 4, 4] = "Tổng Tiền: ";
                    worksheet.Cells[dem + 4, 5] = tongtienthu;
*/
                    // Định dạng trang
                    worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                    worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                    worksheet.PageSetup.LeftMargin = 0;
                    worksheet.PageSetup.RightMargin = 0;
                    worksheet.PageSetup.TopMargin = 0;
                    worksheet.PageSetup.BottomMargin = 0;

                    // Đinh dạng cột
                    worksheet.Range["A1"].ColumnWidth = 10;
                    worksheet.Range["B1"].ColumnWidth = 27;
                    worksheet.Range["C1"].ColumnWidth = 25;
                    worksheet.Range["D1"].ColumnWidth = 27;
                    worksheet.Range["E1"].ColumnWidth = 21;
                    worksheet.Range["F1"].ColumnWidth = 26;
                    worksheet.Range["G1"].ColumnWidth = 26;

                    // Định dạng font chữ
                    worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
                    worksheet.Range["A1", "A100"].Font.Size = 24;
                    worksheet.Range["A3", "J100"].Font.Size = 16;
                    worksheet.Range["A1", "G1"].MergeCells = true;
                    worksheet.Range["A1", "G1"].Font.Bold = true;


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
                }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }
    }
}
