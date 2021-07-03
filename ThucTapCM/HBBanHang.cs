using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapCM.DAO;
using System.Globalization;
using System.IO;
using System.Data.SqlClient;

namespace ThucTapCM
{
    public partial class HBBanHang : Form
    {
        int MKHM = CreateCurtomer.MKHM;
        int MKHC = CurtomerCheck.MKH;
        int i = 0;
        int MKH =0 ;
        float dongia;
        public static int MHDBH;
        public static MemoryStream stream;
        CultureInfo culture = new CultureInfo("vi-VN");
        public HBBanHang()
        {
            InitializeComponent();
             
            loadcombocox();
            loaddata();
        }

        public HBBanHang(int ma)
        {
            this.MKH = ma;
            InitializeComponent();

            loadcombocox();
            loaddata();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void loaddata()
        {
            string query = "select Max(MaHD) from HoaDonBanHang";
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
            MHDBH = Convert.ToInt32(lbMHD.Text);
            

            string query1 = "execute selectKHHD1 '" + MKH + "'";
            DataTable name1 = DataProvider.Instance.ExecuteQuery(query1);
            string name = name1.Rows[0]["TenKH"].ToString();
            lbNameKH.Text = name.ToString();

            string query2 = "execute selectKHHD2 '" + MKH + "'";
            DataTable DiemTichLuy1 = DataProvider.Instance.ExecuteQuery(query2);
            string DiemTichLuy = DiemTichLuy1.Rows[0]["DiemTichLuy"].ToString();
            lbDTL.Text = DiemTichLuy;


            string query3 = "execute selectKHHD3 '" + MKH + "'";
            DataTable loaikhachhang1 = DataProvider.Instance.ExecuteQuery(query3);
            string loaikhachhang = loaikhachhang1.Rows[0]["TenLKH"].ToString();
            lbLKH.Text = loaikhachhang;

            btnThanhToan.Enabled = false;
            gvSeachHD.Visible = false;

            string querygvm = "execute gvgiohang1 @ma ";
            DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
            gvHDBH.DataSource = gvgiohang;

            lbTongtien.Text = "0";
        }

        private void HBBanHang_Load(object sender, EventArgs e)
        {
           

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == null || bunifuMetroTextbox1.Text == "")
            {
               
            }
            else
            {
                gvSeachHD.Visible = true;
                string query = " execute SeachSP1 @Tenma";
                DataTable seach = DataProvider.Instance.ExecuteQuery(query, new object[] { bunifuMetroTextbox1.Text });
                gvSeachHD.DataSource = seach;
                //gvSeachHD.FirstDisplayedScrollingColumnIndex = gvSeachHD.Rows.Count - 1;

            }
        }

        private void gvSeachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvSeachHD.CurrentRow.Index;
            cbxSanPham.Text = gvSeachHD.Rows[r].Cells[1].Value.ToString();
            gvSeachHD.Visible = false;
            
            
        }
        void loadcombocox()
        {



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
        void hienthitongtien()
        {
            string lbtongtien = "select * from HoaDonBanHang where MaHD = '" + Convert.ToInt32(lbMHD.Text) + "'";
            DataTable tongtienlb = DataProvider.Instance.ExecuteQuery(lbtongtien);

            if (tongtienlb.Rows.Count <= 0)
            {
                lbTongtien.Text = "0";
            }
            else if (tongtienlb.Rows.Count >= 1)
            {
                double tienhienthi = Convert.ToDouble(tongtienlb.Rows[0]["TongTien"].ToString());
                lbTongtien.Text = tienhienthi.ToString("N0", culture);
            }

        }
        private void cbxSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                i++;
                

                if (cbxSanPham.SelectedValue ==null)
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


                    string query6 = "execute CTSanpham1 @masp , @macauhinh , @mamau ";
                    DataTable soluongData = DataProvider.Instance.ExecuteQuery(query6, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                    int soluong = Convert.ToInt32(soluongData.Rows[0].ItemArray[0].ToString());
                    if (soluong == 0)
                    {
                        lbHangton.Text = "0";
                    }
                    else
                    {
                        //int slt = Convert.ToInt32(soluong);
                        lbHangton.Text = soluong.ToString();

                    }



                }
                else
                {
                    string query2 = "Select MaLSP from SanPham Where MaSP ='" + cbxSanPham.SelectedValue +"'";
                    int spl = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query2).Rows[0].ItemArray[0].ToString());
                    if (i != 1)
                    {
                        string query4 = "execute CH6 @ma ";
                        DataTable CH = DataProvider.Instance.ExecuteQuery(query4, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue) });
                        cbxCauHinh.DisplayMember = "TenCauHinh";
                        cbxCauHinh.ValueMember = "MaCauHinh";
                        cbxCauHinh.DataSource = CH;

                        string query3 = " execute selectcbxmau @maSP , @maCH ";
                        DataTable mau = DataProvider.Instance.ExecuteQuery(query3, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue) });
                        cbxMauSac.DisplayMember = "TenMau";
                        cbxMauSac.ValueMember = "MaMau";
                        cbxMauSac.DataSource = mau;


                        string query8 = "execute CTSanpham1 @masp , @macauhinh , @mamau ";
                        DataTable soluongData = DataProvider.Instance.ExecuteQuery(query8, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                        int soluong = Convert.ToInt32(soluongData.Rows[0].ItemArray[0].ToString());
                        if (soluong == 0)
                        {
                            lbHangton.Text = "0";
                        }
                        else
                        {
                            //int slt = Convert.ToInt32(soluong);
                            lbHangton.Text = soluong.ToString();

                        }
                    }
                        string query5 = "Select DonGia from SanPham Where MaSP ='" + cbxSanPham.SelectedValue + "'";
                        float Dongia = int.Parse(DataProvider.Instance.ExecuteScalar(query5).ToString());
                        dongia = Dongia;
                        lbDonGia.Text = dongia.ToString("N0", culture);

                   /* 

                    string query6 = "execute CTSanpham1 @masp , @macauhinh , @mamau ";
                    if(cbxMauSac.Items.Count > 0)
                    {
                        DataTable soluongData = DataProvider.Instance.ExecuteQuery(query6, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                        int soluong = Convert.ToInt32(soluongData.Rows[0].ItemArray[0].ToString());
                      
                        
                        if (soluong == 0)
                        {
                            lbHangton.Text = "0";
                        }
                        else
                        {
                            //int slt = Convert.ToInt32(soluong);
                            lbHangton.Text = soluong.ToString("N0", culture);
                           
                        }
                    }*/
                    

                }
                
            }
            catch (Exception)
            {

            }
        }

        private void cbxCauHinh_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                string query3 = " execute selectcbxmau @maSP , @maCH ";
                DataTable mau = DataProvider.Instance.ExecuteQuery(query3, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue) });
                cbxMauSac.DisplayMember = "TenMau";
                cbxMauSac.ValueMember = "MaMau";
                cbxMauSac.DataSource = mau;

                txtSoLuong.ResetText();
                //lbDonGia.Text = "0";//t mới set thêm 2 cobobox mà nó vẫn không được 
                string query6 = "execute CTSanpham1 @masp , @macauhinh , @mamau ";
                DataTable soluongData = DataProvider.Instance.ExecuteQuery(query6, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                int soluong = Convert.ToInt32(soluongData.Rows[0].ItemArray[0].ToString());
                if (soluong == 0)
                {
                    lbHangton.Text = "0";
                }
                else
                {
                    //int slt = Convert.ToInt32(soluong);
                    lbHangton.Text = soluong.ToString();

                }
            }
            catch (Exception)
            {

            }
        }

        private void cbxMauSac_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.ResetText();
                //lbDonGia.Text = "0";
                string query6 = "execute CTSanpham1 @masp , @macauhinh , @mamau ";
                DataTable soluongData = DataProvider.Instance.ExecuteQuery(query6, new object[] { Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                int soluong = Convert.ToInt32(soluongData.Rows[0].ItemArray[0].ToString());
                if (soluong == 0)
                {
                    lbHangton.Text = "0";
                }
                else
                {
                    //int slt = Convert.ToInt32(soluong);
                    lbHangton.Text = soluong.ToString();

                }

            }
            catch (Exception)
            {

            }
        }

        private void txtSoLuong_OnValueChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Text != "")
            {
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                double dongia = Convert.ToDouble(lbDonGia.Text.Replace(".", ""));
                lbDonGia.Text = (soluong * dongia).ToString("N0", culture);
            }
            else
            {
                string query4 = "Select DonGia from SanPham Where MaSP ='" + cbxSanPham.SelectedValue + "'";
                float dongia = int.Parse(DataProvider.Instance.ExecuteScalar(query4).ToString());
                //dongia = sp.DonGia;
                lbDonGia.Text = dongia.ToString("N0", culture);
            }
            
        }
        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim() == null || txtSoLuong.Text.Trim() == "")
            {

            }
            else if (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(lbHangton.Text))
            {
                MessageBox.Show("Số lượng bạn cần không đủ vui lòng nhập lại!");
                txtSoLuong.ResetText();
            }

        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim() == "" || txtSoLuong.Text == null || Convert.ToInt32(txtSoLuong.Text) == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng", "Lỗi");
            }
            else if (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(lbHangton.Text))
            {
                //đã xử lý sự kiện trong textleave
                txtSoLuong.Focus();
            }
            else
            {
                //var HDX = dt.selectTTHDX(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();v
                string query = " select MaHD from HoaDonBanHang where MaHD ='" +Convert.ToInt32( lbMHD.Text) + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                string query4 = "Select DonGia from SanPham Where MaSP ='" + cbxSanPham.SelectedValue + "'";
                float dongia = int.Parse(DataProvider.Instance.ExecuteScalar(query4).ToString());
                if (data.Rows.Count == 0)
                {
                    Image QR;
                    Zen.Barcode.CodeQrBarcodeDraw qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                    QR = qr.Draw(lbMHD.Text, 50);
                    MemoryStream stream = new MemoryStream();
                    QR.Save(stream, ImageFormat.Jpeg);

                    string queryinsertHDBH = "execute insertHoDonBH @mahd , @ngayxuat , @maqr , @makh , @manv ";
                    DataProvider.Instance.ExecuteNonQuery(queryinsertHDBH, new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToDateTime(DateTime.Now), stream.ToArray(), MKH, txtPassWord.id });

                    string queryHDBT_SP = "insertHDBH_SP1 @mahd , @masp , @macauhinh , @mamau , @soluong , @thanhtien ";
                    DataProvider.Instance.ExecuteNonQuery(queryHDBT_SP, new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue),Convert.ToInt32(cbxCauHinh.SelectedValue),

                                    Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(txtSoLuong.Text), dongia * Convert.ToInt32(txtSoLuong.Text)});
                    //udtien
                    String queryUDTT = "execute UpdateHDBHTT @ma , @tongtien ";
                    DataProvider.Instance.ExecuteNonQuery(queryUDTT, new object[] { Convert.ToInt32(lbMHD.Text), dongia * Convert.ToInt32(txtSoLuong.Text) });


                    //udslton
                    string queryUDSLT = "execute UpdateSLTCTSP1 @masp , @macauhinh , @mamau  , @soluong ";
                    DataProvider.Instance.ExecuteNonQuery(queryUDSLT, new object[] {Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                                    Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbHangton.Text) - Convert.ToInt32(txtSoLuong.Text)});
                    //udbaohanh
                    String UDTGBH = "execute TGBHConLai1 @mahd , @masp , @mach , @mamau ";
                    DataProvider.Instance.ExecuteNonQuery(UDTGBH,new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue),Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                    baohanh();



                    MessageBox.Show("Add Success !");

                    string querygvm = "execute gvgiohang1 @ma ";
                    DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
                    gvHDBH.DataSource = gvgiohang;
                    loadcombocox();
                    hienthitongtien();
                    
                    txtSoLuong.ResetText();
                    btnThanhToan.Enabled = true;
                    gvSeachHD.Visible = false;

                }
                if (data.Rows.Count >=1)
                {
                    string queryselectHDBH = "execute selecHDBHSP @masp , @macauhinh , @mamau , @mahd ";
                    DataTable HDBH_SP = DataProvider.Instance.ExecuteQuery(queryselectHDBH, new object[] {Convert.ToInt32(cbxSanPham.SelectedValue),  Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbMHD.Text)});
                    
                    if (HDBH_SP.Rows.Count<=0)
                    {
                        string queryHDBT_SP = "insertHDBH_SP1 @mahd , @masp , @macauhinh , @mamau , @soluong , @thanhtien ";
                        DataProvider.Instance.ExecuteNonQuery(queryHDBT_SP, new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue),Convert.ToInt32(cbxCauHinh.SelectedValue),

                                    Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(txtSoLuong.Text), dongia * Convert.ToInt32(txtSoLuong.Text)});
                        //UDtongtienHD
                       

                        String queryUDTT = "execute updatetien2 @mahdx ";
                        DataProvider.Instance.ExecuteNonQuery(queryUDTT, new object[] { Convert.ToInt32(lbMHD.Text)});

                        //UDSLT
                        string queryUDSLT = "execute UpdateSLTCTSP1 @masp , @macauhinh , @mamau  , @soluong ";
                        DataProvider.Instance.ExecuteNonQuery(queryUDSLT, new object[] {Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                                    Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbHangton.Text) - Convert.ToInt32(txtSoLuong.Text)});
                        //tgbh
                        String UDTGBH = "execute TGBHConLai1 @mahd , @masp , @mach , @mamau ";
                        DataProvider.Instance.ExecuteNonQuery(UDTGBH, new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue), Convert.ToInt32(cbxMauSac.SelectedValue) });
                        baohanh();

                        string querygvm = "execute gvgiohang1 @ma ";    
                        DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
                        gvHDBH.DataSource = gvgiohang;
                        loadcombocox();
                        hienthitongtien();
                        txtSoLuong.ResetText();
                        btnThanhToan.Enabled = true;
                        gvSeachHD.Visible = false;
                        MessageBox.Show("Add product success!");

                    }

                    else if(HDBH_SP.Rows.Count >=1)
                    {
                        string UDSLHDBHSP = "execute updateSoLuongTTCTHDX1 @mahdx , @masp , @macauhinh , @mamau , @soluong , @thanhtien ";
                        DataProvider.Instance.ExecuteNonQuery(UDSLHDBHSP,new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(cbxSanPham.SelectedValue),Convert.ToInt32(cbxCauHinh.SelectedValue),

                                    Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(txtSoLuong.Text), dongia * Convert.ToInt32(txtSoLuong.Text)});

                        //UDTienHD
                        String queryUDTT = "execute updatetien2 @mahdx ";
                        DataProvider.Instance.ExecuteNonQuery(queryUDTT, new object[] { Convert.ToInt32(lbMHD.Text) });
                        //UDSLTON
                        string queryUDSLT = "execute UpdateSLTCTSP1 @masp , @macauhinh , @mamau  , @soluong ";
                        DataProvider.Instance.ExecuteNonQuery(queryUDSLT, new object[] {Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                                    Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbHangton.Text) - Convert.ToInt32(txtSoLuong.Text)});
                      
                        string querygvm = "execute gvgiohang1 @ma ";
                        DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
                        gvHDBH.DataSource = gvgiohang;
                        loadcombocox();
                        hienthitongtien();
                        txtSoLuong.ResetText();
                        btnThanhToan.Enabled = true;
                        gvSeachHD.Visible = false;
                        MessageBox.Show("Add amount product success!");

                    }    
                }    
            }

        }

        string ten;
        string cauhinh;
        string mausac;
        string soluong;
        private void gvHDBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvHDBH.CurrentRow.Index;
            ten = gvHDBH.Rows[r].Cells[0].Value.ToString();
            cauhinh = gvHDBH.Rows[r].Cells[1].Value.ToString();
            mausac = gvHDBH.Rows[r].Cells[2].Value.ToString();
            soluong = gvHDBH.Rows[r].Cells[3].Value.ToString();
        }

        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            DialogResult xoaCTHDX = MessageBox.Show("Bạn có muốn xóa không ???", "Xóa", MessageBoxButtons.YesNo);
            if (xoaCTHDX == DialogResult.Yes)
            {
                //delete
                string masp = "select MaSP from SanPham  where TenSp =N'" + Convert.ToString(ten.Trim()) + "'";
                DataTable xmasp = DataProvider.Instance.ExecuteQuery(masp);
                Console.WriteLine(xmasp.Rows.Count);
                int ma = Convert.ToInt32(xmasp.Rows[0]["MaSP"].ToString());

                string mach = "select MaCauHinh from SP_CauHinh where TenCauHinh =N'" + Convert.ToString(cauhinh.Trim()) + "'";
                DataTable xmach = DataProvider.Instance.ExecuteQuery(mach);
                int maCH = Convert.ToInt32(xmach.Rows[0]["MaCauHinh"].ToString());

                string mamau = "select MaMau from SP_Mau where TenMau =N'" + Convert.ToString(mausac.Trim()) + "'";
                DataTable xmamau = DataProvider.Instance.ExecuteQuery(mamau);
                int maMau = Convert.ToInt32(xmamau.Rows[0]["MaMau"].ToString());
                string deletegiohangN = "execute deletegiohangban @mahd , @masp , @macauhinh , @mamau ";
                DataProvider.Instance.ExecuteNonQuery(deletegiohangN, new object[] {Convert.ToInt32(lbMHD.Text), Convert.ToInt32(ma.ToString()), Convert.ToInt32(maCH.ToString()), Convert.ToInt32(maMau.ToString()) });

                //udtien
                String queryUDTT = "execute updatetien2 @mahdx ";
                DataProvider.Instance.ExecuteNonQuery(queryUDTT, new object[] { Convert.ToInt32(lbMHD.Text) });

                //udsl
                   DataProvider.Instance.ExecuteNonQuery("update CTSanPham set SoLuong = SoLuong + @soluong where MaSP = @ten and MaCauHinh = @cauhinh and MaMau = @tenmau", new object[] {Convert.ToInt32(soluong), Convert.ToInt32(ma.ToString()), Convert.ToInt32(maCH.ToString()), Convert.ToInt32(maMau.ToString()) });
                //delete bao hanh
                DataProvider.Instance.ExecuteNonQuery("delete TKTGBH where MaHDBH = @ma and masp = @masp and mach = @mach and mamau = @mamau ",new object[] { Convert.ToInt32(lbMHD.Text), Convert.ToInt32(ma.ToString()), Convert.ToInt32(maCH.ToString()), Convert.ToInt32(maMau.ToString()) });
                //hienthitongtien


                MessageBox.Show("Delete Success !", "Success");
                string querygvm = "execute gvgiohang1 @ma ";
                DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
                gvHDBH.DataSource = gvgiohang;
                loadcombocox();
                hienthitongtien();
                txtSoLuong.ResetText();

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MKHC = 0;
            MKHM = 0;
            String query = "execute selectHDBH_SP @ma";
            DataTable HDBH_SP = DataProvider.Instance.ExecuteQuery(query ,new object[] {Convert.ToInt32( lbMHD.Text)});
            if (HDBH_SP.Rows.Count ==0)
            {
                MessageBox.Show("Hóa đơn bạn chưa có sản phẩm\nKhông thể thanh toán", "Error");
            }
            else if (HDBH_SP.Rows.Count != 0)
            {
                string selectHoaDon = "select TongTien from HoaDonBanHang where MaHD = '" + Convert.ToInt32(lbMHD.Text)+"'";
                DataTable HoaDon = DataProvider.Instance.ExecuteQuery(selectHoaDon);
                float tongtien= float.Parse(HoaDon.Rows[0]["TongTien"].ToString());

                //tìm mac loại khách hàng và phầm trăm chiết khấu của khhachs hàng
                string selectLKH = "select LoaiKH.MaLKH,KhachHang.DiemTichLuy , LoaiKH.PhanTramChietKhau from KhachHang,LoaiKH where KhachHang.MaLKH = LoaiKH.MaLKH and KhachHang.MaKH =  '" + Convert.ToInt32(MKH)+ "'";
                DataTable LKH = DataProvider.Instance.ExecuteQuery(selectLKH);
                float phamtramCK= float.Parse(LKH.Rows[0]["PhanTramChietKhau"].ToString());
                int diemtichluy = int.Parse(LKH.Rows[0]["DiemTichLuy"].ToString());

                double tongtienUD =Convert.ToDouble(Convert.ToDouble(tongtien.ToString()) - (Convert.ToDouble(tongtien.ToString()) / 100 * Convert.ToDouble(phamtramCK.ToString())));
                String queryUDTT = "execute UpdateHDBHTT @ma , @tongtien ";
                DataProvider.Instance.ExecuteNonQuery(queryUDTT, new object[] { Convert.ToInt32(lbMHD.Text), tongtienUD });

                //UD loại khách hàng 
                if (Convert.ToDouble( tongtien.ToString()) >= 2000000)
                {
                    string updateDTL = "Update KhachHang set DiemTichLuy = '" +Convert.ToInt32(Convert.ToInt32(diemtichluy)+ 10 )+ "' Where MaKH = '" + Convert.ToInt32(MKH) + "' ";
                    DataProvider.Instance.ExecuteNonQuery(updateDTL);
                    if (Convert.ToInt32(Convert.ToInt32(diemtichluy) + 10) >= 150 && Convert.ToInt32(Convert.ToInt32(diemtichluy) + 10) < 350)
                    {
                        string UDLKH = "Update KhachHang set MaLKH= 2 where MaKH ='" + Convert.ToInt32(MKH) + "' ";
                        DataProvider.Instance.ExecuteNonQuery(UDLKH);
                    }
                    else if (Convert.ToInt32(Convert.ToInt32(diemtichluy) + 10) >= 350 && Convert.ToInt32(Convert.ToInt32(diemtichluy) + 10) < 550)
                    {
                        string UDLKH = "Update KhachHang set MaLKH= 3 where MaKH ='" + Convert.ToInt32(MKH) + "' ";
                        DataProvider.Instance.ExecuteNonQuery(UDLKH);
                    }
                    else if (Convert.ToInt32(Convert.ToInt32(diemtichluy) + 10) >= 550)
                    {
                        string UDLKH = "Update KhachHang set MaLKH= 4 where MaKH ='" + Convert.ToInt32(MKH) + "' ";
                        DataProvider.Instance.ExecuteNonQuery(UDLKH);
                    }
                }

                   
                 FromThanhToanHDX fromThanh = new FromThanhToanHDX();
                this.Close();
                fromThanh.Show();
                
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string query = " select MaHD from HDBH_SP where MaHD ='" + Convert.ToInt32(lbMHD.Text) + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if(data.Rows.Count<=0)
            {
                MKHC = 0;
                MKHM = 0;
                Main main = new Main();
                this.Close();
                main.Show();
                
            }
            else if (data.Rows.Count >=0)
            {
                DialogResult a = MessageBox.Show("Bạn có muốn hủy hóa đơn này không ?", "Hủy", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    GhichuHoaDonBanHang ghichu = new GhichuHoaDonBanHang();
                    if(ghichu.ShowDialog() == DialogResult.Yes)
                    {
                        MKHC = 0;
                        MKHM = 0;
                        this.Close();
                        
                    }
                }
            }   
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        DateTime  newtime;
        void baohanh()
        {
            string querygvm = "Select * from HDBH_SP Where MaHD = @mahd ";
            DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { Convert.ToInt32(lbMHD.Text) });
            foreach (DataRow item in gvgiohang.Rows)
            {

                String query = "select * from SanPham where MaSP = '" + Convert.ToInt32(item[1].ToString()) + "'";
                DataTable HD = DataProvider.Instance.ExecuteQuery(query);
                int tgbh = int.Parse(HD.Rows[0]["ThoiGianBH"].ToString());

                String query1 = "select * from HoaDonBanHang where MaHD = '" + Convert.ToInt32(lbMHD.Text) + "'";
                DataTable HD1 = DataProvider.Instance.ExecuteQuery(query1);
                DateTime ngayxuat = DateTime.Parse(HD1.Rows[0]["NgayXuat"].ToString());
                if (Convert.ToInt32(tgbh.ToString()) < 12)
                {
                    DateTime aDateTime = Convert.ToDateTime(ngayxuat.ToString());
                    newtime = aDateTime.AddMonths(+Convert.ToInt32(tgbh.ToString()));
                }
                if (Convert.ToInt32(tgbh.ToString()) >= 12)
                {
                    //int a = Convert.ToInt32(tgbh.ToString()) / 12;
                    // int b = Convert.ToInt32(tgbh.ToString()) % 12;
                    DateTime aDateTime = Convert.ToDateTime(ngayxuat.ToString());
                    newtime = aDateTime.AddMonths(+Convert.ToInt32(tgbh.ToString()));
                    //  newtime = aDateTime.AddYears(+Convert.ToInt32(a));
                }

                DataProvider.Instance.ExecuteNonQuery("update TKTGBH set thoigianconlai = @tg where MaHDBH = @ma and masp = @masp and mach = @cauhinh and mamau = @tenmau", new object[] { Convert.ToDateTime(newtime), Convert.ToInt32(lbMHD.Text), Convert.ToInt32(item[1].ToString()), Convert.ToInt32(item[2].ToString()), Convert.ToInt32(item[3].ToString()) });

            }

        }
    }
}
