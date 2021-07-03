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
using System.Globalization;

namespace ThucTapCM
{
    public partial class HoaDonNhapHang : Form
    {
        public HoaDonNhapHang()
        {
            InitializeComponent();
            load();
            loadcombocox();
        }
        int i = 0;
        CultureInfo culture = new CultureInfo("vi-VN");
        int MNV = txtPassWord.id;
        private void picNCC_Click(object sender, EventArgs e)
        {
            FormTTNCC tTNCC = new FormTTNCC();
            this.Hide();
            tTNCC.Show();
        }
        void load()
        {
            string query = " select Max(MaHDN) from HDNhapHang";
            int MHD = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());

            if (MHD == 0)
            {
                lbMHD.Text = "1";
            }
            else if (MHD != 0)
            {
                lbMHD.Text = Convert.ToString(Convert.ToInt32(MHD.ToString()) + 1);
                // int a = Convert.ToInt32()
            }

            gvSeachHD.Visible = false;
            lbsoluong.ResetText();
            lbdongia.ResetText();
            string giohang = "execute gvgiohangnhap1 @ma ";
            DataTable giohangnhap = DataProvider.Instance.ExecuteQuery(giohang, new object[] { Convert.ToInt32(lbMHD.Text) });
            gvHDNH.DataSource = giohangnhap;
            btnDelete.Enabled = false;
        }
        void loadcombocox()
        {
            string query = "select TenNCC,MaNCC from NhaCungCap";
            DataTable NCC = DataProvider.Instance.ExecuteQuery(query);

            cbxNCC.DisplayMember = "TenNCC";
            cbxNCC.ValueMember = "MaNCC";
            cbxNCC.DataSource = NCC;

            string query1 = "select TenSp , MaSP from SanPham";
            DataTable SP1 = DataProvider.Instance.ExecuteQuery(query1);

            cbxSanPham.DisplayMember = "TenSp";
            cbxSanPham.ValueMember = "MaSP";
            cbxSanPham.DataSource = SP1;


            string query2 = "execute CH6 @ma ";
            DataTable CH1 = DataProvider.Instance.ExecuteQuery(query2, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue) });
            cbxCauHinh.DisplayMember = "TenCauHinh";
            cbxCauHinh.ValueMember = "MaCauHinh";
            cbxCauHinh.DataSource = CH1;

            string query3 = " execute selectcbxmau @maSP , @maCH ";
            DataTable mau = DataProvider.Instance.ExecuteQuery(query3, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue) }); cbxMauSac.DisplayMember = "TenMau";
            cbxMauSac.ValueMember = "MaMau";
            cbxMauSac.DataSource = mau;
        }

        private void cbxNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxNCC.SelectedValue == null)
            {
                string minncc = "select MIN(MaNCC) from NhaCungCap";
                int a = int.Parse(DataProvider.Instance.ExecuteScalar(minncc).ToString());

                string ttncc = "select Diachi,SoDienThoai from NhaCungCap where MaNCC= '" + a + "'";
                DataTable TTNCC = DataProvider.Instance.ExecuteQuery(ttncc);
                lbAdressNCC.Text = Convert.ToString(TTNCC.Rows[0]["Diachi"].ToString());
                lbSĐT.Text = Convert.ToString(TTNCC.Rows[0]["SoDienThoai"].ToString());

            }
            else if (cbxNCC.SelectedValue != null)
            {
                string ttncc = "select Diachi,SoDienThoai from NhaCungCap where MaNCC= '" + Convert.ToInt32(cbxNCC.SelectedValue) + "'";
                DataTable TTNCC = DataProvider.Instance.ExecuteQuery(ttncc);
                lbAdressNCC.Text = Convert.ToString(TTNCC.Rows[0]["Diachi"].ToString());
                lbSĐT.Text = Convert.ToString(TTNCC.Rows[0]["SoDienThoai"].ToString());
            }

        }

        private void tbseach_OnValueChanged(object sender, EventArgs e)
        {
            if (tbseach.Text == null || tbseach.Text == "")
            {

            }
            else
            {
                gvSeachHD.Visible = true;
                string query = " execute SeachSP1 @Tenma";
                DataTable seach = DataProvider.Instance.ExecuteQuery(query, new object[] { tbseach.Text });
                gvSeachHD.DataSource = seach;
                //gvSeachHD.FirstDisplayedScrollingColumnIndex = gvSeachHD.Rows.Count - 1;

            }
        }

        private void gvSeachHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvSeachHD.CurrentRow.Index;
            cbxSanPham.Text = gvSeachHD.Rows[r].Cells[1].Value.ToString();
            gvSeachHD.Visible = false;
        }


        private void cbxSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                i++;


                if (cbxSanPham.SelectedValue == null)
                {


                    string query = "select Min(MaSP) from SanPham";
                    int a = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());
                    cbxSanPham.SelectedValue = Convert.ToInt32(a.ToString());

                    string query2 = "execute CH6 @ma ";
                    DataTable CH = DataProvider.Instance.ExecuteQuery(query2, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue) });
                    cbxCauHinh.DisplayMember = "TenCauHinh";
                    cbxCauHinh.ValueMember = "MaCauHinh";
                    cbxCauHinh.DataSource = CH;

                    string query3 = " execute selectcbxmau @maSP , @maCH ";
                    DataTable mau = DataProvider.Instance.ExecuteQuery(query3, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue) });
                    cbxMauSac.DisplayMember = "TenMau";
                    cbxMauSac.ValueMember = "MaMau";
                    cbxMauSac.DataSource = mau;
                }

                else
                {
                    string query2 = "execute CH6 @ma ";
                    DataTable CH = DataProvider.Instance.ExecuteQuery(query2, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue) });
                    cbxCauHinh.DisplayMember = "TenCauHinh";
                    cbxCauHinh.ValueMember = "MaCauHinh";
                    cbxCauHinh.DataSource = CH;

                    string query3 = " execute selectcbxmau @maSP , @maCH ";
                    DataTable mau = DataProvider.Instance.ExecuteQuery(query3, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue) });
                    cbxMauSac.DisplayMember = "TenMau";
                    cbxMauSac.ValueMember = "MaMau";
                    cbxMauSac.DataSource = mau;
                }
            }
            catch (Exception)
            {

            }
        }

        private void cbxCauHinh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCauHinh.SelectedValue != null)
            {
                string query3 = " execute selectcbxmau @maSP , @maCH ";
                DataTable mau = DataProvider.Instance.ExecuteQuery(query3, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue) });
                cbxMauSac.DisplayMember = "TenMau";
                cbxMauSac.ValueMember = "MaMau";
                cbxMauSac.DataSource = mau;
            }


        }
        private void lbsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void lbsoluong_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbdongia.Text.Trim() == "" || lbdongia.Text == null || Convert.ToInt32(lbdongia.Text) == 0)
                {
                    lbThanhTien.Text = "0";
                }
                else
                {
                    lbThanhTien.Text = (Convert.ToInt32(lbsoluong.Text) * Convert.ToInt32(lbdongia.Text)).ToString("N0", culture);
                }
            }

            catch (Exception)
            {

            }
        }

        private void lbdongia_OnValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (lbsoluong.Text.Trim() == "" || lbsoluong.Text == null || Convert.ToInt32(lbsoluong.Text) == 0)
                {
                    lbThanhTien.Text = "0";
                }
                else
                {
                    lbThanhTien.Text = (Convert.ToInt32(lbsoluong.Text) * Convert.ToInt32(lbdongia.Text)).ToString("N0", culture);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            string HDN = "select * from HDNhapHang where MaHDN = '" + Convert.ToInt32(lbMHD.Text) + "'";
            DataTable tbHDN = DataProvider.Instance.ExecuteQuery(HDN);
            if (lbdongia.Text.Trim() == "" || lbsoluong.Text.Trim() == "" || Convert.ToInt32(cbxSanPham.SelectedValue) == 0 ||
                Convert.ToInt32(cbxCauHinh.SelectedValue) == 0 || Convert.ToInt32(cbxMauSac.SelectedValue) == 0)
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin", "Error");
            }
            else if (Convert.ToInt32(lbdongia.Text) == 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Error");
            }
            else if (Convert.ToInt32(lbsoluong.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Error");
            }
            else if (tbHDN.Rows.Count <= 0)
            {
                string inserintoHDN = "execute insertHDN @ma , @mancc , @manv , @ngaynhap , @tongtien , @Soluongnhap ";
                DataProvider.Instance.ExecuteNonQuery(inserintoHDN, new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxNCC.SelectedValue), MNV, Convert.ToDateTime(DateTime.Now), 0, 0 });

                string inserintoHDN_SP = "execute insertHDN_SP1 @ma , @mansp , @macauhinh , @mamau , @soluong , @dongia , @thanhtien ";
                DataProvider.Instance.ExecuteNonQuery(inserintoHDN_SP, new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                               Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbsoluong.Text), Convert.ToInt32(lbdongia.Text), Convert.ToInt32(lbsoluong.Text) * Convert.ToInt32(lbdongia.Text) });

                string updatetongtienHDN = "execute updatetongtienHDN @mahdn , @tongtien ";
                DataProvider.Instance.ExecuteNonQuery(updatetongtienHDN, new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(lbsoluong.Text) * Convert.ToInt32(lbdongia.Text) });

                string updatesoluongHDN = "execute updatesoluongHDN @mahdn , @soluong ";
                DataProvider.Instance.ExecuteNonQuery(updatesoluongHDN, new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(lbsoluong.Text) });

                string CTSPF = "execute CTSP @masp , @macauhinh , @mamau ";
                DataTable CTSPFIN = DataProvider.Instance.ExecuteQuery(CTSPF, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                if (CTSPFIN.Rows.Count <= 0)
                {
                    string insertCTSP = "execute insertCTSP1 @mansp , @macauhinh , @mamau , @soluong ";
                    DataProvider.Instance.ExecuteNonQuery(insertCTSP, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbsoluong.Text) });
                }
                else if (CTSPFIN.Rows.Count >= 1)
                {

                    string udatesoluongCTSP = "execute updateSLT @maSP , @macauhinh , @maMau , @soluong ";
                    DataProvider.Instance.ExecuteNonQuery(udatesoluongCTSP, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue), (Convert.ToInt32(lbsoluong.Text) + Convert.ToInt32(CTSPFIN.Rows[0]["SoLuong"].ToString())) });
                }

                MessageBox.Show("Add Success !", "Success");

                string giohang = "execute gvgiohangnhap1 @ma ";
                DataTable giohangnhap = DataProvider.Instance.ExecuteQuery(giohang, new object[] { Convert.ToInt32(lbMHD.Text) });
                gvHDNH.DataSource = giohangnhap;
                loadcombocox();
                lbsoluong.ResetText();
                lbdongia.ResetText();
                lbThanhTien.Text = "0";

            }
            else if (tbHDN.Rows.Count >= 1)
            {
                string HDNH_SP = "select * from HDNH_SP where MaHDN = '" + Convert.ToInt32(lbMHD.Text) + "'";
                DataTable HDNH_SPtb = DataProvider.Instance.ExecuteQuery(HDNH_SP);
                if (HDNH_SPtb.Rows.Count <= 0)
                {
                    //themhang
                    string inserintoHDN_SP = "execute insertHDN_SP1 @ma , @mansp , @macauhinh , @mamau , @soluong , @dongia , @thanhtien ";
                    DataProvider.Instance.ExecuteNonQuery(inserintoHDN_SP, new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                               Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbsoluong.Text), Convert.ToInt32(lbdongia.Text),Convert.ToInt32(lbsoluong.Text) * Convert.ToInt32(lbdongia.Text) });
                    //udtien
                    String query = "execute updatetien3 @mahdx ";
                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMHD.Text) });
                    //udsoluong
                    String querySL = "execute updatesoluong3 @mahdx ";
                    DataProvider.Instance.ExecuteNonQuery(querySL, new object[] { Convert.ToInt32(lbMHD.Text) });
                    //udCT

                    string CTSPF = "execute CTSP @masp , @macauhinh , @mamau ";
                    DataTable CTSPFIN = DataProvider.Instance.ExecuteQuery(CTSPF, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                    if (CTSPFIN.Rows.Count <= 0)
                    {
                        string insertCTSP = "execute insertCTSP1 @mansp , @macauhinh , @mamau , @soluong ";
                        DataProvider.Instance.ExecuteNonQuery(insertCTSP, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbsoluong.Text) });
                    }
                    else if (CTSPFIN.Rows.Count >= 1)
                    {

                        string udatesoluongCTSP = "execute updateSLT @maSP , @macauhinh , @maMau , @soluong ";
                        DataProvider.Instance.ExecuteNonQuery(udatesoluongCTSP, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue), (Convert.ToInt32(lbsoluong.Text) + Convert.ToInt32(CTSPFIN.Rows[0]["SoLuong"].ToString())) });
                    }

                    string giohang = "execute gvgiohangnhap1 @ma ";
                    DataTable giohangnhap = DataProvider.Instance.ExecuteQuery(giohang, new object[] { Convert.ToInt32(lbMHD.Text) });
                    gvHDNH.DataSource = giohangnhap;
                    loadcombocox();
                    lbsoluong.ResetText();
                    lbdongia.ResetText();
                    lbThanhTien.Text = "0";
                }

                else if (HDNH_SPtb.Rows.Count >= 1)
                {
                    string HDN1 = "Execute selectHDBHSP @mahdn , @masp , @macauhinh , @mamau ";
                    DataTable HDNLHD1 = DataProvider.Instance.ExecuteQuery(HDN1, new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                    if (HDNLHD1.Rows.Count <= 0)
                    {
                        string inserintoHDN_SP = "execute insertHDN_SP1 @ma , @mansp , @macauhinh , @mamau , @soluong , @dongia , @thanhtien  ";
                        DataProvider.Instance.ExecuteNonQuery(inserintoHDN_SP, new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                               Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbsoluong.Text),Convert.ToInt32(lbdongia.Text) ,Convert.ToInt32(lbsoluong.Text) * Convert.ToInt32(lbdongia.Text) });

                        //udtien
                        String query = "execute updatetien3 @mahdx ";
                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMHD.Text) });
                        //udsoluong
                        String querySL = "execute updatesoluong3 @mahdx ";
                        DataProvider.Instance.ExecuteNonQuery(querySL, new object[] { Convert.ToInt32(lbMHD.Text) });


                        string CTSPF = "execute CTSP @masp , @macauhinh , @mamau ";
                        DataTable CTSPFIN = DataProvider.Instance.ExecuteQuery(CTSPF, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                        if (CTSPFIN.Rows.Count <= 0)
                        {
                            string insertCTSP = "execute insertCTSP1 @mansp , @macauhinh , @mamau , @soluong ";
                            DataProvider.Instance.ExecuteNonQuery(insertCTSP, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbsoluong.Text) });
                        }
                        else if (CTSPFIN.Rows.Count >= 1)
                        {

                            string udatesoluongCTSP = "execute updateSLT @maSP , @macauhinh , @maMau , @soluong ";
                            DataProvider.Instance.ExecuteNonQuery(udatesoluongCTSP, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue), (Convert.ToInt32(lbsoluong.Text) + Convert.ToInt32(CTSPFIN.Rows[0]["SoLuong"].ToString())) });
                        }

                        MessageBox.Show("Bạn đã thêm thành công");
                        string giohang = "execute gvgiohangnhap1 @ma ";
                        DataTable giohangnhap = DataProvider.Instance.ExecuteQuery(giohang, new object[] { Convert.ToInt32(lbMHD.Text) });
                        gvHDNH.DataSource = giohangnhap;
                        loadcombocox();
                        lbsoluong.ResetText();
                        lbdongia.ResetText();
                        lbThanhTien.Text = "0";
                    }
                    else if (HDNLHD1.Rows.Count >= 1)
                    {
                        string inserintoHDN_SP = "execute insertHDN_SP1 @ma , @mansp , @macauhinh , @mamau , @soluong , @dongia, @thanhtien ";
                        DataProvider.Instance.ExecuteNonQuery(inserintoHDN_SP, new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                               Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbsoluong.Text), Convert.ToInt32(lbdongia.Text),Convert.ToInt32(lbsoluong.Text) * Convert.ToInt32(lbdongia.Text) });
                        double tongtien = 0;
                        int soluong = 0;
                        /* string tinhtongtien = "select * from HDNH_SP where MaHD = '" + Convert.ToInt32(lbMHD.Text) + "'";
                         DataTable hdsp = DataProvider.Instance.ExecuteQuery(tinhtongtien);*/

                        //udtien
                        String query = "execute updatetien3 @mahdx ";
                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMHD.Text) });
                        //udsoluong
                        String querySL = "execute updatesoluong3 @mahdx ";
                        DataProvider.Instance.ExecuteNonQuery(querySL, new object[] { Convert.ToInt32(lbMHD.Text) });


                        String UDSTL = "execute updateSLT @maSP , @macauhinh , @maMau , @soluong ";
                        DataProvider.Instance.ExecuteNonQuery(UDSTL, new object[] {Convert.ToInt32(cbxSanPham.SelectedValue),
                                     Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue),
                                    (Convert.ToInt32(lbsoluong.Text) + Convert.ToInt32( Convert.ToInt32(HDNLHD1.Rows[0]["SoLuong"].ToString()))) });


                        MessageBox.Show("Bạn đã thêm số lượng thành công");
                        string giohang = "execute gvgiohangnhap1 @ma ";
                        DataTable giohangnhap = DataProvider.Instance.ExecuteQuery(giohang, new object[] { Convert.ToInt32(lbMHD.Text) });
                        gvHDNH.DataSource = giohangnhap;
                        loadcombocox();
                        lbsoluong.ResetText();
                        lbdongia.ResetText();
                        lbThanhTien.Text = "0";
                    }
                }

            }

        }

        string sanpham;
        string cauhinh;
        string mausac;
        string soluong;

        private void gvHDNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvHDNH.CurrentRow.Index;
            sanpham = gvHDNH.Rows[r].Cells[0].Value.ToString();
            cauhinh = gvHDNH.Rows[r].Cells[1].Value.ToString();
            mausac = gvHDNH.Rows[r].Cells[2].Value.ToString();
            soluong=gvHDNH.Rows[r].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Delete", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                string masp = "select MaSP from SanPham  where TenSp =N'" + Convert.ToString(sanpham.Trim()) + "'";
                DataTable xmasp = DataProvider.Instance.ExecuteQuery(masp);
                Console.WriteLine(xmasp.Rows.Count);
                int ma = Convert.ToInt32(xmasp.Rows[0]["MaSP"].ToString());

                string mach = "select MaCauHinh from SP_CauHinh where TenCauHinh =N'" + Convert.ToString(cauhinh.Trim()) + "'";
                DataTable xmach = DataProvider.Instance.ExecuteQuery(mach);
                int maCH = Convert.ToInt32(xmach.Rows[0]["MaCauHinh"].ToString());

                string mamau = "select MaMau from SP_Mau where TenMau =N'" + Convert.ToString(mausac.Trim()) + "'";
                DataTable xmamau = DataProvider.Instance.ExecuteQuery(mamau);
                int maMau = Convert.ToInt32(xmamau.Rows[0]["MaMau"].ToString());

                string deletegiohangN = "execute deletegiohangnhap1 @mahd , @masp , @macauhinh , @mamau ";
                DataProvider.Instance.ExecuteNonQuery(deletegiohangN, new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(ma.ToString()), Convert.ToInt32(maCH.ToString()), Convert.ToInt32(maMau.ToString()) });

                MessageBox.Show("Delete Success !", "Success");

                //ud slt

                string giohang = "execute gvgiohangnhap1 @ma ";
                DataTable giohangnhap = DataProvider.Instance.ExecuteQuery(giohang, new object[] { Convert.ToInt32(lbMHD.Text) });
                gvHDNH.DataSource = giohangnhap;
                loadcombocox();
                lbsoluong.ResetText();
                lbdongia.ResetText();
                lbThanhTien.Text = "0";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void HoaDonNhapHang_Load(object sender, EventArgs e)
        {
            /*pnsphet.Visible = false;
            DSchayhang dSchayhang = new DSchayhang();
            dSchayhang.Show();*/
            DSchayhang dSchayhang = new DSchayhang();
            dSchayhang.TopLevel = false;
            pnsphet.Controls.Add(dSchayhang);
            dSchayhang.Dock = DockStyle.Fill;
            dSchayhang.Show();
        }
        int a = 0;
        private void btnsphet_Click(object sender, EventArgs e)
        {
            a++;

            if (a % 2 != 0)
            {

                pnsphet.Visible = false;

            }
            else
            {
                pnsphet.Visible = true;

            }

        }

        private void lbsoluong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbdongia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
