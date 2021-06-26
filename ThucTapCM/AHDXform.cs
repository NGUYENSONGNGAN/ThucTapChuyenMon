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
    public partial class AHDXform : Form
    {
        int mahd = HBBanHang.MHDBH;
        public AHDXform()
        {
            InitializeComponent();
        }

        private void AHDXform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HDBHtheoma.gvgiohang1' table. You can move, or remove it, as needed.
            this.gvgiohang1TableAdapter.Fill(this.HDBHtheoma.gvgiohang1,Convert.ToInt32(mahd));

            this.reportViewer1.RefreshReport();
        }
    }
}
