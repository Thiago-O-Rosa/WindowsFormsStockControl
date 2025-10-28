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
    public partial class FormAdminNewUser : Form
    {
        public FormAdminNewUser()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLogin _formLogin = new FormLogin();
            _formLogin.Show();
            this.Hide();
        }

        

        private void btnRelMat_Click(object sender, EventArgs e)
        {
            userControlRelacMat.Visible = true;
            _UserControlAddUser.Visible = false;
            _UserControlAdicionarNovoMat.Visible = false;
        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            userControlRelacMat.Visible = false;
            _UserControlAddUser.Visible = true;
            _UserControlAdicionarNovoMat.Visible = false;
        }

        private void btnNovoMat_Click(object sender, EventArgs e)
        {
            userControlRelacMat.Visible = false;
            _UserControlAddUser.Visible = false;
            _UserControlAdicionarNovoMat.Visible = true;
        }
    }
}
