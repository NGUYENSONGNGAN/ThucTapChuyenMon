using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCM
{
    public partial class FormXuatHoaDonReport : Form
    {
        int mahd1 = FromThanhToanHDX.MHDB;
        int mahd2 = QuetmaQR.TTTK.MaHDX;
        int mahd3 = QLhoadonban.MaHDX;
        int mahd;
        int moform;
       
        public FormXuatHoaDonReport()
        {
            InitializeComponent();
        }

        private void FormXuatHoaDonReport_Load(object sender, EventArgs e)
        {
            if (mahd1==0 && mahd2 == 0 )
            {
                mahd = mahd3;
                moform = 3;
            }
            else if(mahd2 == 0 && mahd3 == 0)
            {
                mahd = mahd1;
                moform = 1;
            }
            else if (mahd1 == 0 && mahd3 == 0)
            {
                mahd = mahd2;
                moform = 2;
            }

            // TODO: This line of code loads data into the 'datasetXHD.gvgiohang6' table. You can move, or remove it, as needed.
            this.gvgiohang6TableAdapter.Fill(this.datasetXHD.gvgiohang6, Convert.ToInt32(mahd));

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(moform == 1)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
                moform = 0;
                mahd = 0;
            } 
            else if(moform ==2)
            {
                QuetmaQR quetmaQR = new QuetmaQR();
                this.Hide();
                quetmaQR.Show();
                moform = 0;
                mahd = 0;
            } 
            else if(moform ==3)
            {
                QLhoadonban qLhoadonban = new QLhoadonban();
                this.Hide();
                qLhoadonban.Show();
                moform = 0;
                mahd = 0;
            }    
        }
    }
}
