using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    internal class Compra
    {
        public int Id { get; set; }
        public string NomeCompra { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFechada {  get; set; }
        public bool Fechada {  get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Utilizador Utilizador { get; set; }
    }
}
