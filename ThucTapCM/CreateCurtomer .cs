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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ThucTapCM
{
    public partial class CreateCurtomer : Form
    {
        static public int MKHM;
        public CreateCurtomer()
        {
            InitializeComponent();
        }
        private void CreateCurtomer_Load(object sender, EventArgs e)
        {
            string query = "select Max(MaKH) from KhachHang";
            int r = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());

            if (r == 0)
            {
                lbMKH.Text = "1";
            }
            else if (r != 0)
            {
                lbMKH.Text = Convert.ToString(Convert.ToInt32(r.ToString()) + 1);
                // int a = Convert.ToInt32()
            }
            MKHM = Convert.ToInt32((lbMKH.Text).ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            


            if (txtTenKH.Text == "" || txtTenKH.Text == null || txtSĐT.Text == "" || txtSĐT.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập đủ\nVui lòng kiểm tra lại", "Thiếu thông tin");
            }
            else
            {
                if (txtAdress.Text.Trim() == "" || txtGmail.Text.Trim() == "")
                {
                    DialogResult kiemtra = MessageBox.Show("Chưa nhập đủ thông tin\nBạn có muốn tiếp tục ?", "Thiếu thông tin", MessageBoxButtons.YesNo);
                    if (kiemtra == DialogResult.Yes)
                    {
                           string query1 = "execute insertKHADD @ma , @ten , @DiaChi , @SoDienThoai , @gmail ";
                            int add = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { Convert.ToInt32(lbMKH.Text), txtTenKH.Text , txtAdress.Text, Convert.ToInt32(txtSĐT.Text), txtGmail.Text });
                        if (add >= 1)
                        {
                            MessageBox.Show("Wellcome !", "Sucessful");
                            HBBanHang HDBanHang = new HBBanHang();
                            this.Hide();
                            HDBanHang.Show();
                        }


                    }
                }

                else
                {
                    Regex mRegxExpression;
                    if (txtGmail.Text.Trim() != string.Empty)
                    {
                        mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]

                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|

                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                        if (!mRegxExpression.IsMatch(txtGmail.Text.Trim()))
                        {
                            txtGmail.Focus();
                        }
                        else
                        {
                            string query1 = "execute insertKHADD @ma , @ten , @DiaChi , @SoDienThoai , @gmail ";
                            int add = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { Convert.ToInt32(lbMKH.Text), txtTenKH.Text, txtAdress.Text, Convert.ToInt32(txtSĐT.Text), txtGmail.Text });
                            if (add >= 1)
                            {
                                MessageBox.Show("Wellcome !", "Sucessful");
                                HBBanHang HDBanHang = new HBBanHang();
                                this.Hide();
                                HDBanHang.Show();
                            }
                        }
                    }
                }
            }

        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            MKHM = 0;
            HDBHMenu hDBH = new HDBHMenu();
            this.Hide();
            hDBH.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtGmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]
                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|
                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(txtGmail.Text.Trim()))
                {
                    MessageBox.Show("Lỗi định dạng email", "Lỗi");
                    txtGmail.Focus();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
