using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto_DA.Models;

namespace Projeto_DA
{
    internal class IShoppingContext : DbContext
    {
        public DbSet<Utilizador> Utilizadores {  get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<ItemCompra> ItemCompras { get; set; }
        public DbSet<ItemPrevisto> ItemPrevistos { get; set; }
        public DbSet<ItemNaoPrevisto> ItemNaoPrevistos { get; set; }
        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<TipoArtigo> TipoArtigos { get; set; }
    }
}
