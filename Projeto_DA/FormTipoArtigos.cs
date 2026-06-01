using Projeto_DA.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class FormTipoArtigos : Form
    {
        private readonly IShoppingContext db = new IShoppingContext();

        public FormTipoArtigos()
        {
            InitializeComponent();
        }

        private void LoadTipos()
        {
            var tipos = db.TipoArtigos.ToList();
            lstTipos.DataSource = null;
            lstTipos.DataSource = tipos;
            lstTipos.DisplayMember = "Categoria";
            lstTipos.ValueMember = "Id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTipos();
        }

        private void btnAdicionarTipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text?.Trim()))
            {
                MessageBox.Show("A categoria é obrigatória!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var novoTipo = new TipoArtigo
            {
                Categoria = txtCategoria.Text.Trim()
            };

            db.TipoArtigos.Add(novoTipo);
            db.SaveChanges();

            LoadTipos();
            txtCategoria.Clear();
            MessageBox.Show("Categoria adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            if (lstTipos.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria para editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditarTipo.Text?.Trim()))
            {
                MessageBox.Show("A categoria não pode estar vazia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tipoSelecionado = (TipoArtigo)lstTipos.SelectedItem;
            tipoSelecionado.Categoria = txtEditarTipo.Text.Trim();

            db.SaveChanges();

            LoadTipos();
            MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarTipo_Click(object sender, EventArgs e)
        {
            if (lstTipos.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria para eliminar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tipoSelecionado = (TipoArtigo)lstTipos.SelectedItem;

            var confirm = MessageBox.Show(
                $"Tem certeza que deseja eliminar a categoria '{tipoSelecionado.Categoria}'?",
                "Confirmar Eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                db.TipoArtigos.Remove(tipoSelecionado);
                db.SaveChanges();

                LoadTipos();
                txtEditarTipo.Clear();
                MessageBox.Show("Categoria eliminada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipos.SelectedItem != null)
            {
                var tipo = (TipoArtigo)lstTipos.SelectedItem;
                txtEditarTipo.Text = tipo.Categoria;
            }
            else
            {
                txtEditarTipo.Clear();
            }
        }

        private void btnArt_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormArtigos formArtigos = new FormArtigos();
            formArtigos.ShowDialog();
            this.Close();
        }
    }
}