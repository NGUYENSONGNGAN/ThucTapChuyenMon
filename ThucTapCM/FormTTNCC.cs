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
    public partial class FormTTNCC : Form
    {
        int i ;
        int loaiform = 0; 
        public FormTTNCC()
        {
            InitializeComponent();
            loaddata();
        }
        public FormTTNCC(int moform)
        {
            this.loaiform = moform;
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            string query = "select MaNCC N'Mã Nhà cung cấp' , TenNCC N'Tên nhà cung cấp'  ,DiaChi N'Địa chỉ',SoDienThoai N'Số điện thoại' from NhaCungcap";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            btnAdd.Enabled = true;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            btnHuy.Enabled = true;
            txtNameNCC.Enabled = false;
            txtAdressNCC.Enabled = false;
            txtPhoneNCC.Enabled = false;
            lbMNCC.Visible = false;
            txtAdressNCC.ResetText();
            txtPhoneNCC.ResetText();
            txtNameNCC.ResetText();

            dtGVNCC.DataSource = result;

        }

        private void dtGVNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không ???", "Xóa", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                string query = "Delete NhaCungCap where MaNCC = '"+ lbMNCC.Text + "' ";
                DataProvider.Instance.ExecuteNonQuery(query);
                loaddata();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            i = 1;
            string query = "select Max(MaNCC) from NhaCungcap";
            int a = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());

            if (a == 0)
            {
                lbMNCC.Text = "1";
            }
            else if (a != 0)
            {
                lbMNCC.Text = Convert.ToString(Convert.ToInt32(a.ToString()) + 1);
                // int a = Convert.ToInt32()
            }


            lbMNCC.Visible = true;
            txtAdressNCC.Enabled = true;
            txtPhoneNCC.Enabled = true;
            txtNameNCC.Enabled = true;
            txtAdressNCC.ResetText();
            txtPhoneNCC.ResetText();
            txtNameNCC.ResetText();
            btnReset.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            i = 2;
            txtNameNCC.Enabled = true;
            txtPhoneNCC.Enabled = true;
            txtAdressNCC.Enabled = true;
            txtNameNCC.Focus();
            btnAdd.Enabled = false;
            btnReset.Enabled = false;
            btnSave.Enabled = true;
            btnHuy.Enabled = true;
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            
            lbMNCC.Enabled = false; 
            lbMNCC.Visible = false;
            txtAdressNCC.Enabled = false;
            txtPhoneNCC.Enabled = false;
            txtNameNCC.Enabled = false;
            txtNameNCC.ResetText();
            txtAdressNCC.ResetText();
            txtPhoneNCC.ResetText();
            btnAdd.Enabled = true;
            btnReset.Enabled = false;
            btnSave.Enabled = false;
            btnHuy.Enabled = true;
            loaddata();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (txtAdressNCC.Text == "" || txtPhoneNCC.Text == "" || txtNameNCC.Text == "")
                {

                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    string query = "execute InsertNCC @ma , @ten , @diachi , @sodienthoai ";
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMNCC.Text), txtNameNCC.Text, txtAdressNCC.Text, txtPhoneNCC.Text });
                    
                    loaddata();
                }
            }
            else if (i == 2)
            {
                if (txtAdressNCC.Text == "" || txtPhoneNCC.Text == "" || txtNameNCC.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    string query = "execute updateNCC @ma , @ten , @DiaChi , @SDT  ";
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMNCC.Text), txtNameNCC.Text, txtAdressNCC.Text, txtPhoneNCC.Text });
                    loaddata();
                }
            }
        }


        private void txtPhoneNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == null || bunifuMaterialTextbox1.Text == "")
            {
                loaddata();
            }
            else
            {
                string query = "execute SeachNCC @ten ";
                DataTable seach = DataProvider.Instance.ExecuteQuery(query, new object[] { bunifuMaterialTextbox1.Text });
                btnAdd.Enabled = true;
                btnReset.Enabled = false;
                btnSave.Enabled = false;
                btnHuy.Enabled = true;
                txtNameNCC.Enabled = false;
                txtAdressNCC.Enabled = false;
                txtPhoneNCC.Enabled = false;
                lbMNCC.Visible = false;

                dtGVNCC.DataSource = seach;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(loaiform == 2)
            {
                Main main = new Main();
                this.Close();
                main.Show();
            }
            else if(loaiform ==1)
            {
                HoaDonNhapHang hoaDonNhap = new HoaDonNhapHang();
                this.Close();
                hoaDonNhap.Show();
            }    
           
        }

        private void dtGVNCC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int r = dtGVNCC.CurrentRow.Index;
            lbMNCC.Text = dtGVNCC.Rows[r].Cells[0].Value.ToString();
            txtNameNCC.Text = dtGVNCC.Rows[r].Cells[1].Value.ToString();
            txtAdressNCC.Text = dtGVNCC.Rows[r].Cells[2].Value.ToString();
            txtPhoneNCC.Text = dtGVNCC.Rows[r].Cells[3].Value.ToString();
            btnReset.Enabled = true;


            lbMNCC.Visible = true;
            txtAdressNCC.Enabled = false;
            txtPhoneNCC.Enabled = false;
            txtNameNCC.Enabled = false;
            btnAdd.Enabled = true;
            btnReset.Enabled = true;
            btnSave.Enabled = false;

        }
    }
}
