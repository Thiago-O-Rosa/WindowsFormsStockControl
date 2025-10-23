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
        private string Produto { get; set; }
        private string Marcas { get; set; }
        private string Modelos { get; set; }
        private int NumeroSeries { get; set; }
        private int Quantidades { get; set; }
        private string Responsaveis { get; set; }
        private int DataHoraRet { get; set; }
        private int DataHoraDev { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassPecas(string _produto, string _marca, string _modelo, int _numeroSerie, int _quantidade, string _responsavel, int _dataHoraRet, int _dataHoraDev)
        {

            this.Produto = _produto;
            this.Marcas = _marca;
            this.Modelos = _modelo;
            this.NumeroSeries = _numeroSerie;
            this.Quantidades = _quantidade;
            this.Responsaveis = _responsavel;
            this.DataHoraRet = _dataHoraRet;
            this.DataHoraDev = _dataHoraDev;
        }


        public DataTable Search(string nome)
        {
            var dt = new DataTable(); //var similar a VARCHAR variável temporário
            string sql = "SELECT * FROM PRODUTOS WHERE PRODUTO LIKE @PRODUTO ;"; // inserção das informações para verificar no banco de dados

            try
            {
                using (SqlConnection cn = _conn.GetConnection()) //Inicia a conexão com o bd
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // junta os comandos com a conexao
                    {
                        cmd.Parameters.AddWithValue("@PRODUTO", nome + "%"); //parametros


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
