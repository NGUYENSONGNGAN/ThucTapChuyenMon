using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Data.SqlClient;
using ThucTapCM.DAO;

namespace ThucTapCM
{
    public partial class FromThanhToanHDX : Form
    {
        int MHDBHFB = HBBanHang.MHDBH;
        int MHDBHFQL = QuetmaQR.TTTK.MaHDX;
        //MemoryStream stream = HBBanHang.stream;
        public static int MHDB;
        int MHDBH;
        public FromThanhToanHDX()
        {
            InitializeComponent();
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        private void FromThanhToanHDX_Load(object sender, EventArgs e)
        {
            /*Image img = Image.FromStream(stream);
            pictQR.Image = img;*/
            if (MHDBHFB == 0)
            {
                MHDBH = MHDBHFQL;
            }
            else if (MHDBHFQL == 0)
            {
                MHDBH = MHDBHFB;
            }
            string querygvm = "execute gvgiohang1 @ma ";
            DataTable gvgiohang1 = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { MHDBH });
            gvgiohang.DataSource = gvgiohang1;

            String selectTongTien = "Select TongTien , MaQR ,MaHD from HoaDonBanHang where MaHD = '" + Convert.ToInt32(MHDBH) + "'";
            DataTable tongtien =DataProvider.Instance.ExecuteQuery(selectTongTien);
            double tien = double.Parse(tongtien.Rows[0]["TongTien"].ToString());
            lbTongTien.Text = tien.ToString();

             MHDB =Convert.ToInt32( MHDBH);
           
            //double MaHD = double.Parse(tongtien.Rows[0]["MaHD"].ToString());

            /*Image stream = Image.Parse(tongtien.Rows[0]["MaQR"].ToString());

             = Image.FromStream(stream);
            pictQR.Image = img;*/
            MemoryStream ms = new MemoryStream((byte[])tongtien.Rows[0]["MaQR"]);
            Image img = Image.FromStream(ms);
            pictQR.Image = img;
            //pictQR.Image = new Bitmap(ms);
          
        }

        private void btnghichu_Click(object sender, EventArgs e)
        {

            if (txtghichu.Text.Trim() == "" || txtghichu.Text.Trim() == null)
            {
                DialogResult a = MessageBox.Show("Chưa có ghi chú \n Bạn có muốn tiếp tục xuất hóa đơn?", "Hủy", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    FormXuatHoaDonReport xuatHoaDonReport = new FormXuatHoaDonReport(MHDB,1);
                   
                    this.Close();
                    xuatHoaDonReport.Show();
                }
            }else
            {
                string udateHDB = "update HoaDonBanHang set TrangThai = 1 , GhiChu =  '" +Convert.ToString( txtghichu.Text) + "'where MaHD ='" + Convert.ToInt32(MHDBH) + "'";
                DataProvider.Instance.ExecuteNonQuery(udateHDB);
                FormXuatHoaDonReport xuatHoaDonReport = new FormXuatHoaDonReport(MHDB, 1);
                this.Close();
                xuatHoaDonReport.Show();
            }

        }

        private void gvgiohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
