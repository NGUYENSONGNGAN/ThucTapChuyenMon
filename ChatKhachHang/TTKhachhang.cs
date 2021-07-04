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

namespace ChatKhachHang
{
    public partial class TTKhachhang : Form
    {
        int makh = 0;
        public TTKhachhang()
        {
            InitializeComponent();
        }
        public TTKhachhang(int ma)
        {
            this.makh = ma;
            InitializeComponent();
        }

        private void picChat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
         
        }

        private void TTKhachhang_Load(object sender, EventArgs e)
        {
            DataTable gvkh = DataProvider.Instance.ExecuteQuery("execute gvkh @makh ", new object[] { makh });
            gvHangTon.DataSource = gvkh;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FromloginCurtom fromloginCurtom = new FromloginCurtom();
            this.Hide();
            fromloginCurtom.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult rout = MessageBox.Show("Are you sure want to out ?", "out", MessageBoxButtons.YesNo);
            if (rout == DialogResult.Yes)
            {
                Application.Exit();
                return;
            }
        }
    }
}
