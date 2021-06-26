using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCM.DAO
{
    class KhachHang
    {
        private static KhachHang instance;

        public static KhachHang Instance
        {
            get { if (instance == null) instance = new KhachHang(); return instance; }

            private set { instance = value; }
        }
        private KhachHang ()
        {

        }
    }
}
