using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projeto_DA.Controllers
{
    internal class OrcamentoController
    {
        public bool criar(decimal valorMaximo, int mes, int ano, int utilizadorId)
        {

            using (var db = new IShoppingContext())
            {
                bool jaExiste = db.Orcamentos.Any(o => o.Mes == mes && o.Ano == ano);

                if (jaExiste)
                {
                    MessageBox.Show($"Já existe um orçamento configurado para o mês {mes:D2}/{ano}!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // nao deixa criar
                }

                //procurar o utilizador correspondente na BD
                var utilizadorDaBD = db.Utilizadores.Find(utilizadorId);
                if (utilizadorDaBD == null) return false;

                var novoOrcamento = new Orcamento
                {
                    ValorMaximo = valorMaximo,
                    Mes = mes,
                    Ano = ano,
                    Utilizador = utilizadorDaBD
                };


                // guardar na bd
                db.Orcamentos.Add(novoOrcamento);
                db.SaveChanges();

                MessageBox.Show($"Orçamento adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }

        }
        //todos os orçamentos da bd para mostrar na lista
        public List<Orcamento> ObterTodos()
        {
            using (var db = new IShoppingContext())
            {
                return db.Orcamentos.ToList();
            }
        }

        //atualizar os dados de um orçamento que ja existem
        public bool Atualizar(int id, decimal valorMaximo, int mes, int ano)
        {
            using (var db = new IShoppingContext())
            {
                var orcamentoDaBd = db.Orcamentos.Find(id);

                if (orcamentoDaBd == null) return false;
                bool jaExiste = db.Orcamentos.Any(o => o.Mes == mes && o.Ano == ano && o.Id != id);

                if (jaExiste)
                {
                    MessageBox.Show($"Não é possível alterar. Já existe outro orçamento para o mês {mes:D2}/{ano}!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // nao deixa
                }

                //altera as propriedades com os novos valores vindos do form
                orcamentoDaBd.ValorMaximo = valorMaximo;
                orcamentoDaBd.Mes = mes;
                orcamentoDaBd.Ano = ano;

                db.SaveChanges();
                return true;
            }
        }

        public bool Remover(int id)
        {
            using (var db = new IShoppingContext())
            {
               
                var orcamentoParaRemover = db.Orcamentos.Find(id);

                if (orcamentoParaRemover == null) return false; 

                
                db.Orcamentos.Remove(orcamentoParaRemover);
                db.SaveChanges();
                return true;
            }
        }
    }
}
