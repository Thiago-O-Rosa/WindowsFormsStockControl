using ClassLibraryStoksControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStockControl
{
    public partial class _UserControlRemover : UserControl
    {
        public _UserControlRemover()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void tbxPesquisaUser_TextChanged(object sender, EventArgs e)
        {
            if (tbxPesquisaUser.Text != "")
            {
                //Inicialização e Preparação
                string nome = tbxPesquisaUser.Text;
                //string tel = tbxPesquisaUser.Text;
                //string email = tbxPesquisaUser.Text;

                //Instanciação da classe
                ClassUser _classUser = new ClassUser(0, "", "", "","");


                //Pesquisar na Tabela
                DataTable _dt = _classUser.SearchUser(nome, "", "");

                //Atualizar DataGridView
                dgvUsuario.DataSource = _dt;
            }
            else
            {
                dgvUsuario.DataSource = null;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;
            string email = tbxEmail.Text;
            string senha = tbxSenha.Text;
            string tel = tbxTel.Text;

            ClassUser _user = new ClassUser(0, nome, email, senha, tel);

            if (tbxEmail.Text != null && tbxNome.Text != null & tbxTel.Text != null && tbxSenha.Text != null)
            {
                if (_user.Adicionar())
                {
                    MessageBox.Show("Sucesso");
                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

            tbxNome.Text = "";
            tbxEmail.Text = "";
            tbxSenha.Text = "";
            tbxTel.Text = "";

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            string nome = tbxNome.Text;
            string email = tbxEmail.Text;
            string senha = tbxSenha.Text;
            string tel = tbxTel.Text;

            ClassUser _user = new ClassUser(0, nome, email, senha, tel);
            if (_user.Remover())
            {
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("erro");
            }

            tbxNome.Text = "";
            tbxEmail.Text = "";
            tbxSenha.Text = "";
            tbxTel.Text = "";
            tbxPesquisaUser.Text = "";

            dgvUsuario.DataSource = null;
           

        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //// Garante que o usuário clicou em uma linha válida (não no cabeçalho)
            //if (e.RowIndex < 0) return;

            //// 1. Pega a linha (Row) que foi clicada
            //DataGridViewRow linhaSelecionada = dgvUsuario.Rows[e.RowIndex];

            //try
            //{

            //    // O nome da coluna (dentro das chaves []) deve ser o nome EXATO
            //    // que você deu no seu SELECT SQL (ex: NUM_SERIE, PRODUTO, NOME, etc.).

            //    string nome = linhaSelecionada.Cells["NOME"].Value?.ToString() ?? "";
            //    string tel = linhaSelecionada.Cells["TEL"].Value?.ToString() ?? "";
            //    string email = linhaSelecionada.Cells["EMAIL"].Value?.ToString() ?? "";

            //    ClassUser _classUser = new ClassUser(0, "", "", "", "");

            //    // método para carregar os dados
            //    _classUser.SearchUser(nome, tel, email);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Erro ao carregar os dados do item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            var hit = dgvUsuario.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {

         
                tbxNome.Text = dgvUsuario.Rows[hit.RowIndex].Cells["NOME"].Value.ToString();
                tbxTel.Text = dgvUsuario.Rows[hit.RowIndex].Cells["TEL"].Value.ToString();
                tbxEmail.Text = dgvUsuario.Rows[hit.RowIndex].Cells["EMAIL"].Value.ToString();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar =  '\0';
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar = '*';
        }

        private void tbxTel_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxTel.MaxLength = 11;

            // Permite apenas dígitos e tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a tecla
            }

        }
    }
}
