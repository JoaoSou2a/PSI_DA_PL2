using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
<<<<<<< Updated upstream
=======
            Database.SetInitializer(new IShoppingInitializer());

            /* using (var db = new IShoppingContext())
            {
                var Utilizador = new Utilizador { Username = "mauriciofixe", Nome = "mauricio", Password = "mauricao" };
                db.Utilizadores.Add(Utilizador);
                db.SaveChanges();
            } */

>>>>>>> Stashed changes
            //teste
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTipoArtigos());
        }
    }
}
