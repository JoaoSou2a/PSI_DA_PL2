using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.Models;

namespace Projeto_DA.Controllers
{
    public class PlaneamentoController
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

                // 💡 CORREÇÃO DE SEGURANÇA: Remover primeiro todos os itens associados a esta compra aberta
                var itensAssociados = db.Set<ItemCompra>()
                    .Where(i => i.Compra.Id == id)
                    .ToList();

                foreach (var item in itensAssociados)
                {
                    db.Set<ItemCompra>().Remove(item);
                }

                // Agora que os itens foram limpos, removemos o "pai" (a compra) sem dar erros
                db.Compras.Remove(compra);

                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<LinhaExportacaoCSV> ObterDadosParaExportacao()
        {
            using (var db = new IShoppingContext())
            {
                // procurar todas as compras fechadas
                var comprasFechadas = db.Compras
                    .Where(c => c.Fechada && c.DataFechada.HasValue)
                    .ToList();

                // trazer todos os itens de compra com o Artigo incluído para memória
                var todosItens = db.Set<ItemCompra>()
                    .Include(i => i.Artigo)
                    .ToList();

                var listaLinhas = new List<LinhaExportacaoCSV>();

                foreach (var compra in comprasFechadas)
                {
                    // filtrar os itens que pertencem a esta compra
                    var itensDestaCompra = todosItens.Where(i => i.Compra != null && i.Compra.Id == compra.Id).ToList();

                    if (!itensDestaCompra.Any())
                    {
                        // se por acaso houver uma compra fechada sem itens, exporta apenas os dados da compra
                        listaLinhas.Add(new LinhaExportacaoCSV
                        {
                            NomeCompra = compra.NomeCompra,
                            DataCriacao = compra.DataCriacao,
                            DataFechada = compra.DataFechada.Value,
                            NomeArtigo = "—",
                            ArtigoPrevisto = "Não",
                            ArtigoNaoPrevisto = "Não",
                            QuantidadePrevista = 0,
                            QuantidadeAdquirida = 0,
                            PrecoUnitario = 0
                        });
                        continue;
                    }

                    foreach (var item in itensDestaCompra)
                    {
                        string nomeArtigo = item.Artigo?.Nome ?? "Desconhecido";
                        string artigoPrevisto = "Não";
                        string artigoNaoPrevisto = "Não";
                        int qtdPrevista = 0;

                        // descobrir o tipo do item através do LINQ (Herança)
                        if (item is ItemPrevisto previsto)
                        {
                            artigoPrevisto = "Sim";
                            qtdPrevista = previsto.QuantidadePrevista;
                        }
                        else if (item is ItemNaoPrevisto)
                        {
                            artigoNaoPrevisto = "Sim";
                        }

                        listaLinhas.Add(new LinhaExportacaoCSV
                        {
                            NomeCompra = compra.NomeCompra,
                            DataCriacao = compra.DataCriacao,
                            DataFechada = compra.DataFechada.Value,
                            NomeArtigo = nomeArtigo,
                            ArtigoPrevisto = artigoPrevisto,
                            ArtigoNaoPrevisto = artigoNaoPrevisto,
                            QuantidadePrevista = qtdPrevista,
                            QuantidadeAdquirida = item.QuantidadeAdquirida,
                            PrecoUnitario = item.PrecoUnitario
                        });
                    }
                }

                return listaLinhas;
            }
        } // 💡 CHAVETA CORRIGIDA AQUI (Antes fechava a classe prematuramente)
    }

    public class LinhaExportacaoCSV
    {
        public string NomeCompra { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFechada { get; set; }
        public string NomeArtigo { get; set; }
        public string ArtigoPrevisto { get; set; }
        public string ArtigoNaoPrevisto { get; set; }
        public int QuantidadePrevista { get; set; }
        public int QuantidadeAdquirida { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}