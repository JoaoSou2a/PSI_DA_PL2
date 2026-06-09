using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Nome}";
        }

    }
}
