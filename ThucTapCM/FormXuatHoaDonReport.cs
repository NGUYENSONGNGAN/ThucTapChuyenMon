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

        int mahd = 0;

        int loaiForm = 0;
        public FormXuatHoaDonReport()
        {
            InitializeComponent();
        }

        public FormXuatHoaDonReport(int ma, int loaiForm)
        {
            this.mahd = ma;
            this.loaiForm = loaiForm;
            InitializeComponent();
        }

        private void FormXuatHoaDonReport_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'datasetXHD.gvgiohang6' table. You can move, or remove it, as needed.
            this.gvgiohang6TableAdapter.Fill(this.datasetXHD.gvgiohang6, this.mahd);

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(loaiForm == 1)
            {  
               
                Main main = new Main();
                this.Hide();
                main.Show();
         
            } 
            else if(loaiForm == 2)
            {
                
             
                QuetmaQR quetmaQR = new QuetmaQR();
                this.Hide();
                quetmaQR.Show();

   
            } 
            else if(loaiForm == 3)
            {

                QLhoadonban qLhoadonban = new QLhoadonban();
                this.Hide();
                qLhoadonban.Show();
     
        

            }    
        }
    }
}
