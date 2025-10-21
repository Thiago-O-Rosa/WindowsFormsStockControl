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
    }
}
