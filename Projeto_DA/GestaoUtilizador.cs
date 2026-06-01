using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_DA.Program;

namespace Projeto_DA
{
    public partial class GestaoUtilizador : Form
    {
        private UtilizadorController utilizadorController = new UtilizadorController();

        private Utilizador utilizadorSelecionado = null;
        public GestaoUtilizador()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBoxUtilizadores.DataSource = null;
            listBoxUtilizadores.DataSource = utilizadorController.ObterTodos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxUtilizadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUtilizadores.SelectedItem != null)
            {
                utilizadorSelecionado = listBoxUtilizadores.SelectedItem as Utilizador;
            }
        }

        private void btnRemoverUtilizador_Click(object sender, EventArgs e)
        {        
            if (utilizadorSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione primeiro um utilizador na lista para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (utilizadorSelecionado.Id == Sessao.UtilizadorLogado.Id)
            {
                MessageBox.Show("Não te podes apagar a ti mesmo!", "Operação Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Tem a certeza que deseja apagar o utilizador '{utilizadorSelecionado.Nome}'?",
                "Confirmar Eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                //chama o controller para verificar
                bool sucesso = utilizadorController.Remover(utilizadorSelecionado.Id);

                if (sucesso)
                {
                    MessageBox.Show("Utilizador removido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarLista();
                    utilizadorSelecionado = null; 
                }
            }
        }
    }
}
