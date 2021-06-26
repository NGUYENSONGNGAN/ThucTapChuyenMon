using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ThucTapCM.DAO;
using System.IO;
using System.Globalization;




namespace ThucTapCM
{
    public partial class Main : Form
    {
        int mcv = txtPassWord.mcv;
        int MaNVCV = txtPassWord.id;
        CultureInfo culture = new CultureInfo("vi-VN");
        public Main()
        {
            InitializeComponent();
            customizeDsing();
        }
        private void customizeDsing()
        {
            panelBanHang.Visible = false;
            panelNhapHang.Visible = false;
            panelTTQL.Visible = false;
            panelKhoDL.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelBanHang.Visible == true)
                panelBanHang.Visible = false;
            if (panelNhapHang.Visible == true)
                panelNhapHang.Visible = false;
            if (panelTTQL.Visible == true)
                panelTTQL.Visible = false;
            if (panelKhoDL.Visible == true)
                panelKhoDL.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
        }
        
        #region BANHANGMENU
        private void btnQLBan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBanHang);
        }

        private void btbHoadonB_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            HDBHMenu hDBHMenu = new HDBHMenu();
            this.Hide();
            hDBHMenu.Show();

            

        }

        private void btnTTHoadon_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            QLhoadonban qLhoadonban = new QLhoadonban();
            this.Hide();
            qLhoadonban.Show();
        }
#endregion
        #region NHAPHANGMENU

        private void btnNhap_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhapHang);
        }
        private void btnHoadonN_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            HoaDonNhapHang hoaDonNhapHang = new HoaDonNhapHang();
            this.Hide();
            hoaDonNhapHang.Show();
        }

        private void btnTTHoadonN_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            QLHoaDonNhap qLHoaDonNhap = new QLHoaDonNhap();
            this.Hide();
            qLHoaDonNhap.Show();
        }
#endregion
        #region TTQLMENU
        private void btnTTQL_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTTQL);

        }

        private void btnTTSP_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            FormTTSanPham tTSanPham = new FormTTSanPham();
            this.Hide();
            tTSanPham.Show();
        }

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            FormTTKhachHang formTTKhachHang = new FormTTKhachHang();
            this.Hide();
            formTTKhachHang.Show();
        }

        private void btnTTNV_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            FormTTNhanVien tTKhachHang = new FormTTNhanVien();
            this.Hide();
            tTKhachHang.Show();
        }

        private void btnTTNCC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            FormTTNCC tTNCC = new FormTTNCC();
            this.Hide();
            tTNCC.Show();
        }
#endregion
        #region KHOMENU
        private void btnKhoDL_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKhoDL);
        }

        private void btnTKTC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ThongKeThuChi thongKeThuChi = new ThongKeThuChi();
            this.Hide();
            thongKeThuChi.Show();
        }

        private void btnTKHT_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ThongKeHangTon thongKeHangTon = new ThongKeHangTon();
            this.Hide();
            thongKeHangTon.Show();
        }

        private void btnTKKH_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ThongKeKhachHang ttKH = new ThongKeKhachHang();
            this.Hide();
            ttKH.Show();
        }

        private void btnTTBH_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ThongTinBaoHanh thongTinBaoHanh = new ThongTinBaoHanh();
            this.Hide();
            thongTinBaoHanh.Show();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormChat formChat = new FormChat();
            formChat.TopLevel = false;
            pnlchatkh.Controls.Add(formChat);
            formChat.Dock = DockStyle.Fill;
            formChat.Show();
            pnlchatkh.Visible = false;
            PnChat.Visible = false;


            string querySL = "select Count(MaHD)  N'SoLuong' From HoaDonBanHang";
            DataTable sl = DataProvider.Instance.ExecuteQuery(querySL);
            int SLHD = Convert.ToInt32( sl.Rows[0]["SoLuong"].ToString());
            lbslDon.Text = SLHD.ToString();

            string queryTT = "select Sum(TongTien) N'DoanhThu' from HoaDonBanHang";
            DataTable TT = DataProvider.Instance.ExecuteQuery(queryTT);
            double TongDT = Convert.ToDouble(TT.Rows[0]["DoanhThu"].ToString());
            lbdoanhthu.Text = TongDT.ToString("N0", culture) + "   (VNĐ)";

            //tenNV
            /* string querytennv = "select Count(MaHD)  N'SoLuong' From HoaDonBanHang";
             DataTable nvten = DataProvider.Instance.ExecuteQuery(querytennv);
             int tentop = Convert.ToInt32(nvten.Rows[0]["SoLuong"].ToString());
             lbslDon.Text = tentop.ToString();*/
            string sltop = "SELECT top 1 COUNT(MaHD) N'soluong', MaNV FROM HoaDonBanHang GROUP BY MaNV";
            DataTable soluongtop = DataProvider.Instance.ExecuteQuery(sltop);
            int soluongtnv = Convert.ToInt32(soluongtop.Rows[0]["soluong"].ToString());
            lbnvdt.Text = soluongtnv.ToString();

            int MaNVTop = Convert.ToInt32(soluongtop.Rows[0]["MaNV"].ToString());
            string TenNVtop = "SELECT TenNV from NhanVien Where MaNV ='"+Convert.ToInt32(MaNVTop) +"' ";
            DataTable TenNVTOP1 = DataProvider.Instance.ExecuteQuery(TenNVtop);
            string tennvtop1 = Convert.ToString(TenNVTOP1.Rows[0]["TenNV"].ToString());
            tenNVt1.Text = tennvtop1.ToString();



            if (mcv == 1)
                {
                    btnKhoDL.Visible = true;
                    btnQLNhap.Visible = true;
                    btnQLBan.Visible = true;
                    btnTTQL.Visible = true;
                    //btnCauHinhEmail.Visible = true;
                    picBackKup.Visible = true;
                }
                else if (mcv == 2)
                {
                    btnKhoDL.Visible = true;
                    btnQLNhap.Visible = false;
                    btnQLBan.Visible = false;
                    btnTTQL.Visible = false;
                    //btnCauHinhEmail.Visible = true;
                    picBackKup.Visible = false;
                }
                else if (mcv == 3)
                {
                    btnKhoDL.Visible = true;
                    btnTKHT.Visible = false;
                    btnTKTC.Visible = false;
                    btnTKKH.Visible = false;
                    btnTTBH.Visible = true;
                    btnQLNhap.Visible = false;
                    btnQLBan.Visible = true;
                    btnTTQL.Visible = false;
                    //btnCauHinhEmail.Visible = true;
                    picBackKup.Visible = false;
                }

            String query1 = "Select TenNV from NhanVien where MaNV = '"+MaNVCV+"' ";
            String name = DataProvider.Instance.ExecuteScalar(query1).ToString();

            lbTenlogin.Text = "Xin chào " + name;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtPassWord login = new txtPassWord();
            this.Close();
            login.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult rout = MessageBox.Show("Are you sure want to out ?", "out", MessageBoxButtons.YesNo);
            if (rout == DialogResult.Yes)
            {
                Application.Exit();
                return;
            }
        }
        int i = 0;
        private void picChat_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                pnlchatkh.Visible = true;

            }
            else
            {
                pnlchatkh.Visible = false;
            }
        }

        private void picBackKup_Click(object sender, EventArgs e)
        {
            BackUpData backUpData = new BackUpData();
            backUpData.Show();
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
