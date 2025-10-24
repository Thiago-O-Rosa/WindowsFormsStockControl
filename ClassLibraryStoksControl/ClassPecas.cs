using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;



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


        public DataTable Search(string nome, string num_serie, string localizacao, string produto, string modelo)
             
        {
            var dt = new DataTable(); //var similar a VARCHAR variável temporário
            string sql = @"
            SELECT
                I.NUM_SERIE,
                I.LOCALIZACAO,
                P.PRODUTO,
                P.MODELO,
                U.NOME
            FROM
                ITENS AS I
            JOIN
                PRODUTOS AS P ON I.FK_PRODUTOS_ID_PRODUTO = P.ID_PRODUTO
            JOIN
                USUARIOS AS U ON I.FK_USUARIOS_ID_USUARIO = U.ID_USUARIO
            WHERE
                I.NUM_SERIE LIKE @NUM_SERIE
                AND I.LOCALIZACAO LIKE @LOCALIZACAO
                AND P.PRODUTO LIKE @PRODUTO
                AND P.MODELO LIKE @MODELO
                AND U.NOME LIKE @NOME;
                    ";
            try
            {
                using (SqlConnection cn = _conn.GetConnection()) //Inicia a conexão com o bd
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // junta os comandos com a conexao
                    {
                        cmd.Parameters.AddWithValue("@NUM_SERIE", (num_serie ?? "") + "%"); //parametros
                        cmd.Parameters.AddWithValue("@LOCALIZACAO", (localizacao ?? "") + "%");
                        cmd.Parameters.AddWithValue("@PRODUTO", (produto ?? "") + "%");
                        cmd.Parameters.AddWithValue("@MODELO", (modelo ?? "") + "%");
                        cmd.Parameters.AddWithValue("@NOME", (nome ?? "") + "%");


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
