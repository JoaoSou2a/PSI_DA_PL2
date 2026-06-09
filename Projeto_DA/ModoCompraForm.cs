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

namespace Projeto_DA
{
    public partial class ModoCompraForm : Form
    {
        private readonly ModoCompraController _controller = new ModoCompraController();
        private Compra compra;

        public ModoCompraForm(Compra compra)
        {
            InitializeComponent();
            this.compra = compra;
            CarregarTudo();
        }

        private void CarregarTudo()
        {
            CarregarDadosCompra();
            CarregarOrcamento();
            CarregarItensPrev();
            CarregarItensNaoPrev();
            CarregarTiposArtigo();
        }

        private void CarregarDadosCompra()
        {
            lb_ModoCompra.Text = $"Modo Compra: {compra.NomeCompra}";
        }

        private void CarregarOrcamento()
        {
            var orcamento = _controller.ObterOrcamentoMesAtual();
            decimal totalGasto = _controller.ObterTotalGasto(compra.Id);

            if (orcamento != null)
            {
                decimal disponivel = orcamento.ValorMaximo - totalGasto;
                string nomeMes = new DateTime(orcamento.Ano, orcamento.Mes, 1).ToString("MMMM");
                nomeMes = char.ToUpper(nomeMes[0]) + nomeMes.Substring(1);

                lb_orcamento.Text = $"Orçamento de {nomeMes}: {orcamento.ValorMaximo:F2}€";
                lb_TotalGasto.Text = $"Total Gasto: {totalGasto:F2}€";
                lb_dinheirodisponivel.Text = $"Disponível: {disponivel:F2}€";

                if (disponivel < 0)
                {
                    lb_dinheirodisponivel.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Atenção! O orçamento do mês foi ultrapassado!",
                        "Orçamento Ultrapassado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lb_dinheirodisponivel.ForeColor = System.Drawing.Color.ForestGreen;
                }
            }
            else
            {
                lb_orcamento.Text = "Orçamento do mês: Não definido";
                lb_TotalGasto.Text = $"Total Gasto: {totalGasto:F2}€";
                lb_dinheirodisponivel.Text = "Disponível: —";
            }
        }

        private void CarregarItensPrev()
        {
            ltb_Itensprevistos.Items.Clear();
            var itens = _controller.ObterItensPrev(compra.Id);
            foreach (var item in itens)
                ltb_Itensprevistos.Items.Add(item);
        }

        private void CarregarItensNaoPrev()
        {
            ltb_ItensNPrevistos.Items.Clear();
            var itens = _controller.ObterItensNaoPrev(compra.Id);
            foreach (var item in itens)
                ltb_ItensNPrevistos.Items.Add(item);
        }

        private void CarregarTiposArtigo()
        {
            cb_TipoArtigo.Items.Clear();
            var tipos = _controller.ObterTiposArtigo();
            foreach (var t in tipos)
                cb_TipoArtigo.Items.Add(t);
            if (cb_TipoArtigo.Items.Count > 0)
                cb_TipoArtigo.SelectedIndex = 0;
        }

        private void ltb_Itensprevistos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ltb_Itensprevistos.SelectedItem as ItemPrevisto;
            if (item == null) return;

            txt_QntdAdquirida.Text = item.QuantidadeAdquirida.ToString();
            txt_PrecoUni.Text = item.PrecoUnitario.ToString("F2");
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var item = ltb_Itensprevistos.SelectedItem as ItemPrevisto;
            if (item == null)
            {
                MessageBox.Show("Seleciona um item previsto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_QntdAdquirida.Text, out int qtd) || qtd < 0)
            {
                MessageBox.Show("Quantidade inválida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_PrecoUni.Text, out decimal preco) || preco < 0)
            {
                MessageBox.Show("Preço inválido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _controller.GuardarItemPrevisto(item.Id, qtd, preco);
            CarregarItensPrev();
            CarregarOrcamento();
        }

        private void cb_TipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TipoArtigo.SelectedItem is TipoArtigo tipo)
            {
                cb_Artigo.Items.Clear();
                var artigos = _controller.ObterArtigosPorTipo(tipo.Id);
                foreach (var a in artigos)
                    cb_Artigo.Items.Add(a);
                if (cb_Artigo.Items.Count > 0)
                    cb_Artigo.SelectedIndex = 0;
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            var artigo = cb_Artigo.SelectedItem as Artigo;
            if (artigo == null)
            {
                MessageBox.Show("Seleciona um artigo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_Quantidade.Text, out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Quantidade inválida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_PrecoUnita.Text, out decimal preco) || preco < 0)
            {
                MessageBox.Show("Preço inválido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool sucesso = _controller.AdicionarItemNaoPrevisto(
                compra.Id, artigo.Id, qtd, preco, txt_Observacoes.Text);

            if (sucesso)
            {
                cb_TipoArtigo.SelectedIndex = 0;
                txt_Quantidade.Text = "";
                txt_PrecoUnita.Text = "";
                txt_Observacoes.Text = "";

                CarregarItensNaoPrev();
                CarregarOrcamento();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            var item = ltb_ItensNPrevistos.SelectedItem as ItemNaoPrevisto;
            if (item == null)
            {
                MessageBox.Show("Seleciona um item não previsto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacao = MessageBox.Show("Tens a certeza que queres remover este item?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                _controller.RemoverItemNaoPrevisto(item.Id);
                CarregarItensNaoPrev();
                CarregarOrcamento();
            }
        }

        private void btn_FecharCompra_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Tens a certeza que queres fechar esta compra?",
                "Fechar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                int utilizadorId = Program.Sessao.UtilizadorLogado.Id;
                bool sucesso = _controller.FecharCompra(compra.Id, utilizadorId);

                if (sucesso)
                {
                    MessageBox.Show("Compra fechada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void picbox_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
