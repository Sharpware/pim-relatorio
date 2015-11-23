using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RelatoriosSharpware.Controller;
using RelatoriosSharpware.Model;

namespace RelatoriosSharpware
{
    public partial class ExibirRelatoriofrm : Form
    {
        public ExibirRelatoriofrm()
        {
            InitializeComponent();
        }

        private void ExibirRelatorio_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();

        }
    }
}
