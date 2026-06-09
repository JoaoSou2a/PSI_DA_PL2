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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static Projeto_DA.Program;

namespace Projeto_DA
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            CarregarDadosUtilizador();
            CarregarOrcamentoMesAtual();
            CarregarComprasEmAberto();
        }

        private void CarregarComprasEmAberto()
        {
            ltb_ComprasAberto.Items.Clear();
            var compras = new HomeController().ObterComprasEmAberto();
            foreach (var c in compras)
                ltb_ComprasAberto.Items.Add(c);
        }

        private void CarregarDadosUtilizador()
        {
            lb_username.Text = HomeController.ObterNomeUtilizador();
        }

        private void CarregarOrcamentoMesAtual()
        {
            var orcamento = HomeController.ObterOrcamentoMesAtual();
            if (orcamento != null)
            {
                string nomeMes = new DateTime(orcamento.Ano, orcamento.Mes, 1).ToString("MMMM");
                nomeMes = char.ToUpper(nomeMes[0]) + nomeMes.Substring(1);

                //calcular o total REAL gasto em compras fechadas neste mês/ano
                decimal totalGastoNoMes = 0;

                using (var db = new IShoppingContext())
                {
                    //filtra as compras que foram fechadas no mesmo mês e ano do orçamento atual
                    var comprasFechadasDoMes = db.Compras
                        .Where(c => c.Fechada && c.DataFechada.HasValue &&
                                    c.DataFechada.Value.Month == orcamento.Mes &&
                                    c.DataFechada.Value.Year == orcamento.Ano)
                        .ToList();

                    // Soma o valor real de todos os itens associados a estas compras
                    foreach (var comp in comprasFechadasDoMes)
                    {
                        totalGastoNoMes += db.Set<ItemCompra>()
                            .Where(i => i.Compra.Id == comp.Id)
                            .Sum(i => (decimal?)(i.QuantidadeAdquirida * i.PrecoUnitario)) ?? 0;
                    }
                }

                //calcular o dinheiro que sobra subtraindo o gasto real
                decimal disponivelRestante = orcamento.ValorMaximo - totalGastoNoMes;

                //atualizar as labels com as contas certas
                lb_orcamento.Text = $"Orçamento para o mês de {nomeMes}: {orcamento.ValorMaximo:F2}€";
                lb_dinheirorestante.Text = $"{disponivelRestante:F2}€ disponível";

                //margem visual de segurança (muda a cor para vermelho se estourares o orçamento)
                if (disponivelRestante < 0)
                {
                    lb_dinheirorestante.ForeColor = Color.Red;
                }
                else
                {
                    lb_dinheirorestante.ForeColor = Color.LightGreen;
                }
            }
            else
            {
                lb_orcamento.Text = "Orçamento do mês: Não definido";
                lb_dinheirorestante.Text = "—";
            }
        }

        private void btnUtilizadores_Click(object sender, EventArgs e)
        {
                this.Hide();

                GestaoUtilizador form = new GestaoUtilizador();
                form.ShowDialog();
                this.Close();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();

            PrincipalForm form = new PrincipalForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnTiposdeArtigos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormTipoArtigos form = new FormTipoArtigos();
            form.ShowDialog();
            this.Close();
        }

        private void btnArtigos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormArtigos form = new FormArtigos();
            form.ShowDialog();
            this.Close();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            this.Hide();

            OrcamentoForm form = new OrcamentoForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnPlaneamento_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlaneamentoForm form = new PlaneamentoForm();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show($"Adeus!", "Saída", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }

        private void btn_ModoCompra_Click(object sender, EventArgs e)
        {
            Compra compraSelecionada = ltb_ComprasAberto.SelectedItem as Compra;

            if (compraSelecionada == null)
            {
                MessageBox.Show("Por favor, selecione uma compra em aberto na lista para entrar no Modo Compra!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ModoCompraForm form = new ModoCompraForm(compraSelecionada);
            form.ShowDialog();
            CarregarComprasEmAberto();
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            this.Hide();

            Estatisticas form = new Estatisticas();
            form.ShowDialog();
            this.Close();
        }

        private void lb_orcamento_Click(object sender, EventArgs e)
        {

        }
    }
}
