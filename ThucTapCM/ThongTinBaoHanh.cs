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
        public ThongTinBaoHanh()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            String query = "execute BangBH ";
            DataTable HD = DataProvider.Instance.ExecuteQuery(query);
            int tgbh = int.Parse(HD.Rows[0]["ThoiGianBH"].ToString());
            DateTime ngayxuat = DateTime.Parse(HD.Rows[0]["NgayXuat"].ToString());
            if(Convert.ToInt32( tgbh.ToString())<12)
            {
                DateTime aDateTime = Convert.ToDateTime(ngayxuat.ToString());
                DateTime newtime = aDateTime.AddMonths(+Convert.ToInt32(tgbh.ToString()));
            }  
            if(Convert.ToInt32(tgbh.ToString()) >= 12)
            {
                int a = Convert.ToInt32(tgbh.ToString()) / 12;
                int b = Convert.ToInt32(tgbh.ToString()) % 12;
                DateTime aDateTime = Convert.ToDateTime(ngayxuat.ToString());
                DateTime newtime = aDateTime.AddMonths(+Convert.ToInt32(a));
                         newtime = aDateTime.AddYears(+Convert.ToInt32(b));
            }

            string UDTGBH = "execute udtgbh @mahd , @masp , @mach ,@mamau  ,@tg ";
            DataProvider.Instance.ExecuteNonQuery(UDTGBH, new object[] { });
        }
    }
}
