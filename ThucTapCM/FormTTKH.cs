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
    public partial class FormTTKH : Form
    {
        public FormTTKH()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {


        }
        void loaddata()
        {/*
            string query = "select MaKH N'Mã KH' , TenKH N'Tên KH' ,DiemTichLuy N'Điểm tích lũy' ,DiaChi N'Địa chỉ',SoDienThoai N'Số điện thoại',Gmail , TenLKH N'Loại Khách Hàng' from KhachHang left join LoaiKH on KhachHang.MaLKH = LoaiKH.MaLKH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            DataGKH.DataSource = result;
*/
        }
    }
}
