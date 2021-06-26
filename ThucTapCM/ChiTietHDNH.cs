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
    public partial class ChiTietHDNH : Form
    {
        int MaHD = QLHoaDonNhap.to;
        public ChiTietHDNH()
        {
            InitializeComponent();
        }

        private void ChiTietHDNH_Load(object sender, EventArgs e)
        {
            string query = "execute gvgiohangnhap1 @ma ";
            DataTable CTHDN =   DataProvider.Instance.ExecuteQuery(query , new object[] { MaHD});
            gvCTHDN.DataSource = CTHDN;
            lvMHDCT.Text = Convert.ToString( MaHD);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QLHoaDonNhap qLHoaDonNhap = new QLHoaDonNhap();
            this.Close();
            qLHoaDonNhap.Show();
        }
    }
}
