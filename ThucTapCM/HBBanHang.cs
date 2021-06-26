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
        int MKH = 0;
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
            if (MKHC == 0)
            {
                MKH = MKHM;
            }
            else if (MKHM == 0)
            {
                MKH = MKHC;
            }

            string query1 = "execute selectKHHD1 '" + MKH + "'";
            string name = DataProvider.Instance.ExecuteScalar(query1).ToString();
            lbNameKH.Text = name;
            string query2 = "execute selectKHHD2 '" + MKH + "'";
            string DiemTichLuy = DataProvider.Instance.ExecuteScalar(query2).ToString();
            lbDTL.Text = DiemTichLuy;
            string query3 = "execute selectKHHD3 '" + MKH + "'";
            string loaikhachhang = DataProvider.Instance.ExecuteScalar(query3).ToString();
            lbLKH.Text = loaikhachhang;
            btnThanhToan.Enabled = false;
            gvSeachHD.Visible = false;

            string querygvm = "execute gvgiohang1 @ma ";
            DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
            gvHDBH.DataSource = gvgiohang;
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
                MessageBox.Show("Số lượng bạn cần không đủ !");
                txtSoLuong.Focus();
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

                    String queryUDTT = "execute UpdateHDBHTT @ma , @tongtien ";
                    DataProvider.Instance.ExecuteNonQuery(queryUDTT, new object[] { Convert.ToInt32(lbMHD.Text), dongia * Convert.ToInt32(txtSoLuong.Text) });

                    string queryUDSLT = "execute UpdateSLTCTSP1 @masp , @macauhinh , @mamau  , @soluong ";
                    DataProvider.Instance.ExecuteNonQuery(queryUDSLT, new object[] {Convert.ToInt32(cbxSanPham.SelectedValue), Convert.ToInt32(cbxCauHinh.SelectedValue),
                                    Convert.ToInt32(cbxMauSac.SelectedValue), Convert.ToInt32(lbHangton.Text) - Convert.ToInt32(txtSoLuong.Text)});

                    MessageBox.Show("Add Success !");

                    string querygvm = "execute gvgiohang1 @ma ";
                    DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
                    gvHDBH.DataSource = gvgiohang;
                    loadcombocox();
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

                        string querygvm = "execute gvgiohang1 @ma ";    
                        DataTable gvgiohang = DataProvider.Instance.ExecuteQuery(querygvm, new object[] { lbMHD.Text });
                        gvHDBH.DataSource = gvgiohang;
                        loadcombocox();
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
                //câu lệnh delete
                string timma = "execute timma1 @tensanpham , @cauhinh , @mausac ";
                DataTable tbtimma = DataProvider.Instance.ExecuteQuery(timma, new object[] {ten , cauhinh , mausac });
                string deletegiohang = "execute deletegiohang @mahd , @masp , @macauhinh , @mamau ";
                DataProvider.Instance.ExecuteNonQuery(deletegiohang, new object[] { Convert.ToInt32(label13.Text), int.Parse(tbtimma.Rows[0]["MaSP"].ToString()), int.Parse(tbtimma.Rows[1]["MaCauHinh"].ToString()), int.Parse(tbtimma.Rows[2]["MaMau"].ToString()) });

               //UD tiền hóa đơn bán hàng


                //UD số lượng tồn 
                
                
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
                    if (Convert.ToInt32(diemtichluy) >= 150 && Convert.ToInt32(diemtichluy) < 350)
                    {
                        string UDLKH = "Update KhachHang set MaLKH= 2 where MaKH ='" + Convert.ToInt32(MKH) + "' ";
                    }
                    else if (Convert.ToInt32(diemtichluy) >= 350 && Convert.ToInt32(diemtichluy) < 550)
                    {
                        string UDLKH = "Update KhachHang set MaLKH= 3 where MaKH ='" + Convert.ToInt32(MKH) + "' ";
                    }
                    else if (Convert.ToInt32(diemtichluy) >= 550)
                    {
                        string UDLKH = "Update KhachHang set MaLKH= 4 where MaKH ='" + Convert.ToInt32(MKH) + "' ";
                    }
                }

                    /*  if (float.Parse(HoaDon.Rows[2]["TongTien"].ToString()) >= 200000)
                      {
                          string updateDTL = "Update KhachHang set DiemTichLuy = '" + int.Parse(khachhang.Rows[2]["DiemTichLuy"].ToString()) + "' Where MaKH = '" + int.Parse(khachhang.Rows[0]["MaKH"].ToString()) + "' ";

                          string selectKH1 = "select * from KhachHang where MaKH = '" + MKH + "'";
                          DataTable khachhang1 = DataProvider.Instance.ExecuteQuery(selectKH1);
                          if (int.Parse(khachhang1.Rows[2]["DiemTichLuy"].ToString()) >= 150 && int.Parse(khachhang1.Rows[2]["DiemTichLuy"].ToString()) < 350)
                          {
                              string UDLKH = "Update KhachHang set MaLKH= 2 where MaKH ='"+Convert.ToInt32(int.Parse(khachhang1.Rows[0]["MaKH"].ToString())) +"' ";
                          }
                          else if (int.Parse(khachhang1.Rows[2]["DiemTichLuy"].ToString()) >= 350 && int.Parse(khachhang1.Rows[2]["DiemTichLuy"].ToString()) <550)
                          {
                              string UDLKH = "Update KhachHang set MaLKH= 3 where MaKH ='" + Convert.ToInt32(int.Parse(khachhang1.Rows[0]["MaKH"].ToString())) + "' ";
                          }
                          else if(int.Parse(khachhang1.Rows[2]["DiemTichLuy"].ToString()) >= 550)
                          {
                              string UDLKH = "Update KhachHang set MaLKH= 4 where MaKH ='" + Convert.ToInt32(int.Parse(khachhang1.Rows[0]["MaKH"].ToString())) + "' ";
                          }    
                      }*/
                    FromThanhToanHDX fromThanh = new FromThanhToanHDX();
                this.Hide();
                fromThanh.Show();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string query = " select MaHD from HDBH_SP where MaHD ='" + Convert.ToInt32(lbMHD.Text) + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if(data.Rows.Count<=0)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            {
                DialogResult a = MessageBox.Show("Bạn có muốn hủy hóa đơn này không ?", "Hủy", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    //TTMHDX.MoFormGhiChuHuyHDX = 1;
                    GhichuHoaDonBanHang ghichu = new GhichuHoaDonBanHang();
                    ghichu.ShowDialog();
                        
                    
                }
            }   
            
        }
    }
}
