using Projeto_DA.Controllers;
using Projeto_DA.Models;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string nome = txtNome.Text.Trim();
            string password = txtPassword.Text;

            

            RegisterController registerController = new RegisterController();
            bool sucesso = registerController.register(username, nome, password);
            if (sucesso)
            {
                this.Hide();

                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }
        }

        private void btnIrParaLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm form = new LoginForm();
            form.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
