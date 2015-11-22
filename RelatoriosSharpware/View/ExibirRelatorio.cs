using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            this.reportViewer1.RefreshReport();
        }
    }
}
