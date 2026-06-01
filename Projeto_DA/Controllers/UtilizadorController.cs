using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Controllers
{
    internal class UtilizadorController
    {
        public List<Utilizador> ObterTodos()
        {
            using (var db = new IShoppingContext())
            {
                return db.Utilizadores.ToList();
            }
        }

        //remover utilizador apenas se n tiver compras nem orçamentos
        public bool Remover(int id)
        {
            using (var db = new IShoppingContext())
            {
                var utilizador = db.Utilizadores.Find(id);
                if (utilizador == null) return false;

                //verifica se o utilizador tem orçamentos associados
                bool temOrcamentos = db.Orcamentos.Any(o => o.Utilizador.Id == id);

                // verifica se o utilizador tem compras associadas
                bool temCompras = db.Compras.Any(c => c.Utilizador.Id == id);

                if (temOrcamentos || temCompras)
                {
                    MessageBox.Show(
                        "Não é possível apagar este utilizador porque ele já possui orçamentos ou compras registadas no sistema.",
                        "Bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false; //cancela
                }

                //se passou nas validações, apaga
                db.Utilizadores.Remove(utilizador);
                db.SaveChanges();
                return true;
            }
        }
    }
}
