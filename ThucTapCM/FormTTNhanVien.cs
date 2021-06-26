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
    public partial class FormTTNhanVien : Form
    {
        public static int to;
        public FormTTNhanVien()
        {
            InitializeComponent();
            loaddata();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AddNhanVienTTNV tTNV = new AddNhanVienTTNV();
            this.Dispose();
            tTNV.Show();

        }
        void loaddata()
        {
            string query = "select MaNV N'Mã nhân viên' , TenNV N'Tên nhân viên'   ,GioiTinh N'Giới tính',NgaySinh N'Ngày sinh' ,Gmail,DiaChi N'Địa chỉ',NgayVaoLam N'Ngày vào làm',SoDienThoai N'Số điện thoại',TaiKhoan N'Tài khoản',MatKhau N'Mật khẩu',TenCV N'Tên chức vụ' from NhanVien left join ChucVu on NhanVien.MaCV = ChucVu.MaCV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            gvTTNV.DataSource = result;
            lbMaNV.Enabled = false;
            // btnDelete.Enabled = false;//vat het ddi code giong cai t as oki 2 nayf luoon har ? uk  de do
            //bunifuThinButton21.Enabled = false;
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (to > 0)
            {
                DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Delete", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    string query = "delete from NhanVien where MaNV = '" + lbMaNV.Text + "'";
                    DataProvider.Instance.ExecuteNonQuery(query);
                    loaddata();
                    to = 0;
                }
            }
            else
            {
                MessageBox.Show("vui long chon nv de xoa");
            }


        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == null || bunifuMetroTextbox1.Text == "")
            {
                loaddata();
            }
            else
            {
                string query = "execute SeachNV @ten ";
                DataTable seach = DataProvider.Instance.ExecuteQuery(query, new object[] { bunifuMetroTextbox1.Text });
                gvTTNV.DataSource = seach;


            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (to > 0)
                {
                    ResetNV reset = new ResetNV();
                    this.Hide();
                    reset.Show();
                    to = 0;
                }


            }
            catch
            {
                MessageBox.Show("Banj vui long chon ma nv");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void gvTTNV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvTTNV.CurrentRow.Index;
            lbMaNV.Text = gvTTNV.Rows[r].Cells[0].Value.ToString();
            to = (Convert.ToInt32((lbMaNV.Text).ToString()));
            btnDelete.Enabled = true;
            bunifuThinButton21.Enabled = true;
            lbMaNV.Visible = false;
        }
    }
}
