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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace ThucTapCM
{
    public partial class ResetNV : Form
    {
        int MNV = FormTTNhanVien.to; 
        public ResetNV()
        {
            InitializeComponent();
        }

        

        private void ResetNV_Load(object sender, EventArgs e)
        {
          
            cbxChucVuCT.Items.Add("Quản lí");
            cbxChucVuCT.Items.Add("Kế toán");
            cbxChucVuCT.Items.Add("Nhân viên");
            cbxChucVuCT.SelectedIndex = 0;
            lbMNVCT.Text = Convert.ToString(MNV);
            string query = "execute TNV @maNV='"+lbMNVCT.Text+"' ";
            string ten = DataProvider.Instance.ExecuteScalar(query).ToString();
            txtNameNVCT.Text = ten;
            string query1 = "execute MCV @maNV='" + lbMNVCT.Text + "' ";
            string MCV = DataProvider.Instance.ExecuteScalar(query1).ToString();
            if(Convert.ToInt32(MCV)==1)
            {
                cbxChucVuCT.SelectedIndex = 0;
            }
            else if (Convert.ToInt32(MCV) == 2)
            {
                cbxChucVuCT.SelectedIndex = 1;
            }
            else if (Convert.ToInt32(MCV) == 3)
            {
                cbxChucVuCT.SelectedIndex = 2;
            }
            string query2 = "execute GTNV @maNV='" + lbMNVCT.Text + "' ";
            string GT = DataProvider.Instance.ExecuteScalar(query2).ToString();
            if (GT == "Nam")
            {
                rbtNamCT.Checked = true;
            }
            else if (GT == "Nữ")
            {
                rbtnNuCT.Checked = true;
            }
            string query3 = "execute DiaChiNV @maNV='" + lbMNVCT.Text + "' ";
            string DiaChi = DataProvider.Instance.ExecuteScalar(query3).ToString();
            txtAdressNVCT.Text = DiaChi;
            string query4 = "execute GmailNV @maNV='" + lbMNVCT.Text + "' ";
            string Gmail = DataProvider.Instance.ExecuteScalar(query4).ToString();
            txtGmailNVCT.Text = Gmail;
            string query5 = "execute SĐT @maNV='" + lbMNVCT.Text + "' ";
            string SĐT = DataProvider.Instance.ExecuteScalar(query5).ToString();
            txtPhoneNVCT.Text = SĐT;
            string query6 = "execute NSNV1 @maNV='" + lbMNVCT.Text + "' ";
            string NS = DataProvider.Instance.ExecuteScalar(query6).ToString();
            ptimeNSCT.Value = Convert.ToDateTime(NS);
            string query7 = "execute NVLNV @maNV='" + lbMNVCT.Text + "' ";
            string NVL = DataProvider.Instance.ExecuteScalar(query7).ToString();
            ptimeNVLCT.Value = Convert.ToDateTime(NVL);
            lbMNVCT.Enabled = false;
            txtNameNVCT.Enabled = false;
            txtGmailNVCT.Enabled = false;
            txtAdressNVCT.Enabled = false;
            txtPhoneNVCT.Enabled = false;
            rbtNamCT.Enabled = false;
            rbtnNuCT.Enabled = false;
            cbxChucVuCT.Enabled = false;
            ptimeNSCT.Enabled = false;
            ptimeNVLCT.Enabled = false;
            btnSave.Enabled = false;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            string gt = "";
            if (rbtNamCT.Checked == true)
            {
                gt = "Nam";
            }
            else if (rbtnNuCT.Checked == true)
            {
                gt = "Nữ";
            }


            int maCV = 0;
            if (cbxChucVuCT.Text == "Quản lí")
            {
                maCV = 1;
            }
            else if (cbxChucVuCT.Text == "Kế toán")
            {
                maCV = 2;
            }
            if (cbxChucVuCT.Text == "Nhân viên")
            {
                maCV = 3;
            }

            if (txtGmailNVCT.Text.Trim() == "" || txtGmailNVCT.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thiếu thông tin");
            }
            else
            {
                Regex mRegxExpression;
                if (txtGmailNVCT.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]

                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|

                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(txtGmailNVCT.Text.Trim()))
                    {
                        txtGmailNVCT.Focus();
                    }
                    else
                    {
                        string query = "execute UpdateNV1 @ma ,  @ten , @gioitinh , @ngaysinh , @gmail , @diachi , @ngayvaolam , @sodienthoai , @macv ";
                        int UD = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMNVCT.Text), txtNameNVCT.Text, gt, Convert.ToDateTime(ptimeNSCT.Value), txtGmailNVCT.Text, txtAdressNVCT.Text, Convert.ToDateTime(ptimeNVLCT.Value), txtPhoneNVCT.Text, maCV });
                        if (UD == 1)
                        {
                            DialogResult a = MessageBox.Show("Reset Success ! \nBạn muốn tiếp tục", "Success", MessageBoxButtons.YesNo);
                            if (a == DialogResult.No)
                            {
                                FormTTNhanVien tTNhanVien = new FormTTNhanVien();
                                this.Hide();
                                tTNhanVien.Show();
                            }

                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNameNVCT.Enabled = true;
            txtGmailNVCT.Enabled = true;
            txtAdressNVCT.Enabled = true;
            txtPhoneNVCT.Enabled = true;
            rbtNamCT.Enabled = true;
            rbtnNuCT.Enabled = true;
            cbxChucVuCT.Enabled = true;
            ptimeNSCT.Enabled = true;
            ptimeNVLCT.Enabled = true;
            btnSave.Enabled = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void txtPhoneNVCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGmailNVCT_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtGmailNVCT.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4]
                    [0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|
                    (25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(txtGmailNVCT.Text.Trim()))
                {
                    MessageBox.Show("Lỗi định dạng email", "Lỗi");
                    txtGmailNVCT.Focus();
                }
            }
        }
    }
}
