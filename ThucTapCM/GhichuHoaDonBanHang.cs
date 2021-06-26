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
    public partial class GhichuHoaDonBanHang : Form
    {
        int MaHDBH = HBBanHang.MHDBH;
        public GhichuHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void btnghichu_Click(object sender, EventArgs e)
        {
            if (txtghichu.Text.Trim() == "" || txtghichu.Text.Trim() == null)
            {
                MessageBox.Show("Bạn phải nhập lí do hủy", "Error");
            }
            else if (txtghichu.Text.Trim() != "")
            {
               
                string UDghichu = "update HoaDonBanHang set GhiChu ='"+txtghichu.Text+"',TrangThai = 0 where MaHD = '"+Convert.ToInt32(MaHDBH)+"'";


                //thiếu update lại só lượng tồn 
                string querygvm = "execute gvgiohang1 @ma ";
                DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { Convert.ToInt32(MaHDBH) });

                //string ten = gvgiohang.Rows[];



                MessageBox.Show("Hủy đơn thành công");
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }
    }
}
