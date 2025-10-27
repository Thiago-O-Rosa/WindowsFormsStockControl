using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using ClassLibraryStoksControl;



namespace ClassLibraryStoksControl
{
    public class ClassUser
    {
        //Propriedade

        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string Tel { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassUser(int _id, string _name, string _email, string _password, string _tel )
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;
            this.Tel = _tel;           
        }
        //Métodos CRUD Read = Select
        public DataTable Entrar(string email, string password)
        {
            var dt = new DataTable(); //var similar a VARCHAR variável temporário
            string sql = "SELECT * FROM USUARIOS WHERE EMAIL=@Email AND SENHA=@Password"; // inserção das informações para verificar no banco de dados

            try
            {
                using (SqlConnection cn = _conn.GetConnection()) //Inicia a conexão com o bd
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // junta os comandos com a conexao
                    {
                        cmd.Parameters.AddWithValue("@Email", email); //parametros
                        cmd.Parameters.AddWithValue("@Password", password);

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
            return dt; //retorna a tabela de dados
        }

        //Function ADMIN
        //CRUD Creat = Insert
        //public bool Registrar()
        //{
        //    string sql = "INSERT INTO Usuario (nome, email, senha) VALUES (@Nome, @Email, @Password)";

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

        //Function Admin
        //CRUD Update = Atualizar
        public bool Atualizar()
        {
            string sql = "UPDATE Usuario SET nome=@Nome, email=@Email, senha=@Password WHERE id_Usuario =@Id_Usuario;";

            try //Tenta executar o comando 
            {

                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
                        cmd.Parameters.AddWithValue("@Id_Usuario", this.Id);
                        cmd.Parameters.AddWithValue("@Nome", this.Name);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@Password", this.Password);


                        //Execução da intrução de Transmisão de Dados (DML)
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
         public DataTable SearchUser (string nome, string tel, string email)
        {
            var dt = new DataTable(); //var similar a VARCHAR variável temporário
        string sql = @"SELECT NOME, TEL, EMAIL FROM USUARIOS WHERE NOME LIKE @NOME AND TEL LIKE @TEL AND EMAIL LIKE @EMAIL;";
            try
            {
                using (SqlConnection cn = _conn.GetConnection()) //Inicia a conexão com o bd
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // junta os comandos com a conexao
                    {
                        cmd.Parameters.AddWithValue("@NOME", "%" + nome + "%"); //parametros
                        cmd.Parameters.AddWithValue("@TEL", "%" + tel + "%");
                        cmd.Parameters.AddWithValue("@EMAIL", "%" + email + "%");
                        

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

        public bool Adicionar()
        {
            string sql = @"INSERT INTO USUARIOS (NOME, TEL, EMAIL, SENHA)  VALUES (@NOME, @TEL, @EMAIL, @SENHA)";

            try //Tenta executar o comando 
            {

                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
                        cmd.Parameters.AddWithValue("@NOME", this.Name);
                        cmd.Parameters.AddWithValue("@TEL", this.Tel);
                        cmd.Parameters.AddWithValue("@EMAIL", this.Email);
                        cmd.Parameters.AddWithValue("@SENHA", this.Password);

                        //Execução da intrução de Transmisão de Dados (DML)
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


        //public bool Remover()
        //{
        //    string sql = "DELETE FROM USUARIOS WHERE NOME = @NOME;";
        //    try //Tenta executar o comando 
        //    {
        //        using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
        //        {
        //            cn.Open();
        //            using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
        //            {
        //                cmd.Parameters.AddWithValue("@NOME", this.Id);
        //            }
        //        }
        //    }
        //    catch (Exception erro)//pega o erro
        //    {
        //        Console.WriteLine(erro.Message);
        //        return false;
        //    }
        //}
        public bool Remover()
        {
            string sql = @"DELETE FROM USUARIOS WHERE NOME LIKE @NOME;";

            try //Tenta executar o comando 
            {

                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
                        cmd.Parameters.AddWithValue("@NOME", this.Name);

                        //Execução da intrução de Transmisão de Dados (DML)
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
    }
}