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
    public partial class DSchayhang : Form
    {
        public DSchayhang()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DSchayhang_Load(object sender, EventArgs e)
        {
            string query = "execute soluongton";
            DataTable ds = DataProvider.Instance.ExecuteQuery(query);
            gvchayhang.DataSource = ds;
            
        }

        private void gvchayhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
