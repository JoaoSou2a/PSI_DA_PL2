using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    public class Compra
    {
        public int Id { get; set; }
        public string NomeCompra { get; set; }
        public bool Fechada { get; set; }
        public decimal ValorTotal { get; set; }
        public Utilizador Utilizador { get; set; }

        //datas
        public DateTime DataCriacao { get; set; } 
        public DateTime? DataAlteracao { get; set; } // com ? — só tem valor se for alterada
        public DateTime? DataFechada { get; set; } // com ? — só tem valor se for fechada

        //utilizadores
        public int UtilizadorCriouId { get; set; }
        public Utilizador UtilizadorCriou { get; set; }

        public int? UtilizadorAlterouId { get; set; }
        public Utilizador UtilizadorAlterou { get; set; }

        public int? UtilizadorFechouId { get; set; }
        public Utilizador UtilizadorFechou { get; set; }

        public override string ToString()
        {
            string estado = Fechada ? "Fechada" : "Aberta";
            string criador = UtilizadorCriou?.Nome ?? "—";

            string dataInfo;
            if (Fechada && DataFechada.HasValue)
                dataInfo = $"Fechada a: {DataFechada.Value:dd/MM/yyyy HH:mm}";
            else if (DataAlteracao.HasValue)
                dataInfo = $"Alterada a: {DataAlteracao.Value:dd/MM/yyyy HH:mm}";
            else
                dataInfo = $"Criada a: {DataCriacao:dd/MM/yyyy HH:mm}";

            return $"{NomeCompra} | {dataInfo} | Estado:{estado} | Criado por: {criador}";
        }

    }
}
