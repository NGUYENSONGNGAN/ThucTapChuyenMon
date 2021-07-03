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
    }
}
