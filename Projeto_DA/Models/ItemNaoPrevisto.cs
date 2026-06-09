using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    public class ItemNaoPrevisto : ItemCompra
    {
        public string Observacoes {  get; set; }

        public override string ToString()
        {
            return $"{Artigo?.Nome} | Qtd: {QuantidadeAdquirida} | {PrecoUnitario:F2}€ | Obs: {Observacoes}";
        }
    }
}
