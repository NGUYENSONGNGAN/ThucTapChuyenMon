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
using System.IO;
using System.Drawing.Imaging;

namespace ThucTapCM
{
    public partial class FormTTSanPham : Form
    {
        int i;

        public FormTTSanPham()
        {
            InitializeComponent();

            //sample data
            
            loaddata();
        }

       
        void loaddata()
        {
            string query = "select MaSP N'Mã Sản Phẩm' , TenSP N'Tên Sản Phẩm'   ,Dongia N'Đơn giá',ThoiGianBH N'Thời gian bảo hành' ,Mota N'Mô tả',TenLoaiSP N'Tên loại sản phẩm'from SanPham left join LoaiSP on SanPham.MaLSP = LoaiSP.MaLSP  ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            btnAddSP.Enabled = true;
            btnResetSP.Enabled = false;
            btnSaveSP.Enabled = false;
          
            btnHuySP.Enabled = true;
            txtNameSP.Enabled = false;
            txtDonGia.Enabled = false;
            txtTGBH.Enabled = false;
            cbxMoTa.Enabled = true;
            cbxLSP.Enabled = true;
            btnImg.Visible = false;



            gvTTSP.DataSource = result;

        }


        private void btnAddSP_Click(object sender, EventArgs e)
        {
            i = 1;
            string query = "select Max(MaSP) from SanPham";
            int a = int.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());

            if (a == 0)
            {
                lbMSP.Text = "1";
            }
            else if (a != 0)
            {
                lbMSP.Text = Convert.ToString(Convert.ToInt32(a.ToString()) + 1);
                // int a = Convert.ToInt32()
            }
            btnAddSP.Enabled = false;
            btnSaveSP.Enabled = true;
            btnHuySP.Enabled = true;
            btnResetSP.Enabled = false;
    
            btnImg.Visible = true;
            txtNameSP.ResetText();
            txtDonGia.ResetText();
            txtTGBH.ResetText();
            cbxMoTa.ResetText();
            cbxLSP.ResetText();
            picImg.Image = null;


            cbxMoTa.Enabled = true;
            cbxLSP.Enabled = true;
            txtNameSP.Enabled = true;
            txtDonGia.Enabled = true;
            txtTGBH.Enabled = true;
            txtNameSP.Focus();            
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "Image Files(*.jpg; *.png; *.gif;)| *.jpg; *.png; *.gif";
            if (a.ShowDialog() == DialogResult.OK)
            {
               picImg.Image = new Bitmap(a.FileName);
                picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

       

        private void btnResetSP_Click(object sender, EventArgs e)
        {
            i = 2;
            cbxLSP.Enabled = true;
            cbxMoTa.Enabled = true;
            txtNameSP.Enabled = true;
            txtDonGia.Enabled = true;
            txtTGBH.Enabled = true;
            btnAddSP.Enabled = false;
            btnResetSP.Enabled = false;
  
            btnSaveSP.Enabled = true;
            btnHuySP.Enabled = true;
            btnImg.Visible = true;
        }

        private void btnSaveSP_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtNameSP.Text == "" || txtTGBH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin\n Vui lòng kiển tra lại", "Lỗi");
            }
            else
            {
                if (i == 1)
                {
                    if (picImg.Image == null)
                    {
                        DialogResult a = MessageBox.Show("Bạn chưa có hình sản phẩm này\nBạn có muốn tiếp tục không", "Thiếu thông tin", MessageBoxButtons.YesNo);
                        if (a == DialogResult.Yes)
                        {
                            string luu = "execute SPLUU @ten ";
                            DataTable sp = DataProvider.Instance.ExecuteQuery(luu, new object[] { txtNameSP.Text });
                            if (sp.Rows.Count >= 1)
                            {
                                DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn thêm không", "Trùng tên", MessageBoxButtons.YesNo);
                                if (b == DialogResult.Yes)
                                {
                                    if (cbxLSP.Text == "Điện thoại")
                                    {
                                        string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 1 });
                                        MessageBox.Show("Bạn đã thêm thành công");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "Ti Vi")
                                    {
                                        string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 2 });
                                        MessageBox.Show("Bạn đã thêm thành công");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "Tablet")
                                    {
                                        string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 3 });
                                        MessageBox.Show("Bạn đã thêm thành công");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "LapTop")
                                    {
                                        string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 4 });
                                        MessageBox.Show("Bạn đã thêm thành công");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "Phụ kiện")
                                    {
                                        string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 5 });
                                        MessageBox.Show("Bạn đã thêm thành công");
                                        loaddata();
                                    }


                                }
                            }
                            else if (sp.Rows.Count <= 0)
                            {


                                if (cbxLSP.Text == "Điện thoại")
                                {
                                    string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 1 });
                                    MessageBox.Show("Bạn đã thêm thành công");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Ti Vi")
                                {
                                    string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 2 });
                                    MessageBox.Show("Bạn đã thêm thành công");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Tablet")
                                {
                                    string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 3 });
                                    MessageBox.Show("Bạn đã thêm thành công");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "LapTop")
                                {
                                    string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 4 });
                                    MessageBox.Show("Bạn đã thêm thành công");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Phụ kiện")
                                {
                                    string query = "execute Insertsp1 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 5 });
                                    MessageBox.Show("Bạn đã thêm thành công");
                                    loaddata();
                                }


                            }
                        }
                    }
                    else if (picImg.Image != null)
                    {
                        //        MemoryStream a = new MemoryStream
                        // tính tiền khoan đã này là gì dị anh vũ
                        //
                        MemoryStream stream = new MemoryStream();
                        //tính tiền đỉnh quá hihihi
                        picImg.Image.Save(stream, ImageFormat.Jpeg);
                        string luu = "execute SPLUU @ten ";
                        DataTable sp = DataProvider.Instance.ExecuteQuery(luu, new object[] { txtNameSP.Text });
                        if (sp.Rows.Count >= 1)
                        {
                            DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn thêm không", "Trùng tên", MessageBoxButtons.YesNo);
                            if (b == DialogResult.Yes)
                            {
                                if (cbxLSP.Text == "Điện thoại")
                                {
                                    string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 1 });
                                    MessageBox.Show("Add Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Ti Vi")
                                {
                                    string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 2 });
                                    MessageBox.Show("Add Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Tablet")
                                {
                                    string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 3 });
                                    MessageBox.Show("Add Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "LapTop")
                                {
                                    string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 4 });
                                    MessageBox.Show("Add Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Phụ kiện")
                                {
                                    string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 5 });
                                    MessageBox.Show("Add Success !");
                                    loaddata();
                                }


                            }
                        }
                        else if (sp.Rows.Count <= 0)
                        {

                            if (cbxLSP.Text == "Điện thoại")
                            {
                                string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 1 });
                                MessageBox.Show("Add Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "Ti Vi")
                            {
                                string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 2 });
                                MessageBox.Show("Add Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "Tablet")
                            {
                                string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 3 });
                                MessageBox.Show("Add Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "LapTop")
                            {
                                string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 4 });
                                MessageBox.Show("Add Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "Phụ kiện")
                            {
                                string query = "execute InsertspIMG @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @maLSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 5 });
                                MessageBox.Show("Add Success !");
                                loaddata();
                            }

                        }

                    }
                    //dt.insertSP(Convert.ToInt32(lbSoMa.Text), Convert.ToInt32(cbbLoai.SelectedValue), txtTen.Text, Convert.ToInt32(txtDonGia.Text));
                }

                else if (i == 2)
                {
                    if (picImg.Image == null)
                    {
                        DialogResult a = MessageBox.Show("Bạn chưa có hình sản phẩm này\nBạn có muốn tiếp tục không", "Thiếu thông tin", MessageBoxButtons.YesNo);
                        if (a == DialogResult.Yes)
                        {
                            string luu = "execute SPLUU @ten ";
                            DataTable sp = DataProvider.Instance.ExecuteQuery(luu, new object[] { txtNameSP.Text });
                            if (sp.Rows.Count >= 1)
                            {
                                DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn thêm không", "Trùng tên", MessageBoxButtons.YesNo);
                                if (b == DialogResult.Yes)
                                {
                                    if (cbxLSP.Text == "Điện thoại")
                                    {
                                        string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 1 });
                                        MessageBox.Show("Reset Success!");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "Ti Vi")
                                    {
                                        string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 2 });
                                        MessageBox.Show("Reset Success!");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "Tablet")
                                    {
                                        string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 3 });
                                        MessageBox.Show("Reset Success!");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "LapTop")
                                    {
                                        string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 4 });
                                        MessageBox.Show("Reset Success!");
                                        loaddata();
                                    }
                                    else if (cbxLSP.Text == "Phụ kiện")
                                    {
                                        string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                        DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 5 });
                                        MessageBox.Show("Reset Success!");
                                        loaddata();
                                    }

                                }

                            }
                            else if (sp.Rows.Count <= 0)
                            {

                                if (cbxLSP.Text == "Điện thoại")
                                {
                                    string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 1 });
                                    MessageBox.Show("Reset Success!");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Ti Vi")
                                {
                                    string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 2 });
                                    MessageBox.Show("Reset Success!");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Tablet")
                                {
                                    string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 3 });
                                    MessageBox.Show("Reset Success!");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "LapTop")
                                {
                                    string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 4 });
                                    MessageBox.Show("Reset Success!");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Phụ kiện")
                                {
                                    string query = "execute UpdateSP1 @ma , @ten , @dongia , @thoigianbaohanh , @mota ,@LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, 5 });
                                    MessageBox.Show("Reset Success!");
                                    loaddata();
                                }

                            }
                        }
                    }

                    if (picImg.Image != null)
                    {
                        //  execute UpdateSP2 @ma = 54 , @ten = N'máy ghi âm ' , @dongia = 250000 , @thoigianbaohanh = 12, @mota = N'Hàng mới',@img ,@LSP = 2
                        MemoryStream stream = new MemoryStream();
                        //tính tiền đỉnh quá hihihi
                        picImg.Image.Save(stream, ImageFormat.Jpeg);
                        string luu = "execute SPLUU @ten ";
                        DataTable sp = DataProvider.Instance.ExecuteQuery(luu, new object[] { txtNameSP.Text });
                        if (sp.Rows.Count >= 1)
                        {
                            DialogResult b = MessageBox.Show("Sản phẩm này đã bị trùng tên\nBạn có muốn thêm không", "Trùng tên", MessageBoxButtons.YesNo);
                            if (b == DialogResult.Yes)
                            {
                                if (cbxLSP.Text == "Điện thoại")
                                {
                                    string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 1 });
                                    MessageBox.Show("Reset Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Ti Vi")
                                {
                                    string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 2 });
                                    MessageBox.Show("Reset Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Tablet")
                                {
                                    string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 3 });
                                    MessageBox.Show("Reset Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "LapTop")
                                {
                                    string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 4 });
                                    MessageBox.Show("Reset Success !");
                                    loaddata();
                                }
                                else if (cbxLSP.Text == "Phụ kiện")
                                {
                                    string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                    DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 5 });
                                    MessageBox.Show("Reset Success !");
                                    loaddata();
                                }


                            }
                        }
                        else if (sp.Rows.Count <= 0)
                        {

                            if (cbxLSP.Text == "Điện thoại")
                            {
                                string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 1 });
                                MessageBox.Show("Reset Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "Ti Vi")
                            {
                                string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 2 });
                                MessageBox.Show("Reset Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "Tablet")
                            {
                                string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 3 });
                                MessageBox.Show("Reset Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "LapTop")
                            {
                                string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 4 });
                                MessageBox.Show("Reset Success !");
                                loaddata();
                            }
                            else if (cbxLSP.Text == "Phụ kiện")
                            {
                                string query = " execute UpdateSP2 @ma , @ten , @dongia , @thoigianbaohanh , @mota , @img , @LSP ";
                                DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(lbMSP.Text), txtNameSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtTGBH.Text), cbxMoTa.Text, stream.ToArray(), 5 });
                                MessageBox.Show("Reset Success !");
                                loaddata();
                            }

                        
                   

                        }

                    }
                }
            }
            btnImg.Visible = true;
            lbMSP.ResetText();
            txtNameSP.ResetText();
            txtDonGia.ResetText();
            txtTGBH.ResetText();
            cbxMoTa.ResetText();
            cbxLSP.ResetText();
            picImg.Image = null;
            txtSeach.ResetText();
            loaddata();
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSeach.Text == null || txtSeach.Text == "")
            {
                loaddata();
            }
            else
            {
                string query = "execute SeachSP @ten ";
                DataTable seach = DataProvider.Instance.ExecuteQuery(query, new object[] { txtSeach.Text });
                btnAddSP.Enabled = true;
                btnResetSP.Enabled = false;
                btnSaveSP.Enabled = false;
                btnHuySP.Enabled = true;
        
                txtDonGia.Enabled = false;
                txtNameSP.Enabled = false;
                txtTGBH.Enabled = false;
                lbMSP.Visible = false;

                gvTTSP.DataSource = seach;

            }
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            //
            btnImg.Visible = true;
            lbMSP.ResetText();//
            txtNameSP.ResetText();
            txtDonGia.ResetText();
            txtTGBH.ResetText();
            cbxMoTa.ResetText();
            cbxLSP.ResetText();
            picImg.Image = null;
            txtSeach.ResetText();
            loaddata();
        }

        private void FormTTSanPham_Load(object sender, EventArgs e)
        {
            cbxLSP.SelectedIndex = 0;
            cbxMoTa.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
           
        }

        private void gvTTSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = gvTTSP.CurrentRow.Index;
            lbMSP.Text = gvTTSP.Rows[r].Cells[0].Value.ToString();
            txtNameSP.Text = gvTTSP.Rows[r].Cells[1].Value.ToString();
            txtDonGia.Text = gvTTSP.Rows[r].Cells[2].Value.ToString();
            txtTGBH.Text = gvTTSP.Rows[r].Cells[3].Value.ToString();
            cbxMoTa.Text = gvTTSP.Rows[r].Cells[4].Value.ToString();
            cbxLSP.Text = gvTTSP.Rows[r].Cells[5].Value.ToString();
            String query = "execute IMG3  @ma";
            DataTable HA = DataProvider.Instance.ExecuteQuery(query, new object[] { lbMSP.Text });
            //Byte hinhanh = HA.Rows[0]["HinhAnh"].ToString();
            if (HA.ToString() == null)
            {
                picImg.Image = null;
            }
            else
            {
                //erroByte[] image = (Byte[])cmd.ExecuteScalar( );;MemoryStream ms = new MemoryStream((byte[])tongtien.Rows[0]["MaQR"]);
                // Image img = Image.FromStream(ms);
                // pictQR.Image = img;

              /*  MemoryStream img = new MemoryStream((byte[])HA.Rows[0]["HinhAnh"]);
                Image i = Image.FromStream(img);
                if (i == null)
                {
                    picImg.Image = null;
                }
                else
                {
                    picImg.Image = i;
                }*/
            }

            cbxLSP.Enabled = true;
            cbxMoTa.Enabled = true;

            txtDonGia.Enabled = false;
            txtNameSP.Enabled = false;
            txtTGBH.Enabled = false;
            btnAddSP.Enabled = true;
            btnResetSP.Enabled = true;
            btnSaveSP.Enabled = false;

            btnImg.Visible = true;
        }

        private void cbxMoTa_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "execute PhanLoaiSP8 @ten ";
            DataTable sapxep = DataProvider.Instance.ExecuteQuery(query, new object[] { cbxMoTa.Text });
            gvTTSP.DataSource = sapxep;
        }

        private void cbxLSP_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string query = "execute PhanLoaiSP1 @ten ";
            DataTable sapxep = DataProvider.Instance.ExecuteQuery(query, new object[] { cbxLSP.Text });
            gvTTSP.DataSource = sapxep;
        }

        private void txtTGBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
