using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatKhachHang
{
    public partial class FromloginCurtom : Form
    {
        public static int id;
        public FromloginCurtom()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String query = "Select * From KhachHang Where SoDienThoai = '" + txtphone.Text.Trim() + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            if (table.Rows.Count == 1)
            {
                id = int.Parse(table.Rows[0]["MaKH"].ToString());
                string selectname = "select TenKH from KhachHang where  MaKH= '" + id + "' ";
                string Ten = DataProvider.Instance.ExecuteScalar(selectname).ToString();

                DialogResult a = MessageBox.Show("Bạn là '" + Ten.ToString() + "'?", "Login", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {


                    TTKhachhang tTKhachhang = new TTKhachhang();
                    this.Hide();
                    tTKhachhang.Show();
                }

            }
            else
            {
                MessageBox.Show("check your phone!");

            }
        }
    }
}
