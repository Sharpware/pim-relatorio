using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;



namespace RelatoriosSharpware.Dao
{
    class RelatorioVendaClienteDao
    {

        private MySqlConnection _con;

        public RelatorioVendaClienteDao(MySqlConnection con)
        {
            _con = con;
        }
        public RelatorioVendaCliente relatorioVendaCliente;

        public RelatorioVendaCliente BuscarVenda(int id)
        {
            MySqlDataReader reader = null;
            string cmdText = @"
                             SELECT
                             ven.id,
                             ven.data_venda,
                             ven.valor_total,
                             ven.tipo_venda,
                             cli.nome,
                             cli.email,
                             cli.cpf,
                             fun.nome
                             FROM venda ven
                             INNER JOIN cliente cli 
                             ON cli.id = ven.id_cliente
                             INNER JOIN funcionario fun
                             ON fun.id = ven.id_funcionario
                             WHERE ven.id = @VENDA";

            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@VENDA", id);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    RelatorioVendaCliente relatorioVendaCliente;
                    while (reader.Read())
                    {
                        RelatorioVendaCliente RelVenda = new RelatorioVendaCliente();
                        RelVenda.IdVenda = reader.GetInt32("vend.id");
                        RelVenda.DataVenda = reader.GetDateTime("vend.data_venda");
                        RelVenda.ValorVenda = reader.GetDouble("vend.valor_total");
                        RelVenda.TipoVenda = reader.GetString("vend.tipo_venda");
                        RelVenda.NomeCliente = reader.GetString("cli.nome");
                        RelVenda.EmailCliente = reader.GetString("cli.email");
                        RelVenda.CpfCliente = reader.GetString("cli.cpf");
                        RelVenda.NomeFuncionario = reader.GetString("fun.nome");
                        relatorioVendaCliente = RelVenda;
                    }
                }
            }
            reader.Close();
            return relatorioVendaCliente;
        }

        public void BuscarListaItensProduto(int idVenda)
        {

        }

    }
}
