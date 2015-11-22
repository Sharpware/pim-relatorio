using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RelatoriosSharpware.Dao;
using RelatoriosSharpware.Model;

namespace RelatoriosSharpware.Controller
{
    class RelatorioVendaClienteController
    {

        RelatorioVendaClienteDao _relatorioVendaClienteDao;

        public RelatorioVendaClienteController()
        {
           // var con = ConnectionFactory.GetConnection();
         //   _relatorioVendaClienteDao = new RelatorioVendaClienteDao(con);
        }

        public void BuscarVenda(int id)
        {
            _relatorioVendaClienteDao.BuscarVenda(id);
            _relatorioVendaClienteDao.BuscarListaItensProduto(id);
        }

        public void AbreRelatorio() 
        {
            ExibirRelatoriofrm relatorio = new ExibirRelatoriofrm();


        }

    }
}
