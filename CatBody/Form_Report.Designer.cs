namespace CatBody
{
    partial class Form_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Report));
            this.Rekam_MedisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catBodyDataSet = new CatBody.CatBodyDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rekamMedisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rekam_MedisTableAdapter = new CatBody.CatBodyDataSetTableAdapters.Rekam_MedisTableAdapter();
            this.KucingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rekam_MedisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rekamMedisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KucingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Rekam_MedisBindingSource
            // 
            this.Rekam_MedisBindingSource.DataMember = "Rekam_Medis";
            this.Rekam_MedisBindingSource.DataSource = this.catBodyDataSet;
            // 
            // catBodyDataSet
            // 
            this.catBodyDataSet.DataSetName = "CatBodyDataSet";
            this.catBodyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Rekam_MedisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CatBody.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1418, 968);
            this.reportViewer1.TabIndex = 0;
            // 
            // rekamMedisBindingSource
            // 
            this.rekamMedisBindingSource.DataMember = "Rekam_Medis";
            this.rekamMedisBindingSource.DataSource = this.catBodyDataSet;
            // 
            // rekam_MedisTableAdapter
            // 
            this.rekam_MedisTableAdapter.ClearBeforeFill = true;
            // 
            // KucingBindingSource
            // 
            this.KucingBindingSource.DataMember = "Kucing";
            this.KucingBindingSource.DataSource = this.catBodyDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 936);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1418, 32);
            this.button2.TabIndex = 83;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Report";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rekam_MedisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBodyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rekamMedisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KucingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CatBodyDataSet catBodyDataSet;
        private System.Windows.Forms.BindingSource rekamMedisBindingSource;
        private CatBodyDataSetTableAdapters.Rekam_MedisTableAdapter rekam_MedisTableAdapter;
        private System.Windows.Forms.BindingSource Rekam_MedisBindingSource;
        private System.Windows.Forms.BindingSource KucingBindingSource;
        private System.Windows.Forms.Button button2;
    }
}