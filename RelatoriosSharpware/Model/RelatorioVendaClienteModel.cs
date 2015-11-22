using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelatoriosSharpware.Model
{
    class RelatorioVendaClienteModel
    {

        private Int32 parametroIdVenda;
        private string nomeCliente;
        private string cpfCliente;
        private string emailCliente;
        private Int32 idVenda;
        private DateTime dataVenda;
        private Double valorVenda;
        private string tipoVenda;
        private string nomeFuncionario;

        public String NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public String CpfCliente
        {
            get { return cpfCliente; }
            set { cpfCliente = value; }
        }

        public string EmailCliente
        {
            get { return emailCliente; }
            set { emailCliente = value; }
        }

        public Int32 IdVenda
        {
            get { return idVenda; }
            set { idVenda = value; }
        }

        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }

        public Double ValorVenda
        {
            get { return valorVenda; }
            set { valorVenda = value; }
        }

        public string TipoVenda
        {
            get { return tipoVenda; }
            set { tipoVenda = value; }
        }

        public string NomeFuncionario
        {
            get { return nomeFuncionario; }
            set { nomeFuncionario = value; }
        }

        // Parametro para select .....
        public Int32 ParametroIdVenda
        {
            get { return parametroIdVenda; }
            set { parametroIdVenda = value; }
        }
    }
}
