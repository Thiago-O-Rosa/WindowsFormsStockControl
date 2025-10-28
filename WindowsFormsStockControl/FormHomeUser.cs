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
    public partial class FormHomeUser : Form
    {
        public FormHomeUser()
        {
            InitializeComponent();
        }

        private void btnRelMat_Click(object sender, EventArgs e)
        {
            userControlRelacMat.Visible = true;
            _UserControlAdicionarUsuario.Visible = false;
            _UserControlAdicionar.Visible = false;
        }
       
        private void btnAdicionarUser_Click(object sender, EventArgs e)
        {
            _UserControlAdicionarUsuario.Visible = true;
            userControlRelacMat.Visible = false;
            _UserControlAdicionar.Visible = false;
        }

        private void btnAdicionarMat_Click(object sender, EventArgs e)
        {
            _UserControlAdicionar.Visible = true;
            _UserControlAdicionarUsuario.Visible = false;
            userControlRelacMat.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLogin _formLogin = new FormLogin();
            _formLogin.Show();
            this.Hide();
        }

        private void userControlRelacMat_Load(object sender, EventArgs e)
        {

        }
    }
}
