using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RelatoriosSharpware.Model;


namespace RelatoriosSharpware.Dao
{
    public class RelatorioVendaClienteDao
    {

        private MySqlConnection _con;

        public RelatorioVendaClienteDao(MySqlConnection con)
        {
            _con = con;
        }
        public RelatorioVendaClienteModel relatorioVendaClienteModel;

        public RelatorioVendaClienteModel BuscarVenda(int id)
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
                             ON cli.id = ven.cliente_id
                             INNER JOIN funcionario fun
                             ON fun.id = ven.funcionario_id
                             WHERE ven.id = @VENDA";

            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Connection.Open();
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@VENDA", id);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        RelatorioVendaClienteModel RelVenda = new RelatorioVendaClienteModel();
                        RelVenda.IdVenda = reader.GetInt32("vend.id");
                        RelVenda.DataVenda = reader.GetDateTime("vend.data_venda");
                        RelVenda.ValorVenda = reader.GetDouble("vend.valor_total");
                        RelVenda.TipoVenda = reader.GetString("vend.tipo_venda");
                        RelVenda.NomeCliente = reader.GetString("cli.nome");
                        RelVenda.EmailCliente = reader.GetString("cli.email");
                        RelVenda.CpfCliente = reader.GetString("cli.cpf");
                        RelVenda.NomeFuncionario = reader.GetString("fun.nome");
                        relatorioVendaClienteModel = RelVenda;
                    }
                }
            }
            reader.Close();
            return relatorioVendaClienteModel;
        }

        public List<RelatorioVendaClienteModel> BuscarListaItensProduto(int idVenda)
        {
            try
            {
                MySqlDataReader reader = null;
                List<RelatorioVendaClienteModel> itensRelatorioVendaCliente;
                string cmdBuscarNomeFuncionario = @"
                                                  SELECT 
                                                  itnven.quantidade,
                                                  itnven.valor_total,
                                                  prod.nome,
                                                  prod.marca,
                                                  prod.tamanho,
                                                  prod.codigo_barra
                                                  FROM venda ven
                                                  INNER JOIN itens_venda itnven
                                                  ON itnven.venda_id = ven.id
                                                  INNER JOIN produto prod
                                                  ON prod.id = itnven.produto_id
                                                  WHERE ven.id = @VENDA";

                using (MySqlCommand cmd = new MySqlCommand(cmdBuscarNomeFuncionario, _con))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@VENDA", idVenda);
                    reader = cmd.ExecuteReader();
                    itensRelatorioVendaCliente = new List<RelatorioVendaClienteModel>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            RelatorioVendaClienteModel _itensRelatorioVendaCliente = new RelatorioVendaClienteModel();
                            _itensRelatorioVendaCliente.QuantidadeItem = reader.GetInt32("itnven.quantidade");
                            _itensRelatorioVendaCliente.ValorTotalItem = reader.GetDouble("itnven.valor_total");
                            _itensRelatorioVendaCliente.NomeProduto = reader.GetString("prod.nome");
                            _itensRelatorioVendaCliente.MarcaProduto = reader.GetString("prod.marca");
                            _itensRelatorioVendaCliente.TamanhoProduto = reader.GetString("prod.tamanho");
                            _itensRelatorioVendaCliente.CodigoBarrasProduto = reader.GetString("prod.codigo_barra");
                            itensRelatorioVendaCliente .Add(_itensRelatorioVendaCliente);
                        }
                    }
                    return itensRelatorioVendaCliente;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }

    }
}
