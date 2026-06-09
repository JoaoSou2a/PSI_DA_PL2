using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_DA.Program;

namespace Projeto_DA.Controllers
{
    internal class LoginController
    {
        public bool login(string username, string password)
        {
            using (var db = new IShoppingContext())
            {
                string passwordEncriptada = Seguranca.EncriptarPassword(password);
                Utilizador utilizador = db.Utilizadores
                    .Where(cli => cli.Username.ToLower() == username.ToLower() &&
                     cli.Password == passwordEncriptada)
                    .Select(cli => cli)
                    .FirstOrDefault();

                if (utilizador != null)
                {
                    Sessao.UtilizadorLogado = utilizador;
                    MessageBox.Show($"Bem-vindo, {utilizador.Nome}!", "Login com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Username ou Password incorretos.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                /*if (utilizador != null)
                {
                    return true;
                }
                return false;*/
            }
        }
    }
}
