
namespace ChatKhachHang
{
    partial class TTKhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTKhachhang));
            this.label1 = new System.Windows.Forms.Label();
            this.gvHangTon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picChat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông Tin Các Đơn Hàng Của Bạn";
            // 
            // gvHangTon
            // 
            this.gvHangTon.AllowUserToAddRows = false;
            this.gvHangTon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvHangTon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvHangTon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHangTon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvHangTon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvHangTon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHangTon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvHangTon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHangTon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvHangTon.ColumnHeadersHeight = 40;
            this.gvHangTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHangTon.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvHangTon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvHangTon.DoubleBuffered = true;
            this.gvHangTon.EnableHeadersVisualStyles = false;
            this.gvHangTon.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gvHangTon.HeaderForeColor = System.Drawing.Color.White;
            this.gvHangTon.Location = new System.Drawing.Point(0, 159);
            this.gvHangTon.Name = "gvHangTon";
            this.gvHangTon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHangTon.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvHangTon.RowHeadersVisible = false;
            this.gvHangTon.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.gvHangTon.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvHangTon.RowTemplate.Height = 24;
            this.gvHangTon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvHangTon.Size = new System.Drawing.Size(1313, 487);
            this.gvHangTon.TabIndex = 139;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1190, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(54, 49);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogout.TabIndex = 141;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1261, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 49);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 140;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1082, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 142;
            this.label2.Text = "Chat ngay nếu bạn cần sự hỗ trợ .";
            // 
            // picChat
            // 
            this.picChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picChat.Image = ((System.Drawing.Image)(resources.GetObject("picChat.Image")));
            this.picChat.Location = new System.Drawing.Point(1085, 66);
            this.picChat.Name = "picChat";
            this.picChat.Size = new System.Drawing.Size(64, 60);
            this.picChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChat.TabIndex = 143;
            this.picChat.TabStop = false;
            this.picChat.Click += new System.EventHandler(this.picChat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 144;
            this.pictureBox1.TabStop = false;
            // 
            // TTKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1313, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gvHangTon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TTKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTKhachhang";
            this.Load += new System.EventHandler(this.TTKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHangTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvHangTon;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picChat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}