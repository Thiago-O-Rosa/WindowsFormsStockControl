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
        private string Categoria { get; set; }
        private string Num_serie { get; set; }
        private DateTime Data_entrada { get; set; }
        private string Localizacao { get; set; }
        private string Qtde { get; set; }
        private int Id_produto { get; set; }
        private int Id_usuario { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassPecas(string _produto, string _marca, string _modelo, int _numeroSerie, int _quantidade, string _responsavel, int _dataHoraRet, int _dataHoraDev, string _categoria, string _num_serie, DateTime _data_entrada, string _localizacao, string _qtde, int _id_produto, int _id_usuario )
        {

            this.Produto = _produto;
            this.Marcas = _marca;
            this.Modelos = _modelo;
            this.NumeroSeries = _numeroSerie;
            this.Quantidades = _quantidade;
            this.Responsaveis = _responsavel;
            this.DataHoraRet = _dataHoraRet;
            this.DataHoraDev = _dataHoraDev;
            this.Categoria = _categoria;
            this.Num_serie = _num_serie;
            this.Data_entrada = _data_entrada;
            this.Localizacao = _localizacao;
            this.Qtde = _qtde;
            this.Id_produto = _id_produto;
            this.Id_usuario = _id_usuario;

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
        //public bool REGISTRAR()
        //{
        //    string sql = "INSERT INTO PRODUTO (PRODUTO, MODELO, FK_MARCAS_ID_MARCA ) VALUES (@PRODUTO, @MODELO, @FK_MARCAS_ID_MARCA)";

        //    try //Tenta executar o comando 
        //    {

        //        using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
        //        {
        //            cn.Open();
        //            using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
        //            {
        //                cmd.Parameters.AddWithValue("@Nome", this.Name);
        //                cmd.Parameters.AddWithValue("@Email", this.Email);
        //                cmd.Parameters.AddWithValue("@Password", this.Password);

        //                //Execução da intrução de Transmisão de Dados (DML)
        //                int linhasAfetadas = cmd.ExecuteNonQuery();
        //                return linhasAfetadas > 0;
        //            }
        //        }
        //    }
        //    catch (Exception erro)//pega o erro
        //    {
        //        Console.WriteLine(erro.Message);
        //        return false;
        //    }

    //}
    public bool AddMaterial()
    {
        string sql = @"
                BEGIN
                  INSERT INTO PRODUTO (PRODUTO, MODELO, FK_MARCAS_ID_MARCA, FK_CATEGORIAS_ID_CATEGORIA)
                  VALUES (@PRODUTO, @MODELO, @FK_MARCAS_ID_MARCA, @FK_CATEGORIAS_ID_CATEGORIA);

                  DECLARE @ID_PRODUTO INT = SCOPE_IDENTITY();

                  INSERT INTO ITENS (NUM_SERIE, DATA_ENTRADA, LOCALIZACAO, QTDE, FK_PRODUTOS_ID_PRODUTO, FK_USUARIOS_ID_USUARIO)
                  VALUES (@NUM_SERIE, @DATA_ENTRADA, @LOCALIZACAO, @QTDE, @ID_PRODUTO, @FK_USUARIOS_ID_USUARIO);
                END
                ";

        try //Tenta executar o comando 
        {

            using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                {
                    cmd.Parameters.AddWithValue("@PRODUTOS", this.Produto);
                    cmd.Parameters.AddWithValue("@MODELO", this.Modelos);
                    cmd.Parameters.AddWithValue("@FK_MARCAS_ID_MARCA", this.Marcas);
                    cmd.Parameters.AddWithValue("@FK_CATEGORIAS_ID_CATEGORIA", this.Categoria);
                    cmd.Parameters.AddWithValue("@NUM_SERIE", this.Num_serie);
                    cmd.Parameters.AddWithValue("@DATA_ENTRADA", this.Data_entrada);
                    cmd.Parameters.AddWithValue("@LOCALIZACAO", this.Localizacao);
                    cmd.Parameters.AddWithValue("@QTDE", this.Qtde);
                    cmd.Parameters.AddWithValue("@FK_PRODUTOS_ID_PRODUTO", this.Id_produto);
                    cmd.Parameters.AddWithValue("@FK_USUARIOS_ID_USUARIO", this.Id_usuario);

                        //Execução da intrução de Transmisão de Dados (DML)
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        sql = @"INSERT INTO ITENS (NUM_SERIE, LOCALIZACAO, FK_PRODUTOS_ID_PRODUTO)  VALUES (
]                                   @NUM_SERIE, 
                                    @LOCALIZACAO, 
                                    (SELECT TOP(1) ID_PRODUTO FROM PRODUTOS ORDER BY ID_PRODUTO DESC)
                            );";

                            cmd.Parameters.AddWithValue("@PRODUTOS", this.Produto);
                            cmd.Parameters.AddWithValue("@MODELO", this.Modelos);
                            cmd.Parameters.AddWithValue("@FK_MARCAS_ID_MARCA", this.Marcas);
                            cmd.Parameters.AddWithValue("@FK_CATEGORIAS_ID_CATEGORIA", this.Categoria);
                    }

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
}
        
}
