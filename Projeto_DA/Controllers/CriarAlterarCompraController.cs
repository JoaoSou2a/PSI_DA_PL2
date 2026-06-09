using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controllers
{
    internal class CriarAlterarCompraController
    {
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
                    .Where(a => a.TipoArtigo.Id == tipoId)
                    .OrderBy(a => a.Nome)
                    .ToList();
            }
        }

        public bool CriarCompra(string nomeCompra, List<ItemPrevisto> itensPrev, int utilizadorId)
        {
            using (var db = new IShoppingContext())
            {
                var novaCompra = new Compra
                {
                    NomeCompra = nomeCompra,
                    DataCriacao = System.DateTime.Now,
                    Fechada = false,
                    ValorTotal = 0,
                    UtilizadorCriouId = utilizadorId
                };

                db.Compras.Add(novaCompra);
                db.SaveChanges();

                foreach (var item in itensPrev)
                {
                    var artigo = db.Artigos.Find(item.Artigo.Id);
                    if (artigo == null) continue;

                    var itemPrevisto = new ItemPrevisto
                    {
                        Compra = novaCompra,
                        Artigo = artigo,
                        QuantidadePrevista = item.QuantidadePrevista
                    };
                    db.ItemPrevistos.Add(itemPrevisto);
                }

                db.SaveChanges();
                return true;
            }
        }

        public bool AlterarCompra(int compraId, string nomeCompra, List<ItemPrevisto> itensPrev, int utilizadorId)
        {
            using (var db = new IShoppingContext())
            {
                var compra = db.Compras.Find(compraId);
                if (compra == null || compra.Fechada) return false;

                compra.NomeCompra = nomeCompra;
                compra.DataAlteracao = System.DateTime.Now;
                compra.UtilizadorAlterouId = utilizadorId;

                // remove os itens antigos
                var itensAntigos = db.ItemPrevistos.Where(i => i.Compra.Id == compraId).ToList();
                db.ItemPrevistos.RemoveRange(itensAntigos);

                // adiciona os novos
                foreach (var item in itensPrev)
                {
                    var artigo = db.Artigos.Find(item.Artigo.Id);
                    if (artigo == null) continue;

                    var itemPrevisto = new ItemPrevisto
                    {
                        Compra = compra,
                        Artigo = artigo,
                        QuantidadePrevista = item.QuantidadePrevista
                    };
                    db.ItemPrevistos.Add(itemPrevisto);
                }

                db.SaveChanges();
                return true;
            }
        }

        public List<ItemPrevisto> ObterItensPorCompra(int compraId)
        {
            using (var db = new IShoppingContext())
            {
                return db.ItemPrevistos
                    .Include("Artigo") 
                    .Where(i => i.Compra.Id == compraId)
                    .ToList();
            }
        }


    }
}
