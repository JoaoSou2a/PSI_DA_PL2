using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    internal class Compra
    {
        public int id { get; set; }
        public string nomeCompra { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataFechada {  get; set; }
        public bool fechada {  get; set; }
        public decimal valorTotal { get; set; }
        public DateTime dataAlteracao { get; set; }
        public Utilizador utilizador { get; set; }
    }
}
