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
    public partial class BackUpData : Form
    {
        public BackUpData()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7T6R5H\SQLEXPRESS;Initial Catalog=DOANCHUYENMON7;Integrated Security=True");
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = dlg.SelectedPath;
               
            }
        }

        private void btnBackup_Click_1(object sender, EventArgs e)
        {
            string database = con.Database.ToString();

            try
            {
                if (txtBackup.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa chọn đường dẫn để lưu");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txtBackup.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("BackUp dữ liệu thành công", "Thành công");
                        this.Close();
                    }
                }

            }

            catch (Exception)
            {
                btnBackup_Click_1(sender, e);
            }
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
