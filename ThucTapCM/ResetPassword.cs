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

namespace ThucTapCM
{
    public partial class btnReset : Form
    {
        string gmail = ForgotPassWord.to;
        public btnReset()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            ForgotPassWord forgotPassWord = new ForgotPassWord();
            this.Hide();
            forgotPassWord.ShowDialog();
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            txtPassWord txtPassWord = new txtPassWord();
            this.Hide();
            txtPassWord.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (txtRePass.Text == txtRePassEnt.Text)
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-O7T6R5H\SQLEXPRESS;Initial Catalog=DOANCHUYENMON7;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand("Update NhanVien set MatKhau = '" + txtRePassEnt.Text + "'where Gmail='" + gmail + "'", sqlConnection);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Reset successfully !");
                txtPassWord txtPassWord = new txtPassWord();
                this.Hide();
                txtPassWord.Show();
            }
            else
            {
                MessageBox.Show("The new password do not math so enter same password !");
            }


        }
    }
}
