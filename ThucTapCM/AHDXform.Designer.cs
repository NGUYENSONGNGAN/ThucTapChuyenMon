
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gvgiohang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HDBHtheoma = new ThucTapCM.HDBHtheoma();
            this.gvgiohang1TableAdapter = new ThucTapCM.HDBHtheomaTableAdapters.gvgiohang1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDBHtheoma)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gvgiohang1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThucTapCM.AreportHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // gvgiohang1BindingSource
            // 
            this.gvgiohang1BindingSource.DataMember = "gvgiohang1";
            this.gvgiohang1BindingSource.DataSource = this.HDBHtheoma;
            // 
            // HDBHtheoma
            // 
            this.HDBHtheoma.DataSetName = "HDBHtheoma";
            this.HDBHtheoma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvgiohang1TableAdapter
            // 
            this.gvgiohang1TableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gvgiohang1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDBHtheoma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gvgiohang1BindingSource;
        private HDBHtheoma HDBHtheoma;
        private HDBHtheomaTableAdapters.gvgiohang1TableAdapter gvgiohang1TableAdapter;
    }
}