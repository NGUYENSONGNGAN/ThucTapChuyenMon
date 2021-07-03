
namespace ThucTapCM
{
    partial class FormXuatHoaDonReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuatHoaDonReport));
            this.gvgiohang6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetXHD = new ThucTapCM.datasetXHD();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gvgiohang6TableAdapter = new ThucTapCM.datasetXHDTableAdapters.gvgiohang6TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetXHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvgiohang6BindingSource
            // 
            this.gvgiohang6BindingSource.DataMember = "gvgiohang6";
            this.gvgiohang6BindingSource.DataSource = this.datasetXHD;
            // 
            // datasetXHD
            // 
            this.datasetXHD.DataSetName = "datasetXHD";
            this.datasetXHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gvgiohang6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThucTapCM.ReportXuatHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1268, 656);
            this.reportViewer1.TabIndex = 0;
            // 
            // gvgiohang6TableAdapter
            // 
            this.gvgiohang6TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1208, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormXuatHoaDonReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1272, 672);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXuatHoaDonReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXuatHoaDonReport";
            this.Load += new System.EventHandler(this.FormXuatHoaDonReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetXHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gvgiohang6BindingSource;
        private datasetXHD datasetXHD;
        private datasetXHDTableAdapters.gvgiohang6TableAdapter gvgiohang6TableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}