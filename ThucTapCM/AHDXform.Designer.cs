
namespace ThucTapCM
{
    partial class AHDXform
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
            this.gvgiohang5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOANCHUYENMON7DataSet1 = new ThucTapCM.DOANCHUYENMON7DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gvgiohang6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvgiohang6TableAdapter = new ThucTapCM.datasetXHDTableAdapters.gvgiohang6TableAdapter();
            this.datasetXHD = new ThucTapCM.datasetXHD();
            this.gvgiohang5TableAdapter = new ThucTapCM.DOANCHUYENMON7DataSet1TableAdapters.gvgiohang5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOANCHUYENMON7DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetXHD)).BeginInit();
            this.SuspendLayout();
            // 
            // gvgiohang5BindingSource
            // 
            this.gvgiohang5BindingSource.DataMember = "gvgiohang5";
            this.gvgiohang5BindingSource.DataSource = this.DOANCHUYENMON7DataSet1;
            // 
            // DOANCHUYENMON7DataSet1
            // 
            this.DOANCHUYENMON7DataSet1.DataSetName = "DOANCHUYENMON7DataSet1";
            this.DOANCHUYENMON7DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gvgiohang6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThucTapCM.NhoChayDuocNha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // gvgiohang6TableAdapter
            // 
            this.gvgiohang6TableAdapter.ClearBeforeFill = true;
            // 
            // datasetXHD
            // 
            this.datasetXHD.DataSetName = "datasetXHD";
            this.datasetXHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvgiohang5TableAdapter
            // 
            this.gvgiohang5TableAdapter.ClearBeforeFill = true;
            // 
            // AHDXform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AHDXform";
            this.Text = "AHDXform";
            this.Load += new System.EventHandler(this.AHDXform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOANCHUYENMON7DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetXHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gvgiohang6BindingSource;
        private datasetXHDTableAdapters.gvgiohang6TableAdapter gvgiohang6TableAdapter;
        private datasetXHD datasetXHD;
        private System.Windows.Forms.BindingSource gvgiohang5BindingSource;
        private DOANCHUYENMON7DataSet1 DOANCHUYENMON7DataSet1;
        private DOANCHUYENMON7DataSet1TableAdapters.gvgiohang5TableAdapter gvgiohang5TableAdapter;
    }
}