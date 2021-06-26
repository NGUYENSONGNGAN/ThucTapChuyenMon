
namespace ThucTapCM
{
    partial class XuatHoaDon
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
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
        //    this.DOANCHUYENMON1DataSet = new ThucTapCM.DOANCHUYENMON1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
        //    this.DOANCHUYENMON7DataSet = new ThucTapCM.DOANCHUYENMON7DataSet();
            this.HDBH_SPBindingSource = new System.Windows.Forms.BindingSource(this.components);
        //    this.HDBH_SPTableAdapter = new ThucTapCM.DOANCHUYENMON7DataSetTableAdapters.HDBH_SPTableAdapter();
         //   this.SanPhamTableAdapter = new ThucTapCM.DOANCHUYENMON1DataSetTableAdapters.SanPhamTableAdapter();
         //   this.DOANCHUYENMON7DataSet3 = new ThucTapCM.DOANCHUYENMON7DataSet3();
            this.areporthdxBindingSource = new System.Windows.Forms.BindingSource(this.components);
         //   this.areporthdxTableAdapter = new ThucTapCM.DOANCHUYENMON7DataSet3TableAdapters.areporthdxTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.DOANCHUYENMON1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.DOANCHUYENMON7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDBH_SPBindingSource)).BeginInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.DOANCHUYENMON7DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areporthdxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
        //    this.SanPhamBindingSource.DataSource = this.DOANCHUYENMON1DataSet;
            // 
            // DOANCHUYENMON1DataSet
            // 
         //   this.DOANCHUYENMON1DataSet.DataSetName = "DOANCHUYENMON1DataSet";
        //    this.DOANCHUYENMON1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewer3
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.areporthdxBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "ThucTapCM.Report2.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(2, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1329, 751);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DOANCHUYENMON7DataSet
            // 
      //      this.DOANCHUYENMON7DataSet.DataSetName = "DOANCHUYENMON7DataSet";
       //     this.DOANCHUYENMON7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HDBH_SPBindingSource
            // 
            this.HDBH_SPBindingSource.DataMember = "HDBH_SP";
      //      this.HDBH_SPBindingSource.DataSource = this.DOANCHUYENMON7DataSet;
            // 
            // HDBH_SPTableAdapter
            // 
       //     this.HDBH_SPTableAdapter.ClearBeforeFill = true;
            // 
            // SanPhamTableAdapter
            // 
       //     this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // DOANCHUYENMON7DataSet3
            // 
        //    this.DOANCHUYENMON7DataSet3.DataSetName = "DOANCHUYENMON7DataSet3";
        //    this.DOANCHUYENMON7DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areporthdxBindingSource
            // 
            this.areporthdxBindingSource.DataMember = "areporthdx";
       //     this.areporthdxBindingSource.DataSource = this.DOANCHUYENMON7DataSet3;
            // 
            // areporthdxTableAdapter
            // 
        //    this.areporthdxTableAdapter.ClearBeforeFill = true;
            // 
            // XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 751);
            this.Controls.Add(this.reportViewer3);
            this.Name = "XuatHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XuatHoaDon";
            this.Load += new System.EventHandler(this.XuatHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.DOANCHUYENMON1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //  ((System.ComponentModel.ISupportInitialize)(this.HDBH_SPBindingSource)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.DOANCHUYENMON7DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areporthdxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource HDBH_SPBindingSource;

        private System.Windows.Forms.BindingSource SanPhamBindingSource;
   
        private System.Windows.Forms.BindingSource areporthdxBindingSource;
  
    }
}