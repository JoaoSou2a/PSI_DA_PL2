namespace Projeto_DA
{
    partial class FormArtigos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArtigos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox_voltar = new System.Windows.Forms.PictureBox();
            this.txtgestaoartigos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVerTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdicionarNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAdicionarCategoria = new System.Windows.Forms.ComboBox();
            this.btnAdicionarArtigo = new System.Windows.Forms.Button();
            this.txtEditarNome = new System.Windows.Forms.TextBox();
            this.cbEditarCategoria = new System.Windows.Forms.ComboBox();
            this.btnEditarArtigo = new System.Windows.Forms.Button();
            this.btnEliminarArtigo = new System.Windows.Forms.Button();
            this.lstArtigos = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.picbox_voltar);
            this.panel1.Controls.Add(this.txtgestaoartigos);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 115);
            this.panel1.TabIndex = 0;
            // 
            // picbox_voltar
            // 
            this.picbox_voltar.Image = ((System.Drawing.Image)(resources.GetObject("picbox_voltar.Image")));
            this.picbox_voltar.Location = new System.Drawing.Point(53, 38);
            this.picbox_voltar.Name = "picbox_voltar";
            this.picbox_voltar.Size = new System.Drawing.Size(50, 39);
            this.picbox_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_voltar.TabIndex = 3;
            this.picbox_voltar.TabStop = false;
            this.picbox_voltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtgestaoartigos
            // 
            this.txtgestaoartigos.AutoSize = true;
            this.txtgestaoartigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtgestaoartigos.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgestaoartigos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtgestaoartigos.Location = new System.Drawing.Point(405, 38);
            this.txtgestaoartigos.Name = "txtgestaoartigos";
            this.txtgestaoartigos.Size = new System.Drawing.Size(257, 36);
            this.txtgestaoartigos.TabIndex = 2;
            this.txtgestaoartigos.Text = "Gestão de Artigos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ver Artigos pela Categoria:";
            // 
            // cbVerTipos
            // 
            this.cbVerTipos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVerTipos.FormattingEnabled = true;
            this.cbVerTipos.Location = new System.Drawing.Point(36, 175);
            this.cbVerTipos.Name = "cbVerTipos";
            this.cbVerTipos.Size = new System.Drawing.Size(197, 32);
            this.cbVerTipos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(825, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Do Artigo:";
            // 
            // txtAdicionarNome
            // 
            this.txtAdicionarNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionarNome.Location = new System.Drawing.Point(830, 177);
            this.txtAdicionarNome.Name = "txtAdicionarNome";
            this.txtAdicionarNome.Size = new System.Drawing.Size(192, 30);
            this.txtAdicionarNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria:";
            // 
            // cbAdicionarCategoria
            // 
            this.cbAdicionarCategoria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdicionarCategoria.FormattingEnabled = true;
            this.cbAdicionarCategoria.Location = new System.Drawing.Point(596, 175);
            this.cbAdicionarCategoria.Name = "cbAdicionarCategoria";
            this.cbAdicionarCategoria.Size = new System.Drawing.Size(197, 32);
            this.cbAdicionarCategoria.TabIndex = 7;
            // 
            // btnAdicionarArtigo
            // 
            this.btnAdicionarArtigo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAdicionarArtigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarArtigo.Location = new System.Drawing.Point(749, 234);
            this.btnAdicionarArtigo.Name = "btnAdicionarArtigo";
            this.btnAdicionarArtigo.Size = new System.Drawing.Size(129, 39);
            this.btnAdicionarArtigo.TabIndex = 8;
            this.btnAdicionarArtigo.Text = "Adicionar";
            this.btnAdicionarArtigo.UseVisualStyleBackColor = false;
            // 
            // txtEditarNome
            // 
            this.txtEditarNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarNome.Location = new System.Drawing.Point(608, 370);
            this.txtEditarNome.Name = "txtEditarNome";
            this.txtEditarNome.Size = new System.Drawing.Size(197, 30);
            this.txtEditarNome.TabIndex = 9;
            // 
            // cbEditarCategoria
            // 
            this.cbEditarCategoria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditarCategoria.FormattingEnabled = true;
            this.cbEditarCategoria.Location = new System.Drawing.Point(608, 407);
            this.cbEditarCategoria.Name = "cbEditarCategoria";
            this.cbEditarCategoria.Size = new System.Drawing.Size(197, 32);
            this.cbEditarCategoria.TabIndex = 10;
            // 
            // btnEditarArtigo
            // 
            this.btnEditarArtigo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditarArtigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarArtigo.Location = new System.Drawing.Point(644, 453);
            this.btnEditarArtigo.Name = "btnEditarArtigo";
            this.btnEditarArtigo.Size = new System.Drawing.Size(129, 44);
            this.btnEditarArtigo.TabIndex = 11;
            this.btnEditarArtigo.Text = "Editar";
            this.btnEditarArtigo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarArtigo
            // 
            this.btnEliminarArtigo.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarArtigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArtigo.Location = new System.Drawing.Point(859, 453);
            this.btnEliminarArtigo.Name = "btnEliminarArtigo";
            this.btnEliminarArtigo.Size = new System.Drawing.Size(178, 46);
            this.btnEliminarArtigo.TabIndex = 12;
            this.btnEliminarArtigo.Text = "Eliminar";
            this.btnEliminarArtigo.UseVisualStyleBackColor = false;
            // 
            // lstArtigos
            // 
            this.lstArtigos.FormattingEnabled = true;
            this.lstArtigos.ItemHeight = 16;
            this.lstArtigos.Location = new System.Drawing.Point(35, 234);
            this.lstArtigos.Name = "lstArtigos";
            this.lstArtigos.Size = new System.Drawing.Size(503, 340);
            this.lstArtigos.TabIndex = 13;
            // 
            // FormArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1101, 586);
            this.Controls.Add(this.lstArtigos);
            this.Controls.Add(this.btnEliminarArtigo);
            this.Controls.Add(this.btnEditarArtigo);
            this.Controls.Add(this.cbEditarCategoria);
            this.Controls.Add(this.txtEditarNome);
            this.Controls.Add(this.btnAdicionarArtigo);
            this.Controls.Add(this.cbAdicionarCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdicionarNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVerTipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormArtigos";
            this.Text = "FormArtigos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtgestaoartigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVerTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdicionarNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAdicionarCategoria;
        private System.Windows.Forms.Button btnAdicionarArtigo;
        private System.Windows.Forms.TextBox txtEditarNome;
        private System.Windows.Forms.ComboBox cbEditarCategoria;
        private System.Windows.Forms.Button btnEditarArtigo;
        private System.Windows.Forms.Button btnEliminarArtigo;
        private System.Windows.Forms.PictureBox picbox_voltar;
        private System.Windows.Forms.ListBox lstArtigos;
    }
}