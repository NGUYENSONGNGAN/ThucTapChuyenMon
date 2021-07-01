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

namespace ThucTapCM
{
    public partial class AHDXform : Form
    {
        int mahd = FromThanhToanHDX.MHDB;
        public AHDXform()
        {
            InitializeComponent();
        }

        private void AHDXform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetXHD.gvgiohang6' table. You can move, or remove it, as needed.
            this.gvgiohang6TableAdapter.Fill(this.datasetXHD.gvgiohang6, Convert.ToInt32(mahd));
            // TODO: This line of code loads data into the 'datasetXHD.gvgiohang6' table. You can move, or remove it, as needed.
            //this.gvgiohang6TableAdapter.Fill(this.datasetXHD.gvgiohang6, Convert.ToInt32(mahd));
            // TODO: This line of code loads data into the 'DOANCHUYENMON7DataSet1.gvgiohang5' table. You can move, or remove it, as needed.
            //this.gvgiohang5TableAdapter.Fill(this.DOANCHUYENMON7DataSet1.gvgiohang5);
            // TODO: This line of code loads data into the 'DOANCHUYENMON7DataSet1.gvgiohang5' table. You can move, or remove it, as needed.
            // this.gvgiohang5TableAdapter.Fill(this.DOANCHUYENMON7DataSet1.gvgiohang5, Convert.ToInt32(mahd));
            // TODO: This line of code loads data into the 'HDBHtheoma.gvgiohang1' table. You can move, or remove it, as needed.
            //  this.gvgiohang1TableAdapter.Fill(this.HDBHtheoma.gvgiohang1,Convert.ToInt32(mahd));


            this.reportViewer1.RefreshReport();
        }
    }
}
