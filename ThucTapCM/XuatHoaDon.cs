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
using System.Data.SqlClient;

namespace ThucTapCM
{
    public partial class XuatHoaDon : Form
    {
        int MHDB = FromThanhToanHDX.MHDB;
        
      
        public XuatHoaDon( )
        {
            
            InitializeComponent();

           //anh vũ cái của anh có cái này này, cái nãy a nói đó
        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DOANCHUYENMON7DataSet3.areporthdx' table. You can move, or remove it, as needed.
            //this.areporthdxTableAdapter.Fill(this.DOANCHUYENMON7DataSet3.areporthdx);
            // TODO: This line of code loads data into the 'DOANCHUYENMON1DataSet.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.DOANCHUYENMON1DataSet.SanPham);
            // TODO: This line of code loads data into the 'DOANCHUYENMON7DataSet.HDBH_SP' table. You can move, or remove it, as needed.
            this.HDBH_SPTableAdapter.Fill(this.DOANCHUYENMON7DataSet.HDBH_SP);
            


            //////////////
            ///




            string _MaHD = Convert.ToString(MHDB);

            

            string NV = "Select GhiChu , TongTien,NgayXuat,MaKH,MaNV from HoaDonBanHang where MaHD = '" + Convert.ToInt32(MHDB) + "'";
            DataTable ttbh = DataProvider.Instance.ExecuteQuery(NV);

            string ghichu1 = Convert.ToString(ttbh.Rows[0]["GhiChu"].ToString());
            string  _ghichu = ghichu1.ToString();

            double tongtien1 = Convert.ToDouble(ttbh.Rows[0]["TongTien"].ToString());
            string  _tongtien = Convert.ToString( tongtien1.ToString());

            DateTime ngayxuat  = Convert.ToDateTime(ttbh.Rows[0]["NgayXuat"].ToString());
           string  _Date = Convert.ToString(ngayxuat.ToString());

            int MKH = Convert.ToInt32(ttbh.Rows[0]["MaKH"].ToString());
            string KH = "Select TenKH from KhachHang where MaKH = '" + Convert.ToInt32(MKH.ToString()) + "'";
            DataTable tenkh = DataProvider.Instance.ExecuteQuery(KH);
            string Tenkh = Convert.ToString(tenkh.Rows[0]["TenKH"].ToString());
            string _KhachHang = tenkh.ToString();

            int MNV = Convert.ToInt32(ttbh.Rows[0]["MaNV"].ToString());
            string nhanvien = "Select TenNV from NhanVien where MaNV = '" + Convert.ToInt32(MNV.ToString()) + "'";
            DataTable tennv = DataProvider.Instance.ExecuteQuery(nhanvien);
            string tenvn = tennv.Rows[0]["TenNV"].ToString();
            string _Nhanvien = Convert.ToString(tenvn);



            //////////

            this.reportViewer3.RefreshReport();
            new Microsoft.Reporting.WinForms.ReportParameter("MaHD", _MaHD);
            /*  new Microsoft.Reporting.WinForms.ReportParameter("Date", _Date);
              new Microsoft.Reporting.WinForms.ReportParameter("Khachhang", _KhachHang);
              new Microsoft.Reporting.WinForms.ReportParameter("GhiChu", _ghichu);
              new Microsoft.Reporting.WinForms.ReportParameter("Tongtien", _tongtien);
              new Microsoft.Reporting.WinForms.ReportParameter("NhanVien", _Nhanvien);*/

        }
        void dulieu()
        {
           
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {

        }
    }
}
