using Projeto_DA.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_DA.Controllers
{
    internal class RegisterController
    {
        public bool register(string username, string nome, string password)
        {
            // cenas vazias
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // tamanho da password
            if (password.Length <= 4)
            {
                MessageBox.Show("A password tem de ter mais de 4 caracteres.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (var db = new IShoppingContext())
            {
                // se o username já existe
                bool usernameExiste = db.Utilizadores.Any(u => u.Username.ToLower() == username.ToLower());

                if (usernameExiste)
                {
                    MessageBox.Show("Este username já está a ser utilizado. Escolha outro.", "Username Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }

                // se passou as validações, cria o objeto
                var novoUtilizador = new Utilizador
                {
                    Username = username,
                    Nome = nome,
                    Password = password // falta encriptar
                };

                // guardar na bd
                db.Utilizadores.Add(novoUtilizador);
                db.SaveChanges();

                MessageBox.Show($"Utilizador {novoUtilizador.Nome} registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
        }
    }
}