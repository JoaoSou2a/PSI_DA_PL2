using System;
using System.Collections.Generic;
using System.Data.Entity; // Importante para o .Include()
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DA.Models; // Garante que herda os teus modelos de dados

namespace Projeto_DA.Controllers
{
    internal class EstatisticasController
    {
        //listagem de todos os meses e os respetivos valores de Orçamento, Total de Compras e Diferença
        public List<EstatisticaMensalDTO> ObterDadosMensais()
        {
            using (var db = new IShoppingContext())
            {
                var orcamentos = db.Orcamentos.ToList();

                //garantimos que filtramos apenas compras fechadas e que tenham data de fecho válida
                var compras = db.Compras.Where(c => c.Fechada && c.DataFechada.HasValue).ToList();

                //unir todos os meses e anos distintos presentes em ambas as tabelas (em memória)
                var todosPeriodos = orcamentos.Select(o => new { o.Mes, o.Ano })
                    .Union(compras.Select(c => new { Mes = c.DataFechada.Value.Month, Ano = c.DataFechada.Value.Year }))
                    .Distinct()
                    .OrderByDescending(p => p.Ano).ThenByDescending(p => p.Mes)
                    .ToList();

                var resultado = new List<EstatisticaMensalDTO>();

                foreach (var periodo in todosPeriodos)
                {
                    //calcula o Orçamento previsto para este mês/ano
                    decimal valorOrcamento = orcamentos
                        .Where(o => o.Mes == periodo.Mes && o.Ano == periodo.Ano)
                        .Sum(o => (decimal?)o.ValorMaximo) ?? 0;

                    //filtrar as compras deste mês específico
                    var comprasDestePeriodo = compras
                        .Where(c => c.DataFechada.Value.Month == periodo.Mes && c.DataFechada.Value.Year == periodo.Ano)
                        .ToList();

                    //calcular o total real somando os itens de cada compra deste mês diretamente da BD
                    decimal totalComprasReal = 0;
                    foreach (var comp in comprasDestePeriodo)
                    {
                        //vai buscar os itens desta compra à tabela ItemCompra e faz a matemática: Qtd * Preço
                        totalComprasReal += db.Set<ItemCompra>()
                            .Where(i => i.Compra.Id == comp.Id)
                            .Sum(i => (decimal?)(i.QuantidadeAdquirida * i.PrecoUnitario)) ?? 0;
                    }

                    //adiciona ao DTO com os valores reais calculados
                    resultado.Add(new EstatisticaMensalDTO
                    {
                        MesAno = $"{periodo.Mes:D2}/{periodo.Ano}",
                        Orcamento = valorOrcamento,
                        TotalCompras = totalComprasReal,
                        Diferenca = valorOrcamento - totalComprasReal
                    });
                }

                return resultado;
            }
        }

        //listagem de todas as compras fechadas com a percentagem de artigos previstos e não previstos
        public List<EstatisticaCompraDTO> ObterDadosComprasFechadas()
        {
            using (var db = new IShoppingContext())
            {
                var comprasFechadas = db.Compras.Where(c => c.Fechada && c.DataFechada.HasValue).ToList();
                var resultado = new List<EstatisticaCompraDTO>();

                //carrega os itens de compra com os seus respetivos discriminadores de herança previamente
                var todosItens = db.Set<ItemCompra>().ToList();

                foreach (var c in comprasFechadas)
                {
                    var itensDestaCompra = todosItens.Where(i => i.Compra != null && i.Compra.Id == c.Id).ToList();
                    int totalItens = itensDestaCompra.Count;

                    if (totalItens == 0)
                    {
                        resultado.Add(new EstatisticaCompraDTO { NomeCompra = c.NomeCompra, DataFecho = c.DataFechada.Value, PercPrevistos = 0, PercNaoPrevistos = 0 });
                        continue;
                    }

                    int totalPrevistos = itensDestaCompra.OfType<ItemPrevisto>().Count();
                    int totalNaoPrevistos = itensDestaCompra.OfType<ItemNaoPrevisto>().Count();

                    resultado.Add(new EstatisticaCompraDTO
                    {
                        NomeCompra = c.NomeCompra,
                        DataFecho = c.DataFechada.Value,
                        PercPrevistos = Math.Round(((decimal)totalPrevistos / totalItens) * 100, 2),
                        PercNaoPrevistos = Math.Round(((decimal)totalNaoPrevistos / totalItens) * 100, 2)
                    });
                }

                return resultado;
            }
        }

        //sugerir orçamento para o próximo mês com base na média aritmética dos anteriores
        public decimal SugerirOrcamentoProximoMes()
        {
            using (var db = new IShoppingContext())
            {
                var orcamentos = db.Orcamentos.Select(o => o.ValorMaximo).ToList();
                if (!orcamentos.Any()) return 100; //valor padrão de salvaguarda caso a BD esteja vazia

                return Math.Round(orcamentos.Average(), 2);
            }
        }

        //sugerir lista preditiva com o Top 5 de artigos mais frequentes na semana alvo
        public List<string> SugerirListaComprasProximaSemana(int semanaAlvo)
        {
            using (var db = new IShoppingContext())
            {
                var comprasAnteriores = db.Compras.Where(c => c.Fechada && c.DataFechada.HasValue).ToList();

                //filtra quais as compras executadas na mesma semana do mês em períodos passados
                var comprasMesmaSemana = comprasAnteriores.Where(c => ObterSemanaDoMes(c.DataFechada.Value) == semanaAlvo);
                var idsCompras = comprasMesmaSemana.Select(c => c.Id).ToList();

                if (!idsCompras.Any()) return new List<string>();

                
                var artigosMaisComprados = db.Set<ItemCompra>()
                    .Include(i => i.Artigo)
                    .Where(i => idsCompras.Contains(i.Compra.Id) && i.Artigo != null)
                    .GroupBy(i => i.Artigo.Nome)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .Take(5) 
                    .ToList();

                return artigosMaisComprados;
            }
        }

        //algoritmo auxiliar para segmentação das semanas do mês (1ª a 4ª semana)
        public int ObterSemanaDoMes(DateTime data)
        {
            int dia = data.Day;
            if (dia <= 7) return 1;
            if (dia <= 14) return 2;
            if (dia <= 21) return 3;
            return 4;
        }
    }

    public class EstatisticaMensalDTO
    {
        public string MesAno { get; set; }
        public decimal Orcamento { get; set; }
        public decimal TotalCompras { get; set; }
        public decimal Diferenca { get; set; }
        public override string ToString() => $"{MesAno}   |   Orçamento: {Orcamento:F2}€   |   Total Gasto: {TotalCompras:F2}€   |   Margem: {Diferenca:F2}€";
    }

    public class EstatisticaCompraDTO
    {
        public string NomeCompra { get; set; }
        public DateTime DataFecho { get; set; }
        public decimal PercPrevistos { get; set; }
        public decimal PercNaoPrevistos { get; set; }
        public override string ToString() => $"[{DataFecho:dd/MM/yyyy}] {NomeCompra} -> Planeados: {PercPrevistos}% | Imprevistos: {PercNaoPrevistos}%";
    }
}