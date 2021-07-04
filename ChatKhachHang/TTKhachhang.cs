﻿using System;
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
    public partial class TTKhachhang : Form
    {
        int id = FromloginCurtom.id;
        public TTKhachhang()
        {
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
            DataTable gvtb = DataProvider.Instance.ExecuteQuery("Execute gvkh @makh ", new object[] { id });
            gvHangTon.DataSource = gvtb;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FromloginCurtom fromlogin = new FromloginCurtom();
            this.Hide();
            fromlogin.Show();
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
