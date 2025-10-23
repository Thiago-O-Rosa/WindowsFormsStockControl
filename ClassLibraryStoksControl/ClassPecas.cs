using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ClassLibraryStoksControl
{
    public class ClassPecas
    {
        private string nome { get; set; }
        private string Marcas { get; set; }
        private string Modelos { get; set; }
        private int NumeroSeries { get; set; }
        private int Quantidades { get; set; }
        private string Responsaveis { get; set; }
        private DateTime DataHoraRet { get; set; }
        private DateTime DataHoraDev { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassPecas(string _nome, string _marca, string _modelo, int _numeroSerie, int _quantidade, string _responsavel, DateTime _dataHoraRet, DateTime _dataHoraDev)
        {

            this.nome = _nome;
            this.Marcas = _marca;
            this.Modelos = _modelo;
            this.NumeroSeries = _numeroSerie;
            this.Quantidades = _quantidade;
            this.Responsaveis = _responsavel;
            this.DataHoraRet = _dataHoraRet;
            this.DataHoraDev = _dataHoraDev;
        }


        public string Search(string nome)
        {
            var dt = new DataTable(); //var similar a VARCHAR variável temporário
            string sql = "SELECT * FROM PRODUTOS WHERE NOME LIKE @NOME ;"; // inserção das informações para verificar no banco de dados

            try
            {
                using (SqlConnection cn = _conn.GetConnection()) //Inicia a conexão com o bd
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // junta os comandos com a conexao
                    {
                        cmd.Parameters.AddWithValue("@NOME", nome + "%"); //parametros


                        // cmd serve como a ponte entre o da e o dt
                        //sql é utilizado para ligar os parametros entre o c# e o sql server

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd)) //injeta as informações digitadas na tabela de dados
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }

            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            return dt;
        }
    }
}
