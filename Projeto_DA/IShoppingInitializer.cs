using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    internal class IShoppingInitializer : DropCreateDatabaseIfModelChanges<IShoppingContext>
    {
        protected override void Seed(IShoppingContext context)
        {
            context.Utilizadores.Add(new Utilizador { Username = "mauriciobacanoide", Nome = "Mauricio Tranquilo", Password = Seguranca.EncriptarPassword("mauricao") });
            base.Seed(context);
        }
    }
}
