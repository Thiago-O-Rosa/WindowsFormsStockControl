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
        private const string Server = "TAU0712119W11-1\\SQLEXPRESS"; // nome server
        private const string DataBase = "DB_APEXSTOCK"; // nome do banco de dados
        private const string User = "senac"; // nome do usuario dp bd
        private const string Password = "senac"; // senha do bd

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
