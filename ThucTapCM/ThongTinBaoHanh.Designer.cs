
namespace ThucTapCM
{
    partial class ThongTinBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinBaoHanh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvTKBH = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnXCT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtseach = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.picvoice = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTKBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1376, -2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 49);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 151;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(371, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 55);
            this.label1.TabIndex = 152;
            this.label1.Text = "Thống Kê Thời Gian Bảo Hành";
            // 
            // gvTKBH
            // 
            this.gvTKBH.AllowUserToAddRows = false;
            this.gvTKBH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvTKBH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gvTKBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTKBH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvTKBH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvTKBH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTKBH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvTKBH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTKBH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvTKBH.ColumnHeadersHeight = 40;
            this.gvTKBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTKBH.DefaultCellStyle = dataGridViewCellStyle13;
            this.gvTKBH.DoubleBuffered = true;
            this.gvTKBH.EnableHeadersVisualStyles = false;
            this.gvTKBH.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gvTKBH.HeaderForeColor = System.Drawing.Color.White;
            this.gvTKBH.Location = new System.Drawing.Point(12, 140);
            this.gvTKBH.Name = "gvTKBH";
            this.gvTKBH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTKBH.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gvTKBH.RowHeadersVisible = false;
            this.gvTKBH.RowHeadersWidth = 51;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.gvTKBH.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gvTKBH.RowTemplate.Height = 24;
            this.gvTKBH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvTKBH.Size = new System.Drawing.Size(1401, 546);
            this.gvTKBH.TabIndex = 153;
            this.gvTKBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTKBH_CellClick);
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
            this.btnXCT.ButtonText = "Delete";
            this.btnXCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCT.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXCT.IdleBorderThickness = 1;
            this.btnXCT.IdleCornerRadius = 20;
            this.btnXCT.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnXCT.IdleForecolor = System.Drawing.Color.Fuchsia;
            this.btnXCT.IdleLineColor = System.Drawing.Color.Fuchsia;
            this.btnXCT.Location = new System.Drawing.Point(744, 77);
            this.btnXCT.Margin = new System.Windows.Forms.Padding(5);
            this.btnXCT.Name = "btnXCT";
            this.btnXCT.Size = new System.Drawing.Size(202, 57);
            this.btnXCT.TabIndex = 156;
            this.btnXCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXCT.Click += new System.EventHandler(this.btnXCT_Click);
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
            this.txtseach.Location = new System.Drawing.Point(205, 80);
            this.txtseach.Margin = new System.Windows.Forms.Padding(4);
            this.txtseach.Name = "txtseach";
            this.txtseach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtseach.Size = new System.Drawing.Size(507, 52);
            this.txtseach.TabIndex = 155;
            this.txtseach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtseach.OnValueChanged += new System.EventHandler(this.txtseach_OnValueChanged);
            // 
            // picvoice
            // 
            this.picvoice.Image = ((System.Drawing.Image)(resources.GetObject("picvoice.Image")));
            this.picvoice.Location = new System.Drawing.Point(99, 82);
            this.picvoice.Name = "picvoice";
            this.picvoice.Size = new System.Drawing.Size(59, 52);
            this.picvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picvoice.TabIndex = 154;
            this.picvoice.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1096, 77);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(239, 57);
            this.iconButton1.TabIndex = 157;
            this.iconButton1.Text = "       XUẤT EXCEL ";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ThongTinBaoHanh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1425, 698);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnXCT);
            this.Controls.Add(this.txtseach);
            this.Controls.Add(this.picvoice);
            this.Controls.Add(this.gvTKBH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinBaoHanh";
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTKBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvTKBH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXCT;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtseach;
        private System.Windows.Forms.PictureBox picvoice;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}