using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryStoksControl;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;

namespace WindowsFormsStockControl
{
    public partial class _UserControlAdicionar : UserControl
    {
        public _UserControlAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

            string material = tbxNomeMat.Text;
            string modelo = tbxModelo.Text;
            string marca = cbxMarca.Text;
            string categoria = cbxCategoria.Text;
            string localizicao = cbxLocal.Text;
            string qtde = tbxQtde.Text;
            string userCadastro = cbxUserCadastro.Text;
            string numSerie = tbxNumSerie.Text;


            ClassPecas _addMaterial = new ClassPecas(material, modelo, marca, numSerie, 0, 0, qtde, categoria, numSerie, localizicao, 0, userCadastro);

            if (tbxNomeMat.Text != "" &&
                tbxModelo.Text != "" &&
                tbxNumSerie.Text != "" &&
                tbxQtde.Text != "" &&
                cbxCategoria.Text != "" &&
                cbxLocal.Text != "" &&
                cbxMarca.Text != "" &&
                cbxUserCadastro.Text != "" &&
                cbxCategoria.Text != "")
            {
                if (_addMaterial.AddMaterial())
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

            tbxNomeMat.Text = "";
            tbxModelo.Text = "";
            cbxMarca.Text = "";
            cbxCategoria.Text = "";
            cbxLocal.Text = "";
            tbxQtde.Text = "";
            cbxUserCadastro.Text = "";
            tbxNumSerie.Text = "";

        }


        private void tbxNomeMat_TextChanged(object sender, EventArgs e)
        {


            if (tbxNomeMat.Text != "")
            {
                //Inicialização e Preparação
                string nomeMat = tbxNomeMat.Text;
                string modelo = tbxModelo.Text;





                //Instanciação da classe
                ClassPecas _classPecas = new ClassPecas("", "", "", "", 0, 0, "", "", "", "", 0, "");

                //Pesquisar na Tabela
                DataTable _dt = _classPecas.PesquisaMaterial(nomeMat, modelo, "", "", "", "", "", "");

                //Atualizar DataGridView
                dgvMaterial.DataSource = _dt;
            }
            else
            {
                dgvMaterial.DataSource = null;

            }
        }
        private void dgvMaterial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dgvMaterial.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                tbxNomeMat.Text = dgvMaterial.Rows[hit.RowIndex].Cells["MATERIAL"].Value.ToString();
                tbxModelo.Text = dgvMaterial.Rows[hit.RowIndex].Cells["MODELO"].Value.ToString();
                cbxMarca.Text = dgvMaterial.Rows[hit.RowIndex].Cells["MARCA"].Value.ToString();
                cbxCategoria.Text = dgvMaterial.Rows[hit.RowIndex].Cells["CATEGORIA"].Value.ToString();
                cbxLocal.Text = dgvMaterial.Rows[hit.RowIndex].Cells["LOCALIZACAO"].Value.ToString();
                tbxQtde.Text = dgvMaterial.Rows[hit.RowIndex].Cells["QTDE"].Value.ToString();
                cbxUserCadastro.Text = dgvMaterial.Rows[hit.RowIndex].Cells["USUARIO_CADASTRO"].Value.ToString();
                tbxNumSerie.Text = dgvMaterial.Rows[hit.RowIndex].Cells["NUM_SERIE"].Value.ToString();

            }
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvMaterial.Text != "")
            //{
            //    //Inicialização e Preparação
            //    string material = dgvMaterial.Text;


            //    //Instanciação da classe
            //    ClassUser _classUser = new ClassUser(0, "", "", "", "");


            //    //Pesquisar na Tabela
            //    DataTable _dt = _classUser.SearchUser(material, "", "");

            //    //Atualizar DataGridView
            //    dgvMaterial.DataSource = _dt;
            //}
            //else
            //{
            //    dgvMaterial.DataSource = null;
            //}
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void cbxUserCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
} 
