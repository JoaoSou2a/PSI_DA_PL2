using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    public class ItemPrevisto : ItemCompra
    {
        public int QuantidadePrevista { get; set; }

        public override string ToString()
        {
            return $"{Artigo?.Nome} | Quantidade Prevista: {QuantidadePrevista} | Qntd: {QuantidadeAdquirida} | Preço Uni: {PrecoUnitario:F2}€";
        }

    }
}
