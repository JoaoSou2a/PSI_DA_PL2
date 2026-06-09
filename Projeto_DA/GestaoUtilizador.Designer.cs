namespace Projeto_DA
{
    partial class GestaoUtilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoUtilizador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxUtilizadores = new System.Windows.Forms.ListBox();
            this.btnRemoverUtilizador = new System.Windows.Forms.Button();
            this.picbox_voltar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.picbox_voltar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 86);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(487, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizadores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxUtilizadores
            // 
            this.listBoxUtilizadores.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUtilizadores.FormattingEnabled = true;
            this.listBoxUtilizadores.ItemHeight = 26;
            this.listBoxUtilizadores.Location = new System.Drawing.Point(195, 114);
            this.listBoxUtilizadores.Name = "listBoxUtilizadores";
            this.listBoxUtilizadores.Size = new System.Drawing.Size(750, 394);
            this.listBoxUtilizadores.TabIndex = 3;
            this.listBoxUtilizadores.SelectedIndexChanged += new System.EventHandler(this.listBoxUtilizadores_SelectedIndexChanged);
            // 
            // btnRemoverUtilizador
            // 
            this.btnRemoverUtilizador.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoverUtilizador.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverUtilizador.ForeColor = System.Drawing.Color.White;
            this.btnRemoverUtilizador.Location = new System.Drawing.Point(470, 524);
            this.btnRemoverUtilizador.Name = "btnRemoverUtilizador";
            this.btnRemoverUtilizador.Size = new System.Drawing.Size(150, 45);
            this.btnRemoverUtilizador.TabIndex = 4;
            this.btnRemoverUtilizador.Text = "Remover";
            this.btnRemoverUtilizador.UseVisualStyleBackColor = false;
            this.btnRemoverUtilizador.Click += new System.EventHandler(this.btnRemoverUtilizador_Click);
            // 
            // picbox_voltar
            // 
            this.picbox_voltar.Image = ((System.Drawing.Image)(resources.GetObject("picbox_voltar.Image")));
            this.picbox_voltar.Location = new System.Drawing.Point(35, 21);
            this.picbox_voltar.Name = "picbox_voltar";
            this.picbox_voltar.Size = new System.Drawing.Size(50, 39);
            this.picbox_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_voltar.TabIndex = 1;
            this.picbox_voltar.TabStop = false;
            this.picbox_voltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GestaoUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1154, 597);
            this.Controls.Add(this.btnRemoverUtilizador);
            this.Controls.Add(this.listBoxUtilizadores);
            this.Controls.Add(this.panel1);
            this.Name = "GestaoUtilizador";
            this.Text = "GestaoUtilizador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxUtilizadores;
        private System.Windows.Forms.Button btnRemoverUtilizador;
        private System.Windows.Forms.PictureBox picbox_voltar;
    }
}