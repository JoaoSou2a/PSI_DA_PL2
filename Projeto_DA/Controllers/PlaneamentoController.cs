using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.Models;

namespace Projeto_DA.Controllers
{
    internal class PlaneamentoController
    {
        public List<Compra> ObterTodos()
        {
            using (var db = new IShoppingContext())
            {
                return db.Compras
                    .Include("UtilizadorCriou")
                    .Include("UtilizadorAlterou")
                    .Include("UtilizadorFechou")
                    .ToList();
            }
        }

        public List<Compra> ObterFiltrado(string estado, int? utilizadorId)
        {
            using (var db = new IShoppingContext())
            {
                var query = db.Compras
                    .Include("UtilizadorCriou")
                    .Include("UtilizadorAlterou")
                    .Include("UtilizadorFechou")
                    .AsQueryable();

                if (estado == "Aberta")
                    query = query.Where(c => !c.Fechada);
                else if (estado == "Fechada")
                    query = query.Where(c => c.Fechada);

                if (utilizadorId.HasValue)
                    query = query.Where(c => c.UtilizadorCriouId == utilizadorId.Value);

                return query.ToList();
            }
        }

        public List<Utilizador> ObterUtilizadores()
        {
            using (var db = new IShoppingContext())
            {
                return db.Utilizadores.ToList();
            }
        }

        public bool RemoverCompra(int id)
        {
            using (var db = new IShoppingContext())
            {
                var compra = db.Compras.Find(id);
                if (compra == null) return false;

                db.Compras.Remove(compra);
                db.SaveChanges();
                return true;
            }
        }
    }
}
