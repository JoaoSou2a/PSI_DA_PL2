using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    internal class Orcamento
    {
        public Orcamento()
        {
        }

        public int Id { get; set; }
        public Utilizador Utilizador { get; set; }

        public decimal ValorMaximo { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Orcamento(int id, Utilizador utilizador, decimal valorMaximo, int mes, int ano)
        {
            Id = id;
            Utilizador = utilizador;
            ValorMaximo = valorMaximo;
            Mes = mes;
            Ano = ano;
        }

        //orçamento aparece listado na ListBox
        public override string ToString()
        {
            return $"Mês: {Mes:D2}/{Ano} | Valor: {ValorMaximo}€";
        }
    }
}
