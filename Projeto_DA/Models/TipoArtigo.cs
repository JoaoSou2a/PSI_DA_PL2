using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_DA.Models
{
    public class TipoArtigo
    {
        public int Id { get; set; }
        public string Categoria { get; set; }

        public override string ToString()
        {
            return Categoria;
        }
    }
}
