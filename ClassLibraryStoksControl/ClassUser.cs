using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryStoksControl
{
    public class ClassUser
    {
        //Propriedade

        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassUser(int _id, string _name, string _email, string _password)
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;
        }
        //Métodos CRUD Read = Select
        public DataTable Entrar(string email, string password)
        {
            var dt = new DataTable();//var similar ao VARCHAR // variável temporário
            string sql = "SELECT * FROM usuarios WHERE email=@Email AND senha=@Password";

            try //Tenta executar o comando 
            {

                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))//usando o fill() para injetar o CMD no DT (tabela do sql)
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception erro)//pega o erro
            {
                Console.WriteLine(erro.Message);
            }
            return dt;
        }

        //Function ADMIN
        //CRUD Creat = Insert
        public bool Registrar()
        {
            string sql = "INSERT INTO Usuario (nome, email, senha) VALUES (@Nome, @Email, @Password)";

            try //Tenta executar o comando 
            {

                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
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

        public bool Deletar()
        {
            string sql = "DELETE FROM PRODUTO WHERE ID_PRODUTO = @Id_Produto;";
            try //Tenta executar o comando 
            {
                using (SqlConnection cn = _conn.GetConnection())// usar o cn = conexão no cmd 
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn)) // criando parametos para lincar o SQLServer com o C# 
                    {
                        cmd.Parameters.AddWithValue("@Id_Produto", this.Id);
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