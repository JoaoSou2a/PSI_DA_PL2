using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    internal class Orcamento
    {
        public Utilizador Utilizador { get; set; }

        public int ValorMaximo { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}
