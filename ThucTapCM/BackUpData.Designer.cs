
namespace ThucTapCM
{
    partial class BackUpData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpData));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackup = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnBackup = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 32);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(561, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Browser";
            // 
            // txtBackup
            // 
            this.txtBackup.BorderColorFocused = System.Drawing.Color.Magenta;
            this.txtBackup.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBackup.BorderColorMouseHover = System.Drawing.Color.Magenta;
            this.txtBackup.BorderThickness = 3;
            this.txtBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBackup.isPassword = false;
            this.txtBackup.Location = new System.Drawing.Point(140, 70);
            this.txtBackup.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(370, 44);
            this.txtBackup.TabIndex = 4;
            this.txtBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.Gray;
            this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnBackup.IconColor = System.Drawing.Color.LimeGreen;
            this.btnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackup.IconSize = 54;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBackup.Location = new System.Drawing.Point(216, 161);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(175, 52);
            this.btnBackup.TabIndex = 127;
            this.btnBackup.Text = "Back Up";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "BACKUP DATA";
            // 
            // imgExit
            // 
            this.imgExit.BackColor = System.Drawing.Color.White;
            this.imgExit.Image = ((System.Drawing.Image)(resources.GetObject("imgExit.Image")));
            this.imgExit.Location = new System.Drawing.Point(643, 0);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(37, 32);
            this.imgExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgExit.TabIndex = 128;
            this.imgExit.TabStop = false;
            this.imgExit.Click += new System.EventHandler(this.imgExit_Click);
            // 
            // BackUpData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(680, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackUpData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackUpData";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBackup;
        private FontAwesome.Sharp.IconButton btnBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgExit;
    }
}