namespace Projeto_DA
{
    partial class FormTipoArtigos
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
            System.Windows.Forms.Button btnAdicionarTipo;
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarTipo = new System.Windows.Forms.Button();
            this.btnEditarTipo = new System.Windows.Forms.Button();
            this.txtEditarTipo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnArt = new System.Windows.Forms.Button();
            this.lstTipos = new System.Windows.Forms.ListBox();
            btnAdicionarTipo = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(368, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestão do Tipo de Artigos";
            // 
            // btnAdicionarTipo
            // 
            btnAdicionarTipo.BackColor = System.Drawing.Color.SpringGreen;
            btnAdicionarTipo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAdicionarTipo.Location = new System.Drawing.Point(222, 220);
            btnAdicionarTipo.Name = "btnAdicionarTipo";
            btnAdicionarTipo.Size = new System.Drawing.Size(150, 36);
            btnAdicionarTipo.TabIndex = 3;
            btnAdicionarTipo.Text = "Adicionar";
            btnAdicionarTipo.UseVisualStyleBackColor = false;
            btnAdicionarTipo.Click += new System.EventHandler(this.btnAdicionarTipo_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(207, 174);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(176, 40);
            this.txtCategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adicionar Novo Tipo:";
            // 
            // btnEliminarTipo
            // 
            this.btnEliminarTipo.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarTipo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTipo.Location = new System.Drawing.Point(222, 440);
            this.btnEliminarTipo.Name = "btnEliminarTipo";
            this.btnEliminarTipo.Size = new System.Drawing.Size(150, 40);
            this.btnEliminarTipo.TabIndex = 6;
            this.btnEliminarTipo.Text = "Eliminar";
            this.btnEliminarTipo.UseVisualStyleBackColor = false;
            this.btnEliminarTipo.Click += new System.EventHandler(this.btnEliminarTipo_Click);
            // 
            // btnEditarTipo
            // 
            this.btnEditarTipo.BackColor = System.Drawing.Color.Khaki;
            this.btnEditarTipo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTipo.Location = new System.Drawing.Point(222, 364);
            this.btnEditarTipo.Name = "btnEditarTipo";
            this.btnEditarTipo.Size = new System.Drawing.Size(150, 44);
            this.btnEditarTipo.TabIndex = 7;
            this.btnEditarTipo.Text = "Editar";
            this.btnEditarTipo.UseVisualStyleBackColor = false;
            this.btnEditarTipo.Click += new System.EventHandler(this.btnEditarTipo_Click);
            // 
            // txtEditarTipo
            // 
            this.txtEditarTipo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarTipo.Location = new System.Drawing.Point(207, 318);
            this.txtEditarTipo.Name = "txtEditarTipo";
            this.txtEditarTipo.Size = new System.Drawing.Size(176, 40);
            this.txtEditarTipo.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.picbox_voltar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 100);
            this.panel2.TabIndex = 10;
            // 
            // btnArt
            // 
            this.btnArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArt.Location = new System.Drawing.Point(87, 129);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(281, 44);
            this.btnArt.TabIndex = 2;
            this.btnArt.Text = "Gestão de Artigos";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.btnArt_Click);
            // 
            // lstTipos
            // 
            this.lstTipos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipos.FormattingEnabled = true;
            this.lstTipos.ItemHeight = 26;
            this.lstTipos.Location = new System.Drawing.Point(487, 157);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(486, 316);
            this.lstTipos.TabIndex = 11;
            this.lstTipos.SelectedIndexChanged += new System.EventHandler(this.lstTipos_SelectedIndexChanged);
            // 
            // FormTipoArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1154, 597);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtEditarTipo);
            this.Controls.Add(this.btnEditarTipo);
            this.Controls.Add(this.btnEliminarTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(btnAdicionarTipo);
            this.Name = "FormTipoArtigos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarTipo;
        private System.Windows.Forms.Button btnEditarTipo;
        private System.Windows.Forms.TextBox txtEditarTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.PictureBox picbox_voltar;
    }
}