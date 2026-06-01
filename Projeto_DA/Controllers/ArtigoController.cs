using Projeto_DA.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Projeto_DA.Controllers
{
    internal class ArtigoController
    {
        private readonly IShoppingContext db = new IShoppingContext();

        public List<TipoArtigo> GetTiposArtigo()
        {
            return db.TipoArtigos
                     .OrderBy(t => t.Categoria)
                     .ToList();
        }

        public List<Artigo> GetArtigos(int tipoId = 0)
        {
            var query = db.Artigos
                          .Include(a => a.TipoArtigo)
                          .AsQueryable();

            if (tipoId > 0)
            {
                query = query.Where(a => a.TipoArtigo.Id == tipoId);
            }

            return query.ToList();
        }

        public void AdicionarArtigo(string nome, int tipoId)
        {
            var tipo = db.TipoArtigos.Find(tipoId);

            var artigo = new Artigo
            {
                Nome = nome,
                TipoArtigo = tipo
            };

            db.Artigos.Add(artigo);
            db.SaveChanges();
        }

        public void EditarArtigo(int artigoId, string nome, int tipoId)
        {
            var artigo = db.Artigos
                           .Include(a => a.TipoArtigo)
                           .FirstOrDefault(a => a.Id == artigoId);

            if (artigo == null) return;

            artigo.Nome = nome;
            artigo.TipoArtigo = db.TipoArtigos.Find(tipoId);

            db.SaveChanges();
        }

        public void EliminarArtigo(int artigoId)
        {
            var artigo = db.Artigos.Find(artigoId);

            if (artigo == null) return;

            db.Artigos.Remove(artigo);
            db.SaveChanges();
        }
    }
}