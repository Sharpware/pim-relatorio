namespace RelatoriosSharpware
{
    partial class ExibirRelatoriofrm
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
            this.ItensRelatorioVendaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioVendaClienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ItensRelatorioVendaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioVendaClienteModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Relatorio";
            reportDataSource1.Value = this.RelatorioVendaClienteModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RelatoriosSharpware.Report.Relatorio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(471, 430);
            this.reportViewer1.TabIndex = 0;
            // 
            // RelatorioVendaClienteModelBindingSource
            // 
            this.RelatorioVendaClienteModelBindingSource.DataSource = typeof(RelatoriosSharpware.Model.RelatorioVendaClienteModel);
            // 
            // ExibirRelatoriofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 430);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExibirRelatoriofrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio SharpWare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExibirRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItensRelatorioVendaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioVendaClienteModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ItensRelatorioVendaClienteBindingSource;
        private System.Windows.Forms.BindingSource RelatorioVendaClienteModelBindingSource;
    }
}

