using Projeto_DA.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Estatisticas : Form
    {
        private readonly EstatisticasController _controller = new EstatisticasController();

        public Estatisticas()
        {
            InitializeComponent();
            CarregarPrimeiroSeparador();
            ConfigurarSugestoesIniciais();
        }

        private void CarregarPrimeiroSeparador()
        {
            // Carrega o Histórico Mensal (Alínea a)
            listBoxHistoricoMensal.DataSource = null;
            listBoxHistoricoMensal.DataSource = _controller.ObterDadosMensais();

            // Carrega as Compras Fechadas e as respetivas Percentagens (Alínea b)
            listBoxComprasPercentagens.DataSource = null;
            listBoxComprasPercentagens.DataSource = _controller.ObterDadosComprasFechadas();
        }

        private void ConfigurarSugestoesIniciais()
        {
            // Define por defeito visualmente a semana atual com base na data do sistema
            int semanaAtual = _controller.ObterSemanaDoMes(DateTime.Now);
            lblSemanaAtualIdentificada.Text = $"Semana Atual detetada no Sistema: {semanaAtual}ª Semana";

            // Ativa o RadioButton correspondente à semana atual automaticamente para facilitar o uso
            if (semanaAtual == 1) rbSemana1.Checked = true;
            else if (semanaAtual == 2) rbSemana2.Checked = true;
            else if (semanaAtual == 3) rbSemana3.Checked = true;
            else rbSemana4.Checked = true;
        }

        private void btnGerarSugestoes_Click(object sender, EventArgs e)
        {
            // 1. Processar a sugestão do valor do Orçamento do Próximo Mês
            decimal orcamentoSugerido = _controller.SugerirOrcamentoProximoMes();
            lblSugestaoOrcamento.Text = $"Sugestão de Orçamento Recomendado: {orcamentoSugerido:F2}€";

            // 2. Determinar a semana alvo com base nos controlos RadioButton selecionados
            int semanaAlvo = 1;
            if (rbSemana1.Checked) semanaAlvo = 1;
            else if (rbSemana2.Checked) semanaAlvo = 2;
            else if (rbSemana3.Checked) semanaAlvo = 3;
            else if (rbSemana4.Checked) semanaAlvo = 4;

            // 3. Obter a lista preditiva calculada pelo controlador
            List<string> artigosSugeridos = _controller.SugerirListaComprasProximaSemana(semanaAlvo);

            listBoxArtigosSugeridos.Items.Clear();
            if (artigosSugeridos != null && artigosSugeridos.Count > 0)
            {
                foreach (var artigo in artigosSugeridos)
                {
                    listBoxArtigosSugeridos.Items.Add(artigo);
                }
            }
            else
            {
                listBoxArtigosSugeridos.Items.Add("Sem histórico suficiente nesta semana para prever artigos.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxArtigosSugeridos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxHistoricoMensal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
