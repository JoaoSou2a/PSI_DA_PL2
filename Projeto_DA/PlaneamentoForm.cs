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
using System.IO;

namespace Projeto_DA
{
    public partial class PlaneamentoForm : Form
    {
        private readonly PlaneamentoController controller = new PlaneamentoController();

        public PlaneamentoForm()
        {
            InitializeComponent();
            CarregarComboEstado();
            CarregarComboCriadoPor();
            CarregarCompras();
        }

        private void CarregarComboEstado()
        {
            comboBox_Estado.Items.Clear();
            comboBox_Estado.Items.Add("Todos");
            comboBox_Estado.Items.Add("Aberta");
            comboBox_Estado.Items.Add("Fechada");
            comboBox_Estado.SelectedIndex = 0;
        }

        private void CarregarComboCriadoPor()
        {
            comboBox_Criadopor.Items.Clear();
            comboBox_Criadopor.Items.Add("Todos");

            var utilizadores = controller.ObterUtilizadores();
            foreach (var u in utilizadores)
                comboBox_Criadopor.Items.Add(u);

            comboBox_Criadopor.SelectedIndex = 0;
        }

        private void CarregarCompras()
        {
            var compras = controller.ObterTodos();
            AtualizarLista(compras);
        }

        private void AtualizarLista(List<Compra> compras)
        {
            ltbox_Compras.Items.Clear();
            foreach (var c in compras)
                ltbox_Compras.Items.Add(c);

            int total = compras.Count;
            int abertas = compras.Count(c => !c.Fechada);
            int fechadas = compras.Count(c => c.Fechada);

            lb_TotalCompras.Text = $"Total de Compras: {total}";
            lb_Abertas.Text = $"Abertas: {abertas}";
            lb_Fechadas.Text = $"Fechadas: {fechadas}";
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string estado = comboBox_Estado.SelectedItem?.ToString();
            if (estado == "Todos") estado = null;

            int? utilizadorId = null;
            if (comboBox_Criadopor.SelectedItem is Utilizador u)
                utilizadorId = u.Id;

            var compras = controller.ObterFiltrado(estado, utilizadorId);
            AtualizarLista(compras);
        }

        private void picbox_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            PrincipalForm form = new PrincipalForm();
            form.ShowDialog();
            this.Close();
        }

        private void btn_CriarAlterarCompra_Click(object sender, EventArgs e)
        {
            Compra compraSelecionada = ltbox_Compras.SelectedItem as Compra;

            Criar_AlterarCompraForm form = new Criar_AlterarCompraForm(compraSelecionada);
            form.ShowDialog();
            CarregarCompras();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            var compra = ltbox_Compras.SelectedItem as Compra;
            if (compra == null)
            {
                MessageBox.Show("Seleciona uma compra.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (compra.Fechada)
            {
                MessageBox.Show("Não é possível remover uma compra fechada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacao = MessageBox.Show("Tens a certeza que queres remover esta compra?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                controller.RemoverCompra(compra.Id);
                CarregarCompras();
            }
        }

        private void btn_ExportarCSV_Click(object sender, EventArgs e)
        {
            //obter os dados tratados vindos do controlador
            var dadosExportacao = controller.ObterDadosParaExportacao();

            if (dadosExportacao == null || dadosExportacao.Count == 0)
            {
                MessageBox.Show("Não existem compras fechadas com dados para exportar.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //configurar a Janela para o utilizador escolher onde guardar o ficheiro CSV
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Ficheiro CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Exportar Compras Fechadas para CSV";
                saveFileDialog.FileName = $"Exportacao_Compras_{DateTime.Now:yyyyMMdd_HHmm}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder csvContent = new StringBuilder();

                        
                        
                        csvContent.AppendLine("NomeCompra\t\t; DataCriacao\t\t; DataFechada\t\t; NomeArtigo\t; ArtigoPrevisto\t; ArtigoNaoPrevisto\t; QtdPrev\t; QtdAdq\t; PrecoUnitario");
                        csvContent.AppendLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                        //preencher os dados linha a linha alinhados dinamicamente
                        foreach (var linha in dadosExportacao)
                        {
                            string dataCriacaoStr = linha.DataCriacao.ToString("dd/MM/yyyy HH:mm");
                            string dataFechadaStr = linha.DataFechada.ToString("dd/MM/yyyy HH:mm");

                            //trunca ou ajusta o tamanho dos nomes para não empurrar as colunas para o lado no Bloco de Notas
                            string nomeCompra = (linha.NomeCompra ?? "").PadRight(15);
                            string nomeArtigo = (linha.NomeArtigo ?? "").PadRight(12);

                            string precoStr = linha.PrecoUnitario.ToString("F2").Replace(",", ".") + "€";

                            //monta a linha usando tabulações para o Bloco de Notas alinhar verticalmente
                            csvContent.AppendLine($"{nomeCompra}\t; {dataCriacaoStr}\t; {dataFechadaStr}\t; {nomeArtigo}\t; {linha.ArtigoPrevisto}\t\t; {linha.ArtigoNaoPrevisto}\t\t; {linha.QuantidadePrevista}\t; {linha.QuantidadeAdquirida}\t; {precoStr}");
                        }

                        //gravar com Encoding UTF8 para o Bloco de Notas reconhecer o 'ã' do "Não" imediatamente
                        File.WriteAllText(saveFileDialog.FileName, csvContent.ToString(), Encoding.UTF8);

                        MessageBox.Show("Exportação concluída com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao exportar o ficheiro: {ex.Message}", "Erro Crítico",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    
}
