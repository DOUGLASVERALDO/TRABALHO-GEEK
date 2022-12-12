using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Geek_Store
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = txtLogin.Text;
            senha = txtSenha.Text;
            if (login == "admin" && senha == "admin")
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Suas credenciais não foram validadas!! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                this.txtLogin.Focus();
            }
    }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
