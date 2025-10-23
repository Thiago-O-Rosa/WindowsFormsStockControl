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

namespace WindowsFormsStockControl
{
    public partial class UserControlRelacMat : UserControl
    {
        public UserControlRelacMat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvRelacMat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dgvProduct.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {

                tbxSearch.Text = dgvProduct.Rows[hit.RowIndex].Cells["NOME"].Value.ToString();
                //    bool ativo = Convert.ToBoolean(dgvProduct.Rows[hit.RowIndex].Cells["STATUS"].Value.ToString());
                //    if (ativo)
                //    {
                //        rbtnStored.Checked = ativo;

                //    }
                //    else
                //    {
                //        rbtnStored.Checked = !ativo;
                //    }
                //}
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            {

                if(tbxSearch.Text != "")
{
                    // Inicialização e Preparação
                    string produto = tbxSearch.Text;

                    // Instanciação da classe
                    ClassPecas produtos = new ClassPecas("", "", "", 0, 0, "", 0, 0);

                    // Pesquisar na tabela
                    DataTable dt = produtos.Search(produto);

                    // Atualizar DataGridView
                    dgvProduct.DataSource = dt;
                }
                else
                {
                    dgvProduct.DataSource = null;
                }


            }
        }
    }
}
