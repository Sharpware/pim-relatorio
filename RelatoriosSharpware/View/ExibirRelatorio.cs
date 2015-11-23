using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RelatoriosSharpware.Controller;

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
            RelatorioVendaClienteController relatorio = new RelatorioVendaClienteController();
            relatorio.BuscarVenda(16);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();

        }
    }
}
