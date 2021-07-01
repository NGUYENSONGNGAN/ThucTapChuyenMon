
namespace ThucTapCM
{
    partial class GhichuHoaDonBanHang
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.btnghichu = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(200, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 55);
            this.label8.TabIndex = 129;
            this.label8.Text = "Ghi chú ";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(38, 80);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(560, 218);
            this.txtghichu.TabIndex = 131;
            // 
            // btnghichu
            // 
            this.btnghichu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.btnghichu.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnghichu.FlatAppearance.BorderSize = 0;
            this.btnghichu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btnghichu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnghichu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnghichu.ForeColor = System.Drawing.Color.Gray;
            this.btnghichu.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnghichu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnghichu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnghichu.IconSize = 54;
            this.btnghichu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnghichu.Location = new System.Drawing.Point(182, 323);
            this.btnghichu.Name = "btnghichu";
            this.btnghichu.Size = new System.Drawing.Size(198, 56);
            this.btnghichu.TabIndex = 130;
            this.btnghichu.Text = "Thoát";
            this.btnghichu.UseVisualStyleBackColor = false;
            this.btnghichu.Click += new System.EventHandler(this.btnghichu_Click);
            // 
            // GhichuHoaDonBanHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(626, 400);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.btnghichu);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GhichuHoaDonBanHang";
            this.Text = "GhichuHoaDonBanHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnghichu;
        private System.Windows.Forms.TextBox txtghichu;
    }
}