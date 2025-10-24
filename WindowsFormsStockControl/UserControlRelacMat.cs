using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryStoksControl;

namespace WindowsFormsStockControl
{
    public partial class UserControlRelacMat : UserControl
    {
        public UserControlRelacMat()
        {
            InitializeComponent();
            userControlCautela1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvRelacMat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var hit = dgvProduct.HitTest(e.X, e.Y);

            //if (hit.RowIndex >= 0)
            //{

            //    tbxSearch.Text = dgvProduct.Rows[hit.RowIndex].Cells["NOME"].Value.ToString();
            //    //    bool ativo = Convert.ToBoolean(dgvProduct.Rows[hit.RowIndex].Cells["STATUS"].Value.ToString());
            //    //    if (ativo)
            //    //    {
            //    //        rbtnStored.Checked = ativo;

            //    //    }
            //    //    else
            //    //    {
            //    //        rbtnStored.Checked = !ativo;
            //    //    }
            //    //}
            //}
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
//            {

//                if(tbxSearch.Text != "")
//{
//                    // Inicialização e Preparação
//                    string produto = tbxSearch.Text;
//                    string nome = "";

//                    // Instanciação da classe
//                    ClassPecas produtos = new ClassPecas("", "", "", 0, 0, "", 0, 0);

//                    // Pesquisar na tabela
//                    DataTable dt = produtos.Search(nome,  num_serie,  localizacao,  produto,  modelo);

//                    // Atualizar DataGridView
//                    dgvProduct.DataSource = dt;
//                }
//                else
//                {
//                    dgvProduct.DataSource = null;
//                }


//            }
        }

        private void pbxPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            // Inicialização e Preparação
            string termoBusca = tbxSearch.Text.Trim(); // O que o usuário digitou

            string produto = termoBusca;
            //string nome = termoBusca;
            //string num_serie = termoBusca;
            //string localizacao = termoBusca;          
            //string modelo = termoBusca;

            // Instanciação da classe
            ClassPecas _produtos = new ClassPecas("", "", "", 0, 0, "", 0, 0);

            try
            {
                // 2. Chama o método Search corrigido, que retorna o DataTable
                DataTable resultados = _produtos.Search("","","",produto,"","");

                // 3. Atribui o DataTable como a fonte de dados do DataGridView
                dgvProduct.DataSource = resultados;

                // Opcional: Mostra uma mensagem se não encontrar nada
                if (resultados.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum item encontrado com os critérios de busca.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // 4. Trata qualquer erro (conexão, permissão, erro de SQL, etc.)
                MessageBox.Show($"Ocorreu um erro durante a pesquisa: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que o usuário clicou em uma linha válida (não no cabeçalho)
            if (e.RowIndex < 0) return;

            // 1. Pega a linha (Row) que foi clicada
            DataGridViewRow linhaSelecionada = dgvProduct.Rows[e.RowIndex];

            try
            {
                
                // O nome da coluna (dentro das chaves []) deve ser o nome EXATO
                // que você deu no seu SELECT SQL (ex: NUM_SERIE, PRODUTO, NOME, etc.).

                string produto = linhaSelecionada.Cells["PRODUTO"].Value?.ToString() ?? "";
                string numSerie = linhaSelecionada.Cells["NUM_SERIE"].Value?.ToString() ?? "";
                string modelo = linhaSelecionada.Cells["MODELO"].Value?.ToString() ?? "";
                string localizacao = linhaSelecionada.Cells["LOCALIZACAO"].Value?.ToString() ?? "";
                //string nome = linhaSelecionada.Cells["NOME"].Value?.ToString() ?? "";
                string marca = linhaSelecionada.Cells["MARCA"].Value?.ToString();

                
                ClassPecas _produtos = new ClassPecas("", "", "", 0, 0, "", 0, 0);

                // método para carregar os dados
                _produtos.Search(produto, numSerie, modelo, localizacao, "" ,marca);

                //
                //UserControlCautela _userControlCautela = new UserControlCautela();
                //_userControlCautela.Show();
                //this.Hide();
                userControlCautela1.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados do item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
