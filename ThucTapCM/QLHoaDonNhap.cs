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
    public partial class QLHoaDonNhap : Form
    {
        public static int to;
        public QLHoaDonNhap()
        {
            InitializeComponent();
            load();
        }
       
        void load()
        {
            lbMahd.Visible = false;
            string gvHDNH = "execute QLHDM";
            DataTable HDNHGV = DataProvider.Instance.ExecuteQuery(gvHDNH);
            gvHDN.DataSource = HDNHGV;
            
           
        }

      

        private void btnXCT_Click(object sender, EventArgs e)
        {
            if(to>0)
            {
                ChiTietHDNH chiTietHDNH = new ChiTietHDNH();
                chiTietHDNH.Show();
                this.Hide();
               
            } 
            else
            {
                MessageBox.Show("Vui Lòng Chọn Hóa Đơn", "Error");
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void txtseach_OnValueChanged(object sender, EventArgs e)
        {
            if (txtseach.Text == null || txtseach.Text == "")
            {

            }
            else
            {
                
                string query = " execute SeachHDN1 @Tenma ";
                DataTable seach = DataProvider.Instance.ExecuteQuery(query, new object[] { txtseach.Text });
                gvHDN.DataSource = seach;
                

            }
        }


        private void gvHDN_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvHDN.CurrentRow.Index;
            lbMahd.Text = gvHDN.Rows[r].Cells[0].Value.ToString();
            to = Convert.ToInt32(lbMahd.Text);
        }
    }
}
