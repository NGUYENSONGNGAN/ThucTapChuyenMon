
namespace ThucTapCM
{
    partial class QuetmaQR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuetmaQR));
            this.btnketnoi = new System.Windows.Forms.Button();
            this.pictcamera = new System.Windows.Forms.PictureBox();
            this.txtURL = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictcamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnketnoi
            // 
            this.btnketnoi.Location = new System.Drawing.Point(587, 145);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(89, 41);
            this.btnketnoi.TabIndex = 1;
            this.btnketnoi.Text = "Kết nối";
            this.btnketnoi.UseVisualStyleBackColor = true;
            this.btnketnoi.Click += new System.EventHandler(this.btnketnoi_Click);
            // 
            // pictcamera
            // 
            this.pictcamera.Location = new System.Drawing.Point(114, 215);
            this.pictcamera.Name = "pictcamera";
            this.pictcamera.Size = new System.Drawing.Size(562, 305);
            this.pictcamera.TabIndex = 0;
            this.pictcamera.TabStop = false;
            // 
            // txtURL
            // 
            this.txtURL.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtURL.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtURL.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtURL.BorderThickness = 3;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtURL.isPassword = false;
            this.txtURL.Location = new System.Drawing.Point(207, 141);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtURL.Size = new System.Drawing.Size(321, 52);
            this.txtURL.TabIndex = 102;
            this.txtURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(212, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 55);
            this.label1.TabIndex = 103;
            this.label1.Text = "Quét mã QR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(740, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 139;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 140;
            this.label2.Text = "URL :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuetmaQR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnketnoi);
            this.Controls.Add(this.pictcamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuetmaQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuetmaQR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuetmaQR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictcamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictcamera;
        private System.Windows.Forms.Button btnketnoi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}