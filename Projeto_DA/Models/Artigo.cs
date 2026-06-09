using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    public class Artigo
    {



        public int Id { get; set; }
        public TipoArtigo TipoArtigo { get; set; }
        public string Nome { get; set; }

        public string NomeCategoria
        {
            get { return $"{Nome} - {TipoArtigo?.Categoria}"; }
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
