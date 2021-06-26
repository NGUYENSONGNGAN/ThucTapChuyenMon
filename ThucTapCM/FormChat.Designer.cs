
namespace ThucTapCM
{
    partial class FormChat
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbmessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(12, 389);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(315, 39);
            this.txtType.TabIndex = 1;
            this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtType_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(358, 389);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 39);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbmessage
            // 
            this.lbmessage.HideSelection = false;
            this.lbmessage.Location = new System.Drawing.Point(13, 12);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(446, 371);
            this.lbmessage.TabIndex = 7;
            this.lbmessage.UseCompatibleStateImageBehavior = false;
            this.lbmessage.View = System.Windows.Forms.View.List;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 439);
            this.Controls.Add(this.lbmessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lbmessage;
    }
}