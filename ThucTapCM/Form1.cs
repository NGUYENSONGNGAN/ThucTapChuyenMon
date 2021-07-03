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
    
    public partial class txtPassWord : Form
    {
        public static int mcv;
        public static int id;
           public txtPassWord()
        {

            InitializeComponent();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
			String query = "Select * From NhanVien Where TaiKhoan = '" + txtUserName.Text.Trim() + "'and MatKhau = '" + txtPass.Text.Trim() + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
			if(table.Rows.Count ==1)
            {
                id = int.Parse(table.Rows[0]["MaNV"].ToString());


                /*String query1 = "execute Userlogin1 @taikhoan  , @matkhau ";
                int mcv = int.Parse(DataProvider.Instance.ExecuteScalar((query1),new object[] { txtUserName.Text,txtPass.Text}).ToString());
                MessageBox.Show(mcv.ToString());*/

                try
                {
                    //String query1 = "select MaCV from NhanVien where TaiKhoan= '"+txtUserName.Text+"' and MatKhau = '"+txtPass.Text+"' ";
                    String query1 = "select MaCV from NhanVien where  MaNV= '" + id + "' ";
                    mcv = int.Parse(DataProvider.Instance.ExecuteScalar(query1).ToString());
                }
                catch { mcv 
                        = 0 ; }
               
                MessageBox.Show("well come SNN!!!", "say hi", MessageBoxButtons.OK);
				Main main = new Main();
                this.Hide();
				main.Show();

            }
            else
            {
				MessageBox.Show("check your user name and password!");

			}
            
        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            DialogResult rout = MessageBox.Show("Are you sure want to out ?", "out", MessageBoxButtons.YesNo);
            if(rout == DialogResult.Yes)
            {
                Application.Exit();
                return;
            }    
        }

        private void lbforgot_Click(object sender, EventArgs e)
        {
            ForgotPassWord forgotPass = new ForgotPassWord();
            this.Hide();
            forgotPass.ShowDialog();
        }




        /*SqlConnection connection;
        SqlCommand command;
        string constr = @"Data Source=LAPTOP-AJMJJI2P;Initial Catalog=QuanLiNhanVien2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }*/
    }
}
