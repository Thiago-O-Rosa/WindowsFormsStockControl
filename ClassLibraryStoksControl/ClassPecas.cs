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
using System.Text.RegularExpressions;



namespace ClassLibraryStoksControl
{
    public class ClassPecas
    {
        private string Material {  get; set; }
        private string Produto { get; set; }
        private string Marcas { get; set; }
        private string Modelos { get; set; }
        private int NumeroSeries { get; set; }
        private int Quantidades { get; set; }
        private string Responsaveis { get; set; }
        private string Categoria { get; set; }
        private string Num_serie { get; set; }
        private string Localizacao { get; set; }
        private int Qtde { get; set; }
        private string UserCadastro { get; set; }
       

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassPecas(string _material, string _produto, string _marca, string _modelo, int _numeroSerie, int _quantidade, string _responsavel, string _categoria, string _num_serie, string _localizacao, int _qtde, string _userCadastro)
        {
            this.Material = _material;
            this.Produto = _produto;
            this.Marcas = _marca;
            this.Modelos = _modelo;
            this.NumeroSeries = _numeroSerie;
            this.Quantidades = _quantidade;
            this.Responsaveis = _responsavel;
            this.Categoria = _categoria;
            this.Num_serie = _num_serie;
            this.Localizacao = _localizacao;
            this.Qtde = _qtde;
            this.UserCadastro = _userCadastro;


        }


        public DataTable Search(string nome, string num_serie, string localizacao, string produto, string modelo, string _marca)
         {
            var dt = new DataTable(); //var similar a VARCHAR variável temporário
            string sql = @"                    
                            SELECT
                                I.NUM_SERIE,
                                I.LOCALIZACAO,
                                P.PRODUTO,
                                P.MODELO,
                                M.MARCA
                            FROM
                                ITENS AS I
                            JOIN
                                PRODUTOS AS P ON I.FK_PRODUTOS_ID_PRODUTO = P.ID_PRODUTO
                            JOIN
                                USUARIOS AS U ON I.FK_USUARIOS_ID_USUARIO = U.ID_USUARIO
                            JOIN 
                                MARCAS AS M ON P.FK_MARCAS_ID_MARCA = M.ID_MARCA
                            WHERE
                                I.NUM_SERIE LIKE @NUM_SERIE
                                AND I.LOCALIZACAO LIKE @LOCALIZACAO
                                AND P.PRODUTO LIKE @PRODUTO
                                AND P.MODELO LIKE @MODELO
                                AND U.NOME LIKE @NOME
                                AND M.MARCA LIKE @MARCA  ;";
            try
            {
                using (SqlConnection cn = _conn.GetConnection()) //Inicia a conexão com o bd
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // junta os comandos com a conexao
                    {
                        cmd.Parameters.AddWithValue("@NUM_SERIE", num_serie + "%"); //parametros
                        cmd.Parameters.AddWithValue("@LOCALIZACAO", localizacao + "%");
                        cmd.Parameters.AddWithValue("@PRODUTO", produto + "%");
                        cmd.Parameters.AddWithValue("@MODELO", modelo  + "%");
                        cmd.Parameters.AddWithValue("@NOME", nome + "%");
                        cmd.Parameters.AddWithValue("@MARCA", _marca + "%");

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
        
        public bool AddMaterial()
        {
            string sql = @"INSERT INTO ADD_MATERIAL(MATERIAL, MODELO, MARCA, CATEGORIA, LOCALIZACAO, QTDE, USUARIO_CADASTRO, NUM_SERIE)
                           VALUES (@MATERIAL, @MODELO, @MARCA, @CATEGORIA, @LOCALIZACAO, @QTDE, @USUARIO_CADASTRO, @NUM_SERIE);";

            try //Tenta executar o comando 
            {

                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
                        cmd.Parameters.AddWithValue("@MATERIAL", this.Material);
                        cmd.Parameters.AddWithValue("@MODELO", this.Modelos);
                        cmd.Parameters.AddWithValue("@MARCA", this.Marcas);
                        cmd.Parameters.AddWithValue("@CATEGORIA", this.Categoria);
                        cmd.Parameters.AddWithValue("@LOCALIZACAO", this.Localizacao);
                        cmd.Parameters.AddWithValue("@QTDE", this.Qtde);
                        cmd.Parameters.AddWithValue("@USUARIO_CADASTRO", this.UserCadastro);
                        cmd.Parameters.AddWithValue("@NUM_SERIE", this.Num_serie);

                        //Execução da intrução de Transmisão de Dados(DML)
                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)//pega o erro
            {
                Console.WriteLine(erro.Message);
                return false;
            }

        }
        public DataTable PesquisaMaterial(string material, string modelo, string marca, string categoria, string localizacao, string qtde, string user_cadastro, string num_serie)
        {
            var dt = new DataTable(); //var similar a VARCHAR variável temporário
            string sql = @"SELECT MATERIAL, MODELO, MARCA, CATEGORIA, LOCALIZACAO, QTDE, USUARIO_CADASTRO, NUM_SERIE
                            FROM ADD_MATERIAL
                            WHERE MATERIAL = @MATERIAL
                              AND MODELO = @MODELO
                              AND MARCA = @MARCA
                              AND CATEGORIA = @CATEGORIA
                              AND LOCALIZACAO = @LOCALIZACAO
                              AND QTDE = @QTDE
                              AND USUARIO_CADASTRO = @USUARIO_CADASTRO
                              AND NUM_SERIE = @NUM_SERIE;";
            try
            {
                using (SqlConnection cn = _conn.GetConnection()) //Inicia a conexão com o bd
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // junta os comandos com a conexao
                    {
                        cmd.Parameters.AddWithValue("@MATERIAL",  material + "%"); //parametros
                        //cmd.Parameters.AddWithValue("@MODELO",  modelo + "%");
                        //cmd.Parameters.AddWithValue("@MARCA", marca + "%");
                        //cmd.Parameters.AddWithValue("@MODELO", modelo + "%");
                        //cmd.Parameters.AddWithValue("@CATEGORIA", categoria + "%");
                        //cmd.Parameters.AddWithValue("@LOCALIZACAO",  localizacao + "%");
                        //cmd.Parameters.AddWithValue("@QTDE", qtde);
                        //cmd.Parameters.AddWithValue("@USUARIO_CADASTRO", user_cadastro + "%");
                        //cmd.Parameters.AddWithValue("@NUM_SERIE", num_serie + "%");

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
