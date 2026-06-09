using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controllers
{
    internal class HomeController
    {
        public static string ObterNomeUtilizador()
        {
            var utilizador = Program.Sessao.UtilizadorLogado;
            if (utilizador == null) return "—";
            return utilizador.Nome;
        }
        public static Orcamento ObterOrcamentoMesAtual()
        {
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            using (var db = new IShoppingContext())
            {
                return db.Orcamentos
                    .FirstOrDefault(o => o.Mes == mes && o.Ano == ano);
            }
        }

        public List<Compra> ObterComprasEmAberto()
        {
            using (var db = new IShoppingContext())
            {
                return db.Compras
                    .Include("UtilizadorCriou")
                    .Where(c => !c.Fechada)
                    .ToList();
            }
        }
    }
}
