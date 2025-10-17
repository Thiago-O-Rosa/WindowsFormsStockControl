using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryStoksControl;
using System.Data.SqlClient;

namespace WindowsFormsStockControl
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
        }

        private ClassUser _user = new ClassUser(0, "", "", "");
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Inicializacao
            string email = tbxEmail.Text.Trim();
            string password = tbxPassword.Text.Trim();
            tbxEmail.Focus();

            //Processamento
            DataTable dt = _user.Entrar(email, password);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bem Vindo ao Sistema", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHomeUser _formHomeUser = new FormHomeUser();
                _formHomeUser.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possível fazer o Login. \nVerifique seu Email e Senha e tente novamente.", "Email ou Senha Incorretos");
            }

        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        { 
        if(e.KeyChar == 13)
            btnEntrar_Click(sender, e);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
