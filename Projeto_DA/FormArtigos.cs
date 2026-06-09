using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class FormArtigos : Form
    {
        private readonly ArtigoController controller = new ArtigoController();

        //flag para evitar que o filtro dispare enquanto as ComboBoxes estão a ser preenchidas
        private bool isLoadingCombos = false;

        public FormArtigos()
        {
            InitializeComponent();
        }

        private void FormArtigos_Load(object sender, EventArgs e)
        {
            LoadTiposFiltro();
            LoadArtigos(0); // 0 significa carregar "Todos" inicialmente
        }

        private void LoadTiposFiltro()
        {
            isLoadingCombos = true;

            var tiposOriginais = controller.GetTiposArtigo();

            List<TipoArtigo> tiposParaFiltro = new List<TipoArtigo>();
            tiposParaFiltro.Add(new TipoArtigo { Id = 0, Categoria = "[Ver Todos]" });
            tiposParaFiltro.AddRange(tiposOriginais);

            // Configura o Filtro Principal
            cbVerTipos.DataSource = null;
            cbVerTipos.DataSource = tiposParaFiltro;
            cbVerTipos.DisplayMember = "Categoria";
            cbVerTipos.ValueMember = "Id";

            // Configura a combo de Adicionar (apenas categorias reais)
            cbAdicionarCategoria.DataSource = null;
            cbAdicionarCategoria.DataSource = new List<TipoArtigo>(tiposOriginais);
            cbAdicionarCategoria.DisplayMember = "Categoria";
            cbAdicionarCategoria.ValueMember = "Id";

            // Configura a combo de Editar (apenas categorias reais)
            cbEditarCategoria.DataSource = null;
            cbEditarCategoria.DataSource = new List<TipoArtigo>(tiposOriginais);
            cbEditarCategoria.DisplayMember = "Categoria";
            cbEditarCategoria.ValueMember = "Id";

            isLoadingCombos = false;
        }

        private void LoadArtigos(int tipoId = 0)
        {
            lstArtigo.DataSource = null;
            lstArtigo.DataSource = controller.GetArtigos(tipoId);
            lstArtigo.DisplayMember = "NomeCategoria";
            lstArtigo.ValueMember = "Id";

            //remove qualquer seleção fantasma inicial para que os eventos não baralhem os campos de texto
            lstArtigo.ClearSelected();
        }

        //o código de filtragem ativa-se sempre que mudas a opção na ComboBox
        private void cbVerTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bloqueia a execução se estivermos a carregar as combos do zero ou se não houver item
            if (isLoadingCombos || cbVerTipos.SelectedValue == null)
                return;

            // Obtém o ID selecionado (pode ser um ID real ou 0 para Todos) e atualiza a ListBox
            int tipoIdSelected = Convert.ToInt32(cbVerTipos.SelectedValue);
            LoadArtigos(tipoIdSelected);
        }

        private void lstArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstArtigo.SelectedItem == null)
            {
                txtEditarNome.Clear();
                return;
            }

            var artigo = (Artigo)lstArtigo.SelectedItem;
            txtEditarNome.Text = artigo.Nome;

            if (artigo.TipoArtigo != null)
            {
                cbEditarCategoria.SelectedValue = artigo.TipoArtigo.Id;
            }
        }

        private void btnAdicionarArtigo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdicionarNome.Text))
            {
                MessageBox.Show("O nome do artigo é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbAdicionarCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma categoria válida para adicionar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tipoId = Convert.ToInt32(cbAdicionarCategoria.SelectedValue);

            controller.AdicionarArtigo(txtAdicionarNome.Text.Trim(), tipoId);

            //atualiza a lista respeitando o filtro de visualização que está ativo no momento
            int filtroAtual = cbVerTipos.SelectedValue != null ? Convert.ToInt32(cbVerTipos.SelectedValue) : 0;
            LoadArtigos(filtroAtual);

            //limpa o campo de texto de adição e de edição após o sucesso
            txtAdicionarNome.Clear();
            txtEditarNome.Clear();

            MessageBox.Show("Artigo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarArtigo_Click(object sender, EventArgs e)
        {
            if (lstArtigo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um artigo na lista para o poder editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditarNome.Text))
            {
                MessageBox.Show("O nome não pode estar vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEditarCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma categoria válida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artigo = (Artigo)lstArtigo.SelectedItem;
            int novoTipoId = Convert.ToInt32(cbEditarCategoria.SelectedValue);

            controller.EditarArtigo(artigo.Id, txtEditarNome.Text.Trim(), novoTipoId);

            //recarrega os artigos mantendo o filtro ativo
            int filtroAtual = cbVerTipos.SelectedValue != null ? Convert.ToInt32(cbVerTipos.SelectedValue) : 0;
            LoadArtigos(filtroAtual);

            //limpa a caixa de texto para demonstrar visualmente o fim da edição
            txtEditarNome.Clear();

            //corrigido de "updated" para português
            MessageBox.Show("Artigo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarArtigo_Click(object sender, EventArgs e)
        {
            if (lstArtigo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um artigo na lista para o poder eliminar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artigo = (Artigo)lstArtigo.SelectedItem;

            DialogResult resultado = MessageBox.Show(
                $"Tem a certeza que pretende eliminar '{artigo.Nome}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            controller.EliminarArtigo(artigo.Id);

            //recarrega mantendo o filtro ativo
            int filtroAtual = cbVerTipos.SelectedValue != null ? Convert.ToInt32(cbVerTipos.SelectedValue) : 0;
            LoadArtigos(filtroAtual);

            txtEditarNome.Clear();

            MessageBox.Show("Artigo eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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