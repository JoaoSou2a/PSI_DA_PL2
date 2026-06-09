using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class FormArtigos : Form
    {
        private readonly ArtigoController controller = new ArtigoController();

        public FormArtigos()
        {
            InitializeComponent();
        }

        private void FormArtigos_Load(object sender, EventArgs e)
        {
            LoadTiposFiltro();
            LoadArtigos();
        }

        private void LoadTiposFiltro()
        {
            var tipos = controller.GetTiposArtigo();

            cbVerTipos.DataSource = null;
            cbVerTipos.DataSource = tipos;
            cbVerTipos.DisplayMember = "Categoria";
            cbVerTipos.ValueMember = "Id";

            cbAdicionarCategoria.DataSource = null;
            cbAdicionarCategoria.DataSource = controller.GetTiposArtigo();
            cbAdicionarCategoria.DisplayMember = "Categoria";
            cbAdicionarCategoria.ValueMember = "Id";

            cbEditarCategoria.DataSource = null;
            cbEditarCategoria.DataSource = controller.GetTiposArtigo();
            cbEditarCategoria.DisplayMember = "Categoria";
            cbEditarCategoria.ValueMember = "Id";
        }

        private void LoadArtigos(int tipoId = 0)
        {
            lstArtigos.DataSource = null;
            lstArtigos.DataSource = controller.GetArtigos(tipoId);
            lstArtigos.DisplayMember = "NomeCategoria";
            lstArtigos.ValueMember = "Id";
        }

        private void cbVerTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVerTipos.SelectedItem == null)
                return;

            var tipo = (TipoArtigo)cbVerTipos.SelectedItem;
            LoadArtigos(tipo.Id);
        }

        private void lstArtigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstArtigos.SelectedItem == null)
            {
                txtEditarNome.Clear();
                return;
            }

            var artigo = (Artigo)lstArtigos.SelectedItem;

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
                MessageBox.Show(
                    "O nome do artigo é obrigatório!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cbAdicionarCategoria.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecione uma categoria!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var tipo = (TipoArtigo)cbAdicionarCategoria.SelectedItem;

            controller.AdicionarArtigo(
                txtAdicionarNome.Text.Trim(),
                tipo.Id);

            LoadArtigos();

            txtAdicionarNome.Clear();

            MessageBox.Show(
                "Artigo adicionado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEditarArtigo_Click(object sender, EventArgs e)
        {
            if (lstArtigos.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecione um artigo!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditarNome.Text))
            {
                MessageBox.Show(
                    "O nome não pode estar vazio!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var artigo = (Artigo)lstArtigos.SelectedItem;
            var tipo = (TipoArtigo)cbEditarCategoria.SelectedItem;

            controller.EditarArtigo(
                artigo.Id,
                txtEditarNome.Text.Trim(),
                tipo.Id);

            LoadArtigos();

            MessageBox.Show(
                "Artigo atualizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEliminarArtigo_Click(object sender, EventArgs e)
        {
            if (lstArtigos.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecione um artigo!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var artigo = (Artigo)lstArtigos.SelectedItem;

            DialogResult resultado = MessageBox.Show(
                $"Tem a certeza que pretende eliminar '{artigo.Nome}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            controller.EliminarArtigo(artigo.Id);

            LoadArtigos();

            txtEditarNome.Clear();

            MessageBox.Show(
                "Artigo eliminado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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