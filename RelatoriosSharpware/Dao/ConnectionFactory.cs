using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace RelatoriosSharpware.Dao
{
    class ConnectionFactory
    {
        private ConnectionFactory()
        { }
/*
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString());
        }
        */
    }
}
