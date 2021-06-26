
namespace ThucTapCM
{
    partial class HDBHMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HDBHMenu));
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuTileButton2.color = System.Drawing.Color.LawnGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.LawnGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::ThucTapCM.Properties.Resources.eligibility;
            this.bunifuTileButton2.ImagePosition = 19;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 40;
            this.bunifuTileButton2.LabelText = "Khách Hàng cũ";
            this.bunifuTileButton2.Location = new System.Drawing.Point(105, 117);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(260, 188);
            this.bunifuTileButton2.TabIndex = 1;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.LawnGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.LawnGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.LawnGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::ThucTapCM.Properties.Resources.d2ead876ae76ba7147f68e7d2417c5f3;
            this.bunifuTileButton1.ImagePosition = 19;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 40;
            this.bunifuTileButton1.LabelText = "Khách Hàng mới ";
            this.bunifuTileButton1.Location = new System.Drawing.Point(465, 117);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(260, 188);
            this.bunifuTileButton1.TabIndex = 0;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(754, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HDBHMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HDBHMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDBHMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}