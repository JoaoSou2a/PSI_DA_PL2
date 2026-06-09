namespace Projeto_DA
{
    partial class Estatisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estatisticas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSemanaAtualIdentificada = new System.Windows.Forms.Label();
            this.listBoxComprasPercentagens = new System.Windows.Forms.ListBox();
            this.listBoxHistoricoMensal = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbSemana4 = new System.Windows.Forms.RadioButton();
            this.rbSemana3 = new System.Windows.Forms.RadioButton();
            this.rbSemana2 = new System.Windows.Forms.RadioButton();
            this.rbSemana1 = new System.Windows.Forms.RadioButton();
            this.lblSemanaIdentificada = new System.Windows.Forms.Label();
            this.lblSugestaoOrcamento = new System.Windows.Forms.Label();
            this.btnGerarSugestoes = new System.Windows.Forms.Button();
            this.listBoxArtigosSugeridos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 86);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(487, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estatísticas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 493);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSemanaAtualIdentificada);
            this.tabPage1.Controls.Add(this.listBoxComprasPercentagens);
            this.tabPage1.Controls.Add(this.listBoxHistoricoMensal);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSemanaAtualIdentificada
            // 
            this.lblSemanaAtualIdentificada.AutoSize = true;
            this.lblSemanaAtualIdentificada.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemanaAtualIdentificada.Location = new System.Drawing.Point(355, 3);
            this.lblSemanaAtualIdentificada.Name = "lblSemanaAtualIdentificada";
            this.lblSemanaAtualIdentificada.Size = new System.Drawing.Size(136, 22);
            this.lblSemanaAtualIdentificada.TabIndex = 2;
            this.lblSemanaAtualIdentificada.Text = "Semana Atual: ";
            this.lblSemanaAtualIdentificada.Visible = false;
            // 
            // listBoxComprasPercentagens
            // 
            this.listBoxComprasPercentagens.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComprasPercentagens.FormattingEnabled = true;
            this.listBoxComprasPercentagens.ItemHeight = 17;
            this.listBoxComprasPercentagens.Location = new System.Drawing.Point(587, 28);
            this.listBoxComprasPercentagens.Name = "listBoxComprasPercentagens";
            this.listBoxComprasPercentagens.Size = new System.Drawing.Size(509, 395);
            this.listBoxComprasPercentagens.TabIndex = 1;
            // 
            // listBoxHistoricoMensal
            // 
            this.listBoxHistoricoMensal.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHistoricoMensal.FormattingEnabled = true;
            this.listBoxHistoricoMensal.ItemHeight = 17;
            this.listBoxHistoricoMensal.Location = new System.Drawing.Point(16, 28);
            this.listBoxHistoricoMensal.Name = "listBoxHistoricoMensal";
            this.listBoxHistoricoMensal.Size = new System.Drawing.Size(565, 395);
            this.listBoxHistoricoMensal.TabIndex = 0;
            this.listBoxHistoricoMensal.SelectedIndexChanged += new System.EventHandler(this.listBoxHistoricoMensal_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rbSemana4);
            this.tabPage2.Controls.Add(this.rbSemana3);
            this.tabPage2.Controls.Add(this.rbSemana2);
            this.tabPage2.Controls.Add(this.rbSemana1);
            this.tabPage2.Controls.Add(this.lblSemanaIdentificada);
            this.tabPage2.Controls.Add(this.lblSugestaoOrcamento);
            this.tabPage2.Controls.Add(this.btnGerarSugestoes);
            this.tabPage2.Controls.Add(this.listBoxArtigosSugeridos);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbSemana4
            // 
            this.rbSemana4.AutoSize = true;
            this.rbSemana4.Location = new System.Drawing.Point(792, 179);
            this.rbSemana4.Name = "rbSemana4";
            this.rbSemana4.Size = new System.Drawing.Size(93, 21);
            this.rbSemana4.TabIndex = 7;
            this.rbSemana4.TabStop = true;
            this.rbSemana4.Text = "Semana 4";
            this.rbSemana4.UseVisualStyleBackColor = true;
            // 
            // rbSemana3
            // 
            this.rbSemana3.AutoSize = true;
            this.rbSemana3.Location = new System.Drawing.Point(792, 145);
            this.rbSemana3.Name = "rbSemana3";
            this.rbSemana3.Size = new System.Drawing.Size(93, 21);
            this.rbSemana3.TabIndex = 6;
            this.rbSemana3.TabStop = true;
            this.rbSemana3.Text = "Semana 3";
            this.rbSemana3.UseVisualStyleBackColor = true;
            // 
            // rbSemana2
            // 
            this.rbSemana2.AutoSize = true;
            this.rbSemana2.Location = new System.Drawing.Point(792, 105);
            this.rbSemana2.Name = "rbSemana2";
            this.rbSemana2.Size = new System.Drawing.Size(93, 21);
            this.rbSemana2.TabIndex = 5;
            this.rbSemana2.TabStop = true;
            this.rbSemana2.Text = "Semana 2";
            this.rbSemana2.UseVisualStyleBackColor = true;
            // 
            // rbSemana1
            // 
            this.rbSemana1.AutoSize = true;
            this.rbSemana1.Location = new System.Drawing.Point(792, 69);
            this.rbSemana1.Name = "rbSemana1";
            this.rbSemana1.Size = new System.Drawing.Size(93, 21);
            this.rbSemana1.TabIndex = 4;
            this.rbSemana1.TabStop = true;
            this.rbSemana1.Text = "Semana 1";
            this.rbSemana1.UseVisualStyleBackColor = true;
            // 
            // lblSemanaIdentificada
            // 
            this.lblSemanaIdentificada.AutoSize = true;
            this.lblSemanaIdentificada.Location = new System.Drawing.Point(17, 6);
            this.lblSemanaIdentificada.Name = "lblSemanaIdentificada";
            this.lblSemanaIdentificada.Size = new System.Drawing.Size(69, 17);
            this.lblSemanaIdentificada.TabIndex = 3;
            this.lblSemanaIdentificada.Text = "Semana: ";
            // 
            // lblSugestaoOrcamento
            // 
            this.lblSugestaoOrcamento.AutoSize = true;
            this.lblSugestaoOrcamento.Location = new System.Drawing.Point(513, 6);
            this.lblSugestaoOrcamento.Name = "lblSugestaoOrcamento";
            this.lblSugestaoOrcamento.Size = new System.Drawing.Size(77, 17);
            this.lblSugestaoOrcamento.TabIndex = 2;
            this.lblSugestaoOrcamento.Text = "Sugestão: ";
            // 
            // btnGerarSugestoes
            // 
            this.btnGerarSugestoes.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGerarSugestoes.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSugestoes.Location = new System.Drawing.Point(792, 224);
            this.btnGerarSugestoes.Name = "btnGerarSugestoes";
            this.btnGerarSugestoes.Size = new System.Drawing.Size(100, 34);
            this.btnGerarSugestoes.TabIndex = 1;
            this.btnGerarSugestoes.Text = "Gerar Sugestoes";
            this.btnGerarSugestoes.UseVisualStyleBackColor = false;
            this.btnGerarSugestoes.Click += new System.EventHandler(this.btnGerarSugestoes_Click);
            // 
            // listBoxArtigosSugeridos
            // 
            this.listBoxArtigosSugeridos.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArtigosSugeridos.FormattingEnabled = true;
            this.listBoxArtigosSugeridos.ItemHeight = 17;
            this.listBoxArtigosSugeridos.Location = new System.Drawing.Point(6, 34);
            this.listBoxArtigosSugeridos.Name = "listBoxArtigosSugeridos";
            this.listBoxArtigosSugeridos.Size = new System.Drawing.Size(717, 395);
            this.listBoxArtigosSugeridos.TabIndex = 0;
            this.listBoxArtigosSugeridos.SelectedIndexChanged += new System.EventHandler(this.listBoxArtigosSugeridos_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Estatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1154, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Estatisticas";
            this.Text = "Estatisticas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxHistoricoMensal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSemanaAtualIdentificada;
        private System.Windows.Forms.ListBox listBoxComprasPercentagens;
        private System.Windows.Forms.Label lblSugestaoOrcamento;
        private System.Windows.Forms.Button btnGerarSugestoes;
        private System.Windows.Forms.RadioButton rbSemana4;
        private System.Windows.Forms.RadioButton rbSemana3;
        private System.Windows.Forms.RadioButton rbSemana2;
        private System.Windows.Forms.RadioButton rbSemana1;
        private System.Windows.Forms.Label lblSemanaIdentificada;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListBox listBoxArtigosSugeridos;
    }
}