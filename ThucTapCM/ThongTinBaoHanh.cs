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
    public partial class ThongTinBaoHanh : Form
    {
        int MaHDBH = HBBanHang.MHDBH;
        public ThongTinBaoHanh()
        {
            InitializeComponent();
            load();
        }
        DateTime newtime;
        void load()
        {
          

        }
    }
}
