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
    public partial class FormHomeAdmin : Form
    {
        public FormHomeAdmin()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLogin _formLogin = new FormLogin();
            _formLogin.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormAdminNewUser _formAdmin = new FormAdminNewUser();
            _formAdmin.Show();
            this.Hide();
        }

        private void btnRelMat_Click(object sender, EventArgs e)
        {
            userControlRelacMat1.Visible = true;
            userControlPesquisa1.Visible = false;
            userControlMatDisp1.Visible = false;
            _UserControlAdicionar1.Visible = false;
            _UserControlRemover1.Visible = false;
           
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            userControlRelacMat1.Visible = false;
            userControlPesquisa1.Visible = true;
            userControlMatDisp1.Visible = false;
            _UserControlAdicionar1.Visible = false;
            _UserControlRemover1.Visible = false;
        }

        private void btnMatDisp_Click(object sender, EventArgs e)
        {
            userControlRelacMat1.Visible = false;
            userControlPesquisa1.Visible = false;
            userControlMatDisp1.Visible = true;
            _UserControlAdicionar1.Visible = false;
            _UserControlRemover1.Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            userControlRelacMat1.Visible = false;
            userControlPesquisa1.Visible = false;
            userControlMatDisp1.Visible = false;
            _UserControlAdicionar1.Visible = true;
            _UserControlRemover1.Visible = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ////userControlRelacMat1.Visible = false;
            userControlPesquisa1.Visible = false;
            userControlMatDisp1.Visible = false;
            _UserControlAdicionar1.Visible = false;
            _UserControlRemover1.Visible = true;
        }

        
    }
}
