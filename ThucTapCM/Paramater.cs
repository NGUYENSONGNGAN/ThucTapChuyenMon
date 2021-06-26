using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTapCM.DAO;
using System.Data.SqlClient;

namespace ThucTapCM
{
   
    public class Paramater
    {
        int MHDB = HBBanHang.MHDBH;

        public int Mahd { get; set; }
        public string TenKH { get; set; }

        public string TenNV { get; set; }

        public DateTime Ngay { get; set; }
        public string ghichu { get; set; }

        public float tongtien { get; set; }

    }
}
