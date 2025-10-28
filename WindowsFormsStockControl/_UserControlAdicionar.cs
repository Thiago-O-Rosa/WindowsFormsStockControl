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
            //for(i = 0;i < rows.count; i++)
            //{cbxNumserie.value = dt.addNumLocal "SN00" + i}

            //string produto = tbxNomeMat.Text;
            //string modelo = tbxModelo.Text;
            //string marca = cbxMarca.Text;
            //string numSerie = tbxNumSerie.Text;
            //string localizacao = cbxLocal.Text;
            //string dataEntrada = dtpDataEntrada.Text;


            //ClassPecas _Produtos = new ClassPecas("", "", "", 0, 0, "", 0, 0, "");

            //if (tbxNomeMat.Text != null && tbxModelo.Text != null & cbxMarca.Text != null && cbxCategoria.Text != null && cbxLocal.Text != null)
            //{
            //    if (_Produtos.AddMaterial())
            //    {
            //        MessageBox.Show("Sucesso");
            //    }
            //    else
            //    {
            //        MessageBox.Show("erro");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Preencha todos os campos");
            //}

            //tbxNomeMat.Text = "";
            //tbxModelo.Text = "";
            //cbxLocal.Text = "";
            //cbxMarca.Text = "";
            //cbxCategoria.Text = "";
            MessageBox.Show("Material Cadastrado com sucesso!");

        }

    
        private void tbxNomeMat_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
