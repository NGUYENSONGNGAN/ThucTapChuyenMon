using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using DevExpress.CodeParser;
using ThucTapCM.DAO;
using System.Data.SqlClient;

namespace ThucTapCM
{
    public partial class QuetmaQR : Form
    {
        public QuetmaQR()
        {
            InitializeComponent();
        }
        MJPEGStream Stream;
        public class TTTK
        {
            public static int MaHDX;
            public static int MoFormRP;
            public static int Load = 1;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QLhoadonban qLhoadonban = new QLhoadonban();
            this.Hide();
            qLhoadonban.Show();
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Stream.Stop();
            }
        }

        private void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictcamera.Image = bmp;
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            if (btnketnoi.Text == "Kết nối")
            {
                if (txtURL.Text.Trim() == "" || txtURL.Text.Trim() == null)
                {
                    MessageBox.Show("Bạn chưa kết nối ứng dụng");
                }
                else
                //tính tiền
                {
                    pictcamera.Visible = true;
                    Stream = new MJPEGStream(txtURL.Text);
                    Stream.NewFrame += stream_NewFrame;
                    Stream.Start();
                    timer1.Enabled = true;
                    timer1.Start();
                    btnketnoi.Text = "Ngắt ứng dụng";
                //  btnketnoi.Image = Image.FromFile("..//..//..//..//image//icondis.png");
                }
            }
            else
            {
                pictcamera.Visible = false;
                btnketnoi.Text = "Kết nối ứng dụng";
             //   btnketnoi.Image = Image.FromFile("..//..//..//..//image//iconconnect.png");
                timer1.Stop();
                Stream.Stop();
                timer1.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader Reader = new BarcodeReader();
                if (Reader.Decode((Bitmap)pictcamera.Image) != null)
                {
                    Result result = Reader.Decode((Bitmap)pictcamera.Image);
                    if (result != null)
                    {
                        int temp;
                        string MaHDX = "";
                        MaHDX = result.ToString();
                        string select = "select MaHD from HoaDonBanHang where MaHD = '" + Convert.ToInt32(MaHDX) + "'";
                        DataTable MaHD = DataProvider.Instance.ExecuteQuery(select);
                        int HDX = int.Parse(MaHD.Rows[0]["MaHD"].ToString());
                        if (MaHD.Rows.Count <= 0 || Convert.ToInt32(MaHDX) % 1 != 0 || int.TryParse(MaHDX, out temp) == false)
                        {
                            MessageBox.Show("Không có hóa đơn này\nXin mời kiểm tra lại", "Lỗi");
                        }
                        else if (MaHD.Rows.Count >= 1)
                        {
                            TTTK.MaHDX = Convert.ToInt32(MaHDX);
                            TTTK.MoFormRP = 1;
                            if (TTTK.Load == 1)
                            {
                                TTTK.Load++;
                                btnketnoi_Click(sender, e);
                                FormXuatHoaDonReport xuatHoaDonReport = new FormXuatHoaDonReport();
                                this.Hide();
                                xuatHoaDonReport.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void QuetmaQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Stream.Stop();
            }
        }
    }
}
