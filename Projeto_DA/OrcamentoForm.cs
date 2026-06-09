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
    public partial class OrcamentoForm : Form
    {
        
        private OrcamentoController orcamentoController = new OrcamentoController();

        private Orcamento orcamentoSelecionado = null;

        public OrcamentoForm()
        {
            InitializeComponent();
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            listBoxOrcamentos.DataSource = null;
            listBoxOrcamentos.DataSource = orcamentoController.ObterTodos();
        }

        private void btnCriarOrcamento_Click(object sender, EventArgs e)
        {
            
            decimal valorMaximo = Convert.ToDecimal(numericValorMaximo.Value);
            int mes = (int)numericMes.Value;
            int ano = (int)numericAno.Value;

            int idLogado = Sessao.UtilizadorLogado.Id;

            OrcamentoController orcamentoController = new OrcamentoController();
            bool sucesso = orcamentoController.criar(valorMaximo, mes, ano, idLogado);
            if (sucesso)
            {
                MessageBox.Show("Orcamento Criado");
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOrcamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrcamentos.SelectedItem != null)
            {
                /*Orcamento orcamentoSelecionado = listBoxOrcamentos.SelectedItem as Orcamento;
                
                //labelOrcamento.Text = orcamentoSelecionado.ValorMaximo;
                

                listBoxOrcamentos.DataSource = null;
                //listBoxOrcamentos.DataSource = orcamentoSelecionado.;
                listBoxOrcamentos.DataSource = null;*/
                // Faz o cast do objeto selecionado de volta para a classe Orcamento
                orcamentoSelecionado = listBoxOrcamentos.SelectedItem as Orcamento;

                if (orcamentoSelecionado != null)
                {
                    /*numericValorMaximo.Value = orcamentoSelecionado.ValorMaximo;
                    numericMes.Value = orcamentoSelecionado.Mes;
                    numericAno.Value = orcamentoSelecionado.Ano;*/
                    numericValorEditar.Value = orcamentoSelecionado.ValorMaximo;
                    numericMesEditar.Value = orcamentoSelecionado.Mes;
                    numericAnoEditar.Value = orcamentoSelecionado.Ano;
                }


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacao
            if (orcamentoSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione primeiro um orçamento na lista para o poder alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //novos valores alterados na edição
            decimal novoValor = Convert.ToDecimal(numericValorEditar.Value);
            int novoMes = (int)numericMesEditar.Value;
            int novoAno = (int)numericAnoEditar.Value;

            int idLogado = Sessao.UtilizadorLogado.Id;
            bool sucesso = orcamentoController.Atualizar(orcamentoSelecionado.Id, novoValor, novoMes, novoAno, idLogado);

            if (sucesso)
            {
                MessageBox.Show("Alterações gravadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarLista();

                
                orcamentoSelecionado = null;
                numericValorEditar.Value = 0;
                numericMesEditar.Value = 1;
                numericAnoEditar.Value = DateTime.Now.Year;
            }
            else
            {
                MessageBox.Show("Erro ao tentar guardar as alterações na Base de Dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (orcamentoSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione primeiro um orçamento na lista para o poder remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DialogResult resposta = MessageBox.Show(
                $"Tem a certeza que deseja apagar o orçamento de {orcamentoSelecionado.Mes}/{orcamentoSelecionado.Ano}?",
                "Confirmar Eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                
                bool sucesso = orcamentoController.Remover(orcamentoSelecionado.Id);

                if (sucesso)
                {
                    MessageBox.Show("Orçamento removido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarLista();

                    
                    orcamentoSelecionado = null;
                    numericValorEditar.Value = 0;
                    numericMesEditar.Value = 1;
                    numericAnoEditar.Value = DateTime.Now.Year;
                }
                else
                {
                    MessageBox.Show("Erro ao tentar remover o orçamento da Base de Dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            PrincipalForm form = new PrincipalForm();
            form.ShowDialog();
            this.Close();
        }


    }
}
