using Projeto_DA.Models;
using System;
using System.ComponentModel;
using System.Data.Entity.Infrastructure; // Importante para capturar o DbUpdateException
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

            try
            {
                db.TipoArtigos.Add(novoTipo);
                db.SaveChanges();

                LoadTipos();
                txtCategoria.Clear();
                MessageBox.Show("Categoria adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                db.Entry(novoTipo).State = System.Data.Entity.EntityState.Detached;

                MessageBox.Show("Erro ao guardar na Base de Dados. Verifica se o ID da tabela está configurado como Identity (Auto-incremento) ou se a categoria já existe.",
                    "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string valorOriginal = tipoSelecionado.Categoria; // Salvaguarda

            tipoSelecionado.Categoria = txtEditarTipo.Text.Trim();

            try
            {
                db.SaveChanges();
                LoadTipos();
                MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException)
            {
                tipoSelecionado.Categoria = valorOriginal;

                MessageBox.Show("Não foi possível atualizar a categoria. Verifica se existem restrições de tamanho ou valores duplicados na BD.",
                    "Erro ao Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                try
                {
                    db.TipoArtigos.Remove(tipoSelecionado);
                    db.SaveChanges();

                    LoadTipos();
                    txtEditarTipo.Clear();
                    MessageBox.Show("Categoria eliminada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbUpdateException)
                {
                   db.Entry(tipoSelecionado).State = System.Data.Entity.EntityState.Unchanged;

                    MessageBox.Show("Não pode eliminar esta categoria porque existem Artigos associados a ela! Elimine ou mude esses artigos primeiro.",
                        "Erro de Integridade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao eliminar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalForm form = new PrincipalForm();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }
    }
}