
namespace ThucTapCM
{
    partial class QLHoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHoaDonNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.txtseach = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvHDN = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lbMahd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXCT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(490, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = " Hóa Đơn Nhập Hàng";
            // 
            // txtseach
            // 
            this.txtseach.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtseach.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtseach.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtseach.BorderThickness = 3;
            this.txtseach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtseach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtseach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtseach.isPassword = false;
            this.txtseach.Location = new System.Drawing.Point(467, 131);
            this.txtseach.Margin = new System.Windows.Forms.Padding(4);
            this.txtseach.Name = "txtseach";
            this.txtseach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtseach.Size = new System.Drawing.Size(507, 52);
            this.txtseach.TabIndex = 101;
            this.txtseach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtseach.OnValueChanged += new System.EventHandler(this.txtseach_OnValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvHDN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1450, 543);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // gvHDN
            // 
            this.gvHDN.AllowUserToAddRows = false;
            this.gvHDN.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvHDN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHDN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvHDN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvHDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHDN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvHDN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvHDN.ColumnHeadersHeight = 40;
            this.gvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHDN.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvHDN.DoubleBuffered = true;
            this.gvHDN.EnableHeadersVisualStyles = false;
            this.gvHDN.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gvHDN.HeaderForeColor = System.Drawing.Color.White;
            this.gvHDN.Location = new System.Drawing.Point(12, 13);
            this.gvHDN.Name = "gvHDN";
            this.gvHDN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHDN.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvHDN.RowHeadersVisible = false;
            this.gvHDN.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.gvHDN.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvHDN.RowTemplate.Height = 24;
            this.gvHDN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvHDN.Size = new System.Drawing.Size(1426, 516);
            this.gvHDN.TabIndex = 136;
            this.gvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHDN_CellClick_1);
            // 
            // lbMahd
            // 
            this.lbMahd.AutoSize = true;
            this.lbMahd.Location = new System.Drawing.Point(1064, 63);
            this.lbMahd.Name = "lbMahd";
            this.lbMahd.Size = new System.Drawing.Size(46, 17);
            this.lbMahd.TabIndex = 104;
            this.lbMahd.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1391, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnXCT
            // 
            this.btnXCT.ActiveBorderThickness = 1;
            this.btnXCT.ActiveCornerRadius = 20;
            this.btnXCT.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXCT.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnXCT.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXCT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXCT.BackgroundImage")));
            this.btnXCT.ButtonText = "Xem chi  tiết";
            this.btnXCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCT.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXCT.IdleBorderThickness = 1;
            this.btnXCT.IdleCornerRadius = 20;
            this.btnXCT.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnXCT.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.btnXCT.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.btnXCT.Location = new System.Drawing.Point(1015, 128);
            this.btnXCT.Margin = new System.Windows.Forms.Padding(5);
            this.btnXCT.Name = "btnXCT";
            this.btnXCT.Size = new System.Drawing.Size(202, 57);
            this.btnXCT.TabIndex = 103;
            this.btnXCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXCT.Click += new System.EventHandler(this.btnXCT_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(361, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 100;
            this.pictureBox3.TabStop = false;
            // 
            // QLHoaDonNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1450, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMahd);
            this.Controls.Add(this.btnXCT);
            this.Controls.Add(this.txtseach);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLHoaDonNhap";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtseach;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXCT;
        private System.Windows.Forms.Label lbMahd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvHDN;
    }
}