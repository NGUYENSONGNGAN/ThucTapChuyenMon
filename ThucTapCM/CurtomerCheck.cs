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
    public partial class CurtomerCheck : Form
    {
        public CurtomerCheck()
        {
            InitializeComponent();
        }
        public static int MKH = 0;

        private void btnFind_Click(object sender, EventArgs e)
        {
           
            if (txtCheckSĐT.Text.Trim() == "" || txtCheckName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!!", "Lỗi");
            }
            else {
               string query = "select * from KhachHang Where TenKH = '" + txtCheckName.Text + "' and SoDienThoai = '" + txtCheckSĐT.Text + "'";
                DataTable i = DataProvider.Instance.ExecuteQuery(query);
                if (i.Rows.Count<=0)
                {
                    MessageBox.Show("Thông tin bạn nhập sai hoặc \n không tồn tại tài khoản này !", "Lỗi!");
                }
                else if (i.Rows.Count>=1)
                {
                    {

                        string query2 = "select MaKH from KhachHang Where TenKH = '" + txtCheckName.Text + "' and SoDienThoai = '" + txtCheckSĐT.Text + "'";
                        DataTable a1 = DataProvider.Instance.ExecuteQuery(query);
                        string a = a1.Rows[0]["MaKH"].ToString();
                        MKH = Convert.ToInt32((a).ToString());
                        MessageBox.Show("Wellcome !!!!");
                        HBBanHang hBBanHang = new HBBanHang(MKH);
                        this.Hide();
                        hBBanHang.Show();
                    }
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MKH = 0;
            HDBHMenu hDBH = new HDBHMenu();
            this.Hide();
            hDBH.Show();
        }

        private void txtCheckSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
