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
                lb_orcamento.Text = $"Orçamento para o mês de {nomeMes}: {orcamento.ValorMaximo:F2}€";
                lb_dinheirorestante.Text = $"{orcamento.ValorMaximo:F2}€ disponível";
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

            ModoCompraForm form = new ModoCompraForm(compraSelecionada);
            form.ShowDialog();
            CarregarComprasEmAberto();
        }
    }
}
