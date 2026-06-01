using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    internal class Artigo
    {
<<<<<<< Updated upstream:Projeto_DA/Artigo.cs
        public string Nome { get; set; }
=======
        public int Id { get; set; }
        public TipoArtigo TipoArtigo { get; set; }
        public string Nome { get; set; }

        public string NomeCategoria
        {
            get { return $"{Nome} - {TipoArtigo?.Categoria}"; }
        }
>>>>>>> Stashed changes:Projeto_DA/Models/Artigo.cs
    }
}
