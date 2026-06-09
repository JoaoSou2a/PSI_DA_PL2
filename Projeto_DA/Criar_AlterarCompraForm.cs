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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_DA
{
    public partial class Criar_AlterarCompraForm : Form
    {
        private readonly CriarAlterarCompraController controller = new CriarAlterarCompraController();
        private Compra compra; 
        private List<ItemPrevisto> itensPrev = new List<ItemPrevisto>();

        public Criar_AlterarCompraForm(Compra compra = null)
        {
            InitializeComponent();
            this.compra = compra;
            CarregarTiposArtigo();
            CarregarDados();
        }

        private void CarregarTiposArtigo()
        {
            comboBox_TipoArtigo.Items.Clear();
            var tipos = controller.ObterTiposArtigo();
            foreach (var t in tipos)
                comboBox_TipoArtigo.Items.Add(t);

            if (comboBox_TipoArtigo.Items.Count > 0)
                comboBox_TipoArtigo.SelectedIndex = 0;
        }

        private void CarregarDados()
        {
            if (compra == null)
            {
                lb_DatadaCriacao.Text = $"Data de Criação: {DateTime.Now:dd/MM/yyyy HH:mm}";
                lb_Criar_AlterarComra.Text = "Criar Compra";
            }
            else
            {
                lb_Criar_AlterarComra.Text = "Alterar Compra";
                textBox1.Text = compra.NomeCompra;
                lb_DatadaCriacao.Text = $"Data de Criação: {compra.DataCriacao:dd/MM/yyyy HH:mm}";

                cb_ArtigoAtualizar.Items.Clear();
                var todosArtigos = controller.ObterArtigosPorTipo(compra.Id);
                itensPrev = controller.ObterItensPorCompra(compra.Id);

                foreach (var item in itensPrev)
                {
                    if (!cb_ArtigoAtualizar.Items.Cast<Artigo>().Any(a => a.Id == item.Artigo.Id))
                        cb_ArtigoAtualizar.Items.Add(item.Artigo);
                }

                AtualizarListBox();

                if (lb_Criar_AlterarComra.Text == "Criar Compra")
                {
                    cb_ArtigoAtualizar.Enabled = false;
                    numericUpDown_Alterar.Enabled = false;
                    btn_Atualizar.Enabled = false;
                }
                             
                if (compra.Fechada)
                {
                    textBox1.ReadOnly = true;
                    comboBox_TipoArtigo.Enabled = false;
                    comboBox_Artigo.Enabled = false;
                    cb_ArtigoAtualizar.Enabled = false;
                    numericUpDown_Alterar.Enabled = false;
                    numericUpDown1.Enabled = false;
                    btn_Adicionar.Enabled = false;
                    btn_remover.Enabled = false;
                    btn_guardar.Enabled = false;
                    btn_Atualizar.Enabled = false;
                }
            }
        }

        private void comboBox_TipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TipoArtigo.SelectedItem is TipoArtigo tipo)
            {
                comboBox_Artigo.Items.Clear();
                var artigos = controller.ObterArtigosPorTipo(tipo.Id);
                foreach (var artigo in artigos)
                    comboBox_Artigo.Items.Add(artigo);

                if (comboBox_Artigo.Items.Count > 0)
                    comboBox_Artigo.SelectedIndex = 0;
            }
        }

        private void btn_Adicionar_Click_1(object sender, EventArgs e)
        {
            var artigo = comboBox_Artigo.SelectedItem as Artigo;
            if (artigo == null)
            {
                MessageBox.Show("Seleciona um artigo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itensPrev.Exists(i => i.Artigo.Id == artigo.Id))
            {
                MessageBox.Show("Este artigo já foi adicionado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new ItemPrevisto
            {
                Artigo = artigo,
                QuantidadePrevista = (int)numericUpDown1.Value
            };

            itensPrev.Add(item);
            AtualizarListBox();
        }

        private void btn_remover_Click_1(object sender, EventArgs e)
        {
            if (ltb_Itensprevistos.SelectedItem is ItemPrevisto item)
            {
                itensPrev.Remove(item);
                AtualizarListBox();
            }
        }

        private void AtualizarListBox()
        {
            ltb_Itensprevistos.Items.Clear();
            foreach (var item in itensPrev)
                ltb_Itensprevistos.Items.Add(item);
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Insere o nome da compra.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int utilizadorId = Program.Sessao.UtilizadorLogado.Id;
            bool sucesso;

            if (compra == null)
                sucesso = controller.CriarCompra(textBox1.Text, itensPrev, utilizadorId);
            else
                sucesso = controller.AlterarCompra(compra.Id, textBox1.Text, itensPrev, utilizadorId);

            if (sucesso)
            {
                MessageBox.Show("Guardado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void picBox_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Artigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ltb_Itensprevistos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb_Itensprevistos.SelectedItem is ItemPrevisto itemSelecionado)
            {
                numericUpDown_Alterar.Value = itemSelecionado.QuantidadePrevista;

                foreach (Artigo artigo in cb_ArtigoAtualizar.Items)
                {
                    if (artigo.Id == itemSelecionado.Artigo.Id)
                    {
                        cb_ArtigoAtualizar.SelectedItem = artigo;
                        break;
                    }
                }
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (ltb_Itensprevistos.SelectedItem is ItemPrevisto itemSelecionado)
            {
                var novoArtigo = cb_ArtigoAtualizar.SelectedItem as Artigo;
                if (novoArtigo == null)
                {
                    MessageBox.Show("Por favor, selecione um artigo válido para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var itemNaLista = itensPrev.FirstOrDefault(i => i.Artigo.Id == itemSelecionado.Artigo.Id);

                if (itemNaLista != null)
                {
                    itemNaLista.Artigo = novoArtigo;
                    itemNaLista.QuantidadePrevista = (int)numericUpDown_Alterar.Value;

                    AtualizarListBox();

                    MessageBox.Show("Item atualizado na lista com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
