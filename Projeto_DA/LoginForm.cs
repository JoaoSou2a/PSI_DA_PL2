using Projeto_DA.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha o username e a password.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginController loginController = new LoginController();
            bool sucesso = loginController.login(username, password);
            if (sucesso)
            {
                this.Hide();

                PrincipalForm form = new PrincipalForm();
                form.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIrParaRegisto_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
