using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;


namespace RelatoriosSharpware.Dao
{
    public class ConnectionFactory
    {
        private ConnectionFactory()
        { }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString());
        }
        
    }
}
