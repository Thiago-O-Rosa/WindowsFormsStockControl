using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStoksControl
{
    public class ConnClass
    {
        //Propriedades
        private const string Server = "DESKTOP-JUKC89G\\SQLSERVER"; // nome server
        private const string DataBase = "DB_APEX_STOCK"; // nome do banco de dados
        private const string User = "sa"; // nome do usuario dp bd
        private const string Password = "0802"; // senha do bd

        //string (cadeia)  de conexão
        public string StrConn =
            $"Data Source={Server}; " +
            $"Initial Catalog={DataBase}; " +
            $"User Id={User}; " +
            $"Password={Password};" +
            $"Encrypt= False";


        //método para conectar com banco de dados


        public SqlConnection GetConnection()
        {
            SqlConnection _conn = new SqlConnection(StrConn);
            return _conn;
        }
    }
}
