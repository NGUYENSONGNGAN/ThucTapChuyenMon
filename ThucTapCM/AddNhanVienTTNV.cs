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
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ThucTapCM
{
    public partial class AddNhanVienTTNV : Form
    {
        public AddNhanVienTTNV()
        {
            InitializeComponent();
            load();
        }

        private void AddNhanVienTTNV_Load(object sender, EventArgs e)
        {
            cbxChucVu.Items.Add("Quản lí");
            cbxChucVu.Items.Add("Kế toán");
            cbxChucVu.Items.Add("Nhân viên");
            cbxChucVu.SelectedIndex = 0;


        }
        void load ()
        {
         
            string query = "select Max(MaNV) from NhanVien";
            int a = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());

            if (a == 0)
            {
                lbMNV.Text = "1";
            }
            else if (a != 0)
            {
                lbMNV.Text = Convert.ToString(Convert.ToInt32(a.ToString()) + 1);
                // int a = Convert.ToInt32()
            }
            btnAddNV.Enabled = true;
           
            txtNameNV.ResetText();
            txtAdressNV.ResetText();
            txtGmailNV.ResetText();
            cbxChucVu.ResetText();
            ptimeNS.ResetText();
            ptimeNVL.ResetText();
            txtTaikhoan .ResetText();
            txtMatkhau.ResetText();
            txtPhoneNV.ResetText();


            cbxChucVu.Enabled = true;
            ptimeNS.Enabled = true;
            ptimeNVL.Enabled = true;
            txtNameNV.Enabled = true;
            txtAdressNV.Enabled = true;
            txtGmailNV.Enabled = true;
            txtTaikhoan.Enabled = true;
            txtMatkhau.Enabled = true;
            txtPhoneNV.Enabled = true;
            txtNameNV.Focus();
        }

        private void ptinmeNS_onValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMatkhau_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rbtNam.Checked == true)
            {
                gt = "Nam";
            }
            else if (rbtnNu.Checked == true)
            {
                gt = "Nữ";
            }


            int maCV = 0;
             if(cbxChucVu.Text == "Quản lí" )
            {
                maCV = 1;     }
            else if (cbxChucVu.Text == "Kế toán")
            {
                maCV = 2;
            }
            if (cbxChucVu.Text == "Nhân viên")
            {
                maCV = 3;
            }

            if (txtGmailNV.Text.Trim() == "" || txtGmailNV.Text == null|| txtNameNV.Text.Trim() == "" || txtNameNV.Text == null|| txtMatkhau.Text.Trim() == "" || txtMatkhau.Text == null
                || txtPhoneNV.Text.Trim() == "" || txtPhoneNV.Text == null|| txtTaikhoan.Text.Trim() == "" || txtTaikhoan.Text == null||gt ==null||gt.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thiếu thông tin");
            }
            else
            {
                Regex mRegxExpression;
                if (txtGmailNV.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]

                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|

                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtGmailNV.Text.Trim()))
                    {
                        txtGmailNV.Focus();
                    }
                    else
                    {
                        string query = "execute InsertNV1 @ma , @ten , @gioitinh , @ngaysinh , @gmail , @diachi , @ngayvaolam , @sodienthoai , @taikhoan , @matkhau , @macv ";
                        int insertNV = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMNV.Text), txtNameNV.Text, gt, Convert.ToDateTime(ptimeNS.Value), txtGmailNV.Text, txtAdressNV.Text, Convert.ToDateTime(ptimeNVL.Value), txtPhoneNV.Text, txtTaikhoan.Text, txtMatkhau.Text, maCV });
                        if (insertNV == 1)
                        {
                            DialogResult a = MessageBox.Show("Add Success ! \nBạn muốn tiếp tục", "Success", MessageBoxButtons.YesNo);
                            if (a == DialogResult.No)
                            {
                                FormTTNhanVien tTNhanVien = new FormTTNhanVien();
                                this.Hide();
                                tTNhanVien.Show();
                            }else if (a == DialogResult.Yes)
                            {
                                load();
                            }
                        }
                    }
                }
            }
        }

        private void txtPhoneNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGmailNV_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtGmailNV.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]
                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|
                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(txtGmailNV.Text.Trim()))
                {
                    MessageBox.Show("Lỗi định dạng email", "Lỗi");
                    txtGmailNV.Focus();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormTTNhanVien formTTNhan = new FormTTNhanVien();
            this.Hide();
            formTTNhan.Show();
        }
    }
}
