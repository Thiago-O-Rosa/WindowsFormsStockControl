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

        private void button6_Click(object sender, EventArgs e)
        {
            FormLogin _formLogin = new FormLogin();
            _formLogin.Show();
            this.Hide();
        }

        private void FormHomeUser_Load(object sender, EventArgs e)
        {

        }

        private void btnRelMat_Click(object sender, EventArgs e)
        {
            __userControlRelacMat.Visible = true;    
            _userControlPesquisa.Visible = false;
            _userControlMatDisp.Visible = false;
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            __userControlRelacMat.Visible = false;
            _userControlPesquisa.Visible = true;
            _userControlMatDisp.Visible = false;
        }

        private void btnMatDisp_Click(object sender, EventArgs e)
        {
            __userControlRelacMat.Visible = false;
            _userControlPesquisa.Visible = false;
            _userControlMatDisp.Visible = true;
        }

        private void userControlMatDisp1_Load(object sender, EventArgs e)
        {

        }
    }
}
