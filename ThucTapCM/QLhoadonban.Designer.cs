
namespace ThucTapCM
{
    partial class QLhoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLhoadonban));
            this.lbMahd = new System.Windows.Forms.Label();
            this.txtseach = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvHDBH = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXCT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picvoice = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHDBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMahd
            // 
            this.lbMahd.AutoSize = true;
            this.lbMahd.Location = new System.Drawing.Point(1144, 74);
            this.lbMahd.Name = "lbMahd";
            this.lbMahd.Size = new System.Drawing.Size(46, 17);
            this.lbMahd.TabIndex = 110;
            this.lbMahd.Text = "label2";
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
            this.txtseach.Location = new System.Drawing.Point(501, 137);
            this.txtseach.Margin = new System.Windows.Forms.Padding(4);
            this.txtseach.Name = "txtseach";
            this.txtseach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtseach.Size = new System.Drawing.Size(507, 52);
            this.txtseach.TabIndex = 108;
            this.txtseach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtseach.OnValueChanged += new System.EventHandler(this.txtseach_OnValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvHDBH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1448, 543);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // gvHDBH
            // 
            this.gvHDBH.AllowUserToAddRows = false;
            this.gvHDBH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvHDBH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvHDBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHDBH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvHDBH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvHDBH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHDBH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvHDBH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHDBH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvHDBH.ColumnHeadersHeight = 40;
            this.gvHDBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHDBH.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvHDBH.DoubleBuffered = true;
            this.gvHDBH.EnableHeadersVisualStyles = false;
            this.gvHDBH.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gvHDBH.HeaderForeColor = System.Drawing.Color.White;
            this.gvHDBH.Location = new System.Drawing.Point(11, 21);
            this.gvHDBH.Name = "gvHDBH";
            this.gvHDBH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHDBH.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvHDBH.RowHeadersVisible = false;
            this.gvHDBH.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.gvHDBH.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvHDBH.RowTemplate.Height = 24;
            this.gvHDBH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvHDBH.Size = new System.Drawing.Size(1426, 516);
            this.gvHDBH.TabIndex = 135;
            this.gvHDBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHDBH_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(492, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 55);
            this.label1.TabIndex = 105;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1389, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Quét mã QR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(32, 122);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(279, 73);
            this.bunifuFlatButton1.TabIndex = 111;
            this.bunifuFlatButton1.Text = "Quét mã QR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnXCT
            // 
            this.btnXCT.ActiveBorderThickness = 1;
            this.btnXCT.ActiveCornerRadius = 20;
            this.btnXCT.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXCT.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnXCT.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.btnXCT.Location = new System.Drawing.Point(1040, 134);
            this.btnXCT.Margin = new System.Windows.Forms.Padding(5);
            this.btnXCT.Name = "btnXCT";
            this.btnXCT.Size = new System.Drawing.Size(202, 57);
            this.btnXCT.TabIndex = 109;
            this.btnXCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXCT.Click += new System.EventHandler(this.btnXCT_Click);
            // 
            // picvoice
            // 
            this.picvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picvoice.Image = ((System.Drawing.Image)(resources.GetObject("picvoice.Image")));
            this.picvoice.ImageActive = null;
            this.picvoice.Location = new System.Drawing.Point(409, 134);
            this.picvoice.Name = "picvoice";
            this.picvoice.Size = new System.Drawing.Size(67, 55);
            this.picvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picvoice.TabIndex = 142;
            this.picvoice.TabStop = false;
            this.picvoice.Zoom = 10;
            this.picvoice.Click += new System.EventHandler(this.picvoice_Click_1);
            // 
            // QLhoadonban
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1448, 740);
            this.Controls.Add(this.picvoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.lbMahd);
            this.Controls.Add(this.btnXCT);
            this.Controls.Add(this.txtseach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLhoadonban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLhoadonban";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLhoadonban_FormClosing);
            this.Load += new System.EventHandler(this.QLhoadonban_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHDBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMahd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXCT;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtseach;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvHDBH;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton picvoice;
    }
}