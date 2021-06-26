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
    public partial class FormTTKhachHang : Form
    {
        int i = 0;
        public FormTTKhachHang()
        {
            InitializeComponent();
            loaddata();
        }


        void loaddata()
        {
            string query = "select MaKH N'Mã KH' , TenKH N'Tên KH' ,DiemTichLuy N'Điểm tích lũy' ,DiaChi N'Địa chỉ',SoDienThoai N'Số điện thoại',Gmail , TenLKH N'Loại Khách Hàng' from KhachHang left join LoaiKH on KhachHang.MaLKH = LoaiKH.MaLKH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            btnAdd.Enabled = true;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            btnHuy.Enabled = true;
            txtName.Enabled = false;
            txtGmail.Enabled = false;
            txtAdress.Enabled = false;
            txtPhone.Enabled = false;
            lbMKH.Visible = false;
            lbDTL.Visible = false;
            lbLKH.Visible = false;


            DataGV.DataSource = result;

        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = DataGV.CurrentRow.Index;
            lbMKH.Text = DataGV.Rows[r].Cells[0].Value.ToString();
            txtName.Text = DataGV.Rows[r].Cells[1].Value.ToString();
            lbDTL.Text = DataGV.Rows[r].Cells[2].Value.ToString();
            txtAdress.Text = DataGV.Rows[r].Cells[3].Value.ToString();
            txtPhone.Text = DataGV.Rows[r].Cells[4].Value.ToString();
            txtGmail.Text = DataGV.Rows[r].Cells[5].Value.ToString();
            lbLKH.Text = DataGV.Rows[r].Cells[6].Value.ToString();

            lbMKH.Visible = true;
            lbDTL.Visible = true;
            lbLKH.Visible = true;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtAdress.Enabled = false;
            txtGmail.Enabled = false;
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
            btnSave.Enabled = false;
            btnHuy.Enabled = true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            i = 1;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnSave.Enabled = true;
            btnHuy.Enabled = true;
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
            lbDTL.Text = "0";
            lbLKH.Text = "Đồng";
            lbMKH.Visible = true;
            lbDTL.Visible = true;
            lbLKH.Visible = true;
            txtName.Enabled = true;
            txtGmail.Enabled = true;
            txtAdress.Enabled = true;
            txtPhone.Enabled = true;
            txtName.ResetText();
            txtGmail.ResetText();
            txtPhone.ResetText();
            txtAdress.ResetText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lbMKH.Visible = false;
            lbDTL.Visible = false;
            lbLKH.Visible = false;
            txtName.ResetText();
            txtGmail.ResetText();
            txtPhone.ResetText();
            txtAdress.ResetText();
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtAdress.Enabled = false;
            txtGmail.Enabled = false;
            btnAdd.Enabled = true;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            btnHuy.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            i = 2;
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnSave.Enabled = true;
            btnHuy.Enabled = true;

            txtName.Enabled = true;
            txtGmail.Enabled = true;
            txtAdress.Enabled = true;
            txtPhone.Enabled = true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == null || txtPhone.Text == "" || txtPhone.Text == null)
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
                        if (i == 1)
                        {
                            string query = "execute insertKH @ma , @ten , @DiemTichLuy , @DiaChi , @SoDienThoai , @gmail ";
                            DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMKH.Text) ,txtName.Text, lbDTL.Text, txtAdress.Text, txtPhone.Text, txtGmail.Text}) ;
                            loaddata();

                        }
                        else if (i == 2)
                        {
                            string query = "execute updateKH2 @ma , @ten , @DiaChi , @SDT , @Gmail ";
                            DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMKH.Text), txtName.Text, txtAdress.Text, txtPhone.Text, txtGmail.Text });
                            loaddata();

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
                            if (i == 1)
                            {
                                string query = "execute insertKH @ma , @ten , @DiemTichLuy , @DiaChi , @SoDienThoai , @gmail ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMKH.Text), txtName.Text, lbDTL.Text, txtAdress.Text, txtPhone.Text, txtGmail.Text, lbMKH.Text });
                                loaddata();

                            }
                            else if (i == 2)
                            {
                                string query = "execute updateKH2 @ma , @ten , @DiaChi , @SDT , @Gmail ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMKH.Text), txtName.Text, txtAdress.Text, txtPhone.Text, txtGmail.Text });
                                loaddata();
                            }
                        }
                    }
                }
            }
        }

        private void FormTTKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
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

        private void DataGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int r = DataGV.CurrentRow.Index;
            lbMKH.Text = DataGV.Rows[r].Cells[0].Value.ToString();
            txtName.Text = DataGV.Rows[r].Cells[1].Value.ToString();
            lbDTL.Text = DataGV.Rows[r].Cells[2].Value.ToString();
            txtAdress.Text = DataGV.Rows[r].Cells[3].Value.ToString();
            txtPhone.Text = DataGV.Rows[r].Cells[4].Value.ToString();
            txtGmail.Text = DataGV.Rows[r].Cells[5].Value.ToString();
            lbLKH.Text = DataGV.Rows[r].Cells[6].Value.ToString();

            lbMKH.Visible = true;
            lbDTL.Visible = true;
            lbLKH.Visible = true;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtAdress.Enabled = false;
            txtGmail.Enabled = false;
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
            btnSave.Enabled = false;
            btnHuy.Enabled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

        
    }
    
