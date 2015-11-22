using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelatoriosSharpware.Model
{
    public class RelatorioVendaClienteModel
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
        //Itens
        private Int32 quantidadeItem;
        private String codigoBarrasProduto;
        private Double valorTotalItem;
        private String nomeProduto;
        private String marcaProduto;
        private String tamanhoProduto;

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

        //Itens
        public Int32 QuantidadeItem
        {
            get { return quantidadeItem; }
            set { quantidadeItem = value; }
        }
        public Double ValorTotalItem
        {
            get { return valorTotalItem; }
            set { valorTotalItem = value; }
        }

        public String NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public String MarcaProduto
        {
            get { return marcaProduto; }
            set { marcaProduto = value; }
        }

        public String TamanhoProduto
        {
            get { return tamanhoProduto; }
            set { tamanhoProduto = value; }
        }

        public String CodigoBarrasProduto
        {
            get { return codigoBarrasProduto; }
            set { codigoBarrasProduto = value; }
        }
    }
}
