using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelatoriosSharpware.Model
{
    class ItensRelatorioVendaCliente
    {
        private Int32 quantidadeItem;
        private String codigoBarrasProduto;
        private Double valorTotalItem;
        private String nomeProduto;
        private String marcaProduto;
        private String tamanhoProduto;

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
