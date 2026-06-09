using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controllers
{
    internal class ModoCompraController
    {
        public Compra ObterCompra(int compraId)
        {
            using (var db = new IShoppingContext())
            {
                return db.Compras
                    .Include("UtilizadorCriou")
                    .FirstOrDefault(c => c.Id == compraId);
            }
        }

        public List<ItemPrevisto> ObterItensPrev(int compraId)
        {
            using (var db = new IShoppingContext())
            {
                return db.ItemPrevistos
                    .Include("Artigo")
                    .Where(i => i.Compra.Id == compraId)
                    .ToList();
            }
        }

        public List<ItemNaoPrevisto> ObterItensNaoPrev(int compraId)
        {
            using (var db = new IShoppingContext())
            {
                return db.ItemNaoPrevistos
                    .Include("Artigo")
                    .Where(i => i.Compra.Id == compraId)
                    .ToList();
            }
        }

        public Orcamento ObterOrcamentoMesAtual()
        {
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            using (var db = new IShoppingContext())
            {
                return db.Orcamentos
                    .FirstOrDefault(o => o.Mes == mes && o.Ano == ano);
            }
        }

        public decimal ObterTotalGasto(int compraId)
        {
            using (var db = new IShoppingContext())
            {
                decimal totalPrev = db.ItemPrevistos
                    .Where(i => i.Compra.Id == compraId)
                    .ToList()
                    .Sum(i => i.QuantidadeAdquirida * i.PrecoUnitario);

                decimal totalNaoPrev = db.ItemNaoPrevistos
                    .Where(i => i.Compra.Id == compraId)
                    .ToList()
                    .Sum(i => i.QuantidadeAdquirida * i.PrecoUnitario);

                return totalPrev + totalNaoPrev;
            }
        }

        public bool GuardarItemPrevisto(int itemId, int qtdAdquirida, decimal precoUnitario)
        {
            using (var db = new IShoppingContext())
            {
                var item = db.ItemPrevistos.Find(itemId);
                if (item == null) return false;

                item.QuantidadeAdquirida = qtdAdquirida;
                item.PrecoUnitario = precoUnitario;
                db.SaveChanges();
                return true;
            }
        }

        public bool AdicionarItemNaoPrevisto(int compraId, int artigoId, int quantidade, decimal preco, string observacoes)
        {
            using (var db = new IShoppingContext())
            {
                var compra = db.Compras.Find(compraId);
                var artigo = db.Artigos.Find(artigoId);
                if (compra == null || artigo == null) return false;

                var item = new ItemNaoPrevisto
                {
                    Compra = compra,
                    Artigo = artigo,
                    QuantidadeAdquirida = quantidade,
                    PrecoUnitario = preco,
                    Observacoes = observacoes
                };

                db.ItemNaoPrevistos.Add(item);
                db.SaveChanges();
                return true;
            }
        }

        public bool RemoverItemNaoPrevisto(int itemId)
        {
            using (var db = new IShoppingContext())
            {
                var item = db.ItemNaoPrevistos.Find(itemId);
                if (item == null) return false;

                db.ItemNaoPrevistos.Remove(item);
                db.SaveChanges();
                return true;
            }
        }

        public bool FecharCompra(int compraId, int utilizadorId)
        {
            using (var db = new IShoppingContext())
            {
                var compra = db.Compras.Find(compraId);
                if (compra == null || compra.Fechada) return false;

                compra.Fechada = true;
                compra.DataFechada = DateTime.Now;
                compra.UtilizadorFechouId = utilizadorId;
                db.SaveChanges();
                return true;
            }
        }

        public List<TipoArtigo> ObterTiposArtigo()
        {
            using (var db = new IShoppingContext())
            {
                return db.TipoArtigos.OrderBy(t => t.Categoria).ToList();
            }
        }

        public List<Artigo> ObterArtigosPorTipo(int tipoId)
        {
            using (var db = new IShoppingContext())
            {
                return db.Artigos
                    .Include("TipoArtigo")
                    .Where(a => a.TipoArtigo.Id == tipoId)
                    .ToList();
            }
        }
    }
}
