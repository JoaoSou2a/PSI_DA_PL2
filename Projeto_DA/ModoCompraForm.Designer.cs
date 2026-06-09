namespace Projeto_DA
{
    partial class ModoCompraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModoCompraForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.picbox_voltar = new System.Windows.Forms.PictureBox();
            this.lb_ModoCompra = new System.Windows.Forms.Label();
            this.groupBox_Orcamento = new System.Windows.Forms.GroupBox();
            this.lb_dinheirodisponivel = new System.Windows.Forms.Label();
            this.lb_TotalGasto = new System.Windows.Forms.Label();
            this.lb_orcamento = new System.Windows.Forms.Label();
            this.groupBox_ItensPrevistos = new System.Windows.Forms.GroupBox();
            this.txt_PrecoUni = new System.Windows.Forms.TextBox();
            this.txt_QntdAdquirida = new System.Windows.Forms.TextBox();
            this.lb_PrecoUni = new System.Windows.Forms.Label();
            this.lb_qntdAdquirida = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.ltb_Itensprevistos = new System.Windows.Forms.ListBox();
            this.groupBox_ItensNPrevistos = new System.Windows.Forms.GroupBox();
            this.txt_PrecoUnita = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.cb_Artigo = new System.Windows.Forms.ComboBox();
            this.cb_TipoArtigo = new System.Windows.Forms.ComboBox();
            this.txt_Observacoes = new System.Windows.Forms.TextBox();
            this.lb_Observacoes = new System.Windows.Forms.Label();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.lb_PrecoUnit = new System.Windows.Forms.Label();
            this.lb_Artigo = new System.Windows.Forms.Label();
            this.lb_TipoArtigo = new System.Windows.Forms.Label();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.ltb_ItensNPrevistos = new System.Windows.Forms.ListBox();
            this.btn_FecharCompra = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).BeginInit();
            this.groupBox_Orcamento.SuspendLayout();
            this.groupBox_ItensPrevistos.SuspendLayout();
            this.groupBox_ItensNPrevistos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.picbox_voltar);
            this.panel2.Controls.Add(this.lb_ModoCompra);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 86);
            this.panel2.TabIndex = 9;
            // 
            // picbox_voltar
            // 
            this.picbox_voltar.Image = ((System.Drawing.Image)(resources.GetObject("picbox_voltar.Image")));
            this.picbox_voltar.Location = new System.Drawing.Point(48, 24);
            this.picbox_voltar.Name = "picbox_voltar";
            this.picbox_voltar.Size = new System.Drawing.Size(50, 39);
            this.picbox_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_voltar.TabIndex = 8;
            this.picbox_voltar.TabStop = false;
            this.picbox_voltar.Click += new System.EventHandler(this.picbox_voltar_Click);
            // 
            // lb_ModoCompra
            // 
            this.lb_ModoCompra.AutoSize = true;
            this.lb_ModoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ModoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ModoCompra.Location = new System.Drawing.Point(422, 24);
            this.lb_ModoCompra.Name = "lb_ModoCompra";
            this.lb_ModoCompra.Size = new System.Drawing.Size(221, 32);
            this.lb_ModoCompra.TabIndex = 7;
            this.lb_ModoCompra.Text = "Modo Compra -";
            // 
            // groupBox_Orcamento
            // 
            this.groupBox_Orcamento.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox_Orcamento.Controls.Add(this.lb_dinheirodisponivel);
            this.groupBox_Orcamento.Controls.Add(this.lb_TotalGasto);
            this.groupBox_Orcamento.Controls.Add(this.lb_orcamento);
            this.groupBox_Orcamento.Location = new System.Drawing.Point(12, 103);
            this.groupBox_Orcamento.Name = "groupBox_Orcamento";
            this.groupBox_Orcamento.Size = new System.Drawing.Size(1130, 85);
            this.groupBox_Orcamento.TabIndex = 10;
            this.groupBox_Orcamento.TabStop = false;
            this.groupBox_Orcamento.Text = "Orçamento";
            // 
            // lb_dinheirodisponivel
            // 
            this.lb_dinheirodisponivel.AutoSize = true;
            this.lb_dinheirodisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dinheirodisponivel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_dinheirodisponivel.Location = new System.Drawing.Point(878, 40);
            this.lb_dinheirodisponivel.Name = "lb_dinheirodisponivel";
            this.lb_dinheirodisponivel.Size = new System.Drawing.Size(92, 20);
            this.lb_dinheirodisponivel.TabIndex = 2;
            this.lb_dinheirodisponivel.Text = "Disponível:";
            // 
            // lb_TotalGasto
            // 
            this.lb_TotalGasto.AutoSize = true;
            this.lb_TotalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalGasto.Location = new System.Drawing.Point(483, 40);
            this.lb_TotalGasto.Name = "lb_TotalGasto";
            this.lb_TotalGasto.Size = new System.Drawing.Size(101, 20);
            this.lb_TotalGasto.TabIndex = 1;
            this.lb_TotalGasto.Text = "Total Gasto:";
            // 
            // lb_orcamento
            // 
            this.lb_orcamento.AutoSize = true;
            this.lb_orcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orcamento.Location = new System.Drawing.Point(32, 40);
            this.lb_orcamento.Name = "lb_orcamento";
            this.lb_orcamento.Size = new System.Drawing.Size(157, 20);
            this.lb_orcamento.TabIndex = 0;
            this.lb_orcamento.Text = "Orçamento do mês:";
            // 
            // groupBox_ItensPrevistos
            // 
            this.groupBox_ItensPrevistos.Controls.Add(this.txt_PrecoUni);
            this.groupBox_ItensPrevistos.Controls.Add(this.txt_QntdAdquirida);
            this.groupBox_ItensPrevistos.Controls.Add(this.lb_PrecoUni);
            this.groupBox_ItensPrevistos.Controls.Add(this.lb_qntdAdquirida);
            this.groupBox_ItensPrevistos.Controls.Add(this.btn_Guardar);
            this.groupBox_ItensPrevistos.Controls.Add(this.ltb_Itensprevistos);
            this.groupBox_ItensPrevistos.Location = new System.Drawing.Point(12, 205);
            this.groupBox_ItensPrevistos.Name = "groupBox_ItensPrevistos";
            this.groupBox_ItensPrevistos.Size = new System.Drawing.Size(552, 529);
            this.groupBox_ItensPrevistos.TabIndex = 11;
            this.groupBox_ItensPrevistos.TabStop = false;
            this.groupBox_ItensPrevistos.Text = "Itens Previstos";
            // 
            // txt_PrecoUni
            // 
            this.txt_PrecoUni.Location = new System.Drawing.Point(193, 428);
            this.txt_PrecoUni.Name = "txt_PrecoUni";
            this.txt_PrecoUni.Size = new System.Drawing.Size(100, 22);
            this.txt_PrecoUni.TabIndex = 18;
            // 
            // txt_QntdAdquirida
            // 
            this.txt_QntdAdquirida.Location = new System.Drawing.Point(211, 359);
            this.txt_QntdAdquirida.Name = "txt_QntdAdquirida";
            this.txt_QntdAdquirida.Size = new System.Drawing.Size(114, 22);
            this.txt_QntdAdquirida.TabIndex = 17;
            // 
            // lb_PrecoUni
            // 
            this.lb_PrecoUni.AutoSize = true;
            this.lb_PrecoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrecoUni.Location = new System.Drawing.Point(51, 424);
            this.lb_PrecoUni.Name = "lb_PrecoUni";
            this.lb_PrecoUni.Size = new System.Drawing.Size(116, 20);
            this.lb_PrecoUni.TabIndex = 16;
            this.lb_PrecoUni.Text = "Preço Unitário";
            // 
            // lb_qntdAdquirida
            // 
            this.lb_qntdAdquirida.AutoSize = true;
            this.lb_qntdAdquirida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qntdAdquirida.Location = new System.Drawing.Point(34, 359);
            this.lb_qntdAdquirida.Name = "lb_qntdAdquirida";
            this.lb_qntdAdquirida.Size = new System.Drawing.Size(169, 20);
            this.lb_qntdAdquirida.TabIndex = 15;
            this.lb_qntdAdquirida.Text = "Quantidade Adquirida";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(379, 458);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(153, 41);
            this.btn_Guardar.TabIndex = 14;
            this.btn_Guardar.Text = "Guardar Item";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // ltb_Itensprevistos
            // 
            this.ltb_Itensprevistos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_Itensprevistos.FormattingEnabled = true;
            this.ltb_Itensprevistos.ItemHeight = 18;
            this.ltb_Itensprevistos.Location = new System.Drawing.Point(10, 25);
            this.ltb_Itensprevistos.Name = "ltb_Itensprevistos";
            this.ltb_Itensprevistos.Size = new System.Drawing.Size(522, 292);
            this.ltb_Itensprevistos.TabIndex = 0;
            // 
            // groupBox_ItensNPrevistos
            // 
            this.groupBox_ItensNPrevistos.Controls.Add(this.txt_PrecoUnita);
            this.groupBox_ItensNPrevistos.Controls.Add(this.txt_Quantidade);
            this.groupBox_ItensNPrevistos.Controls.Add(this.cb_Artigo);
            this.groupBox_ItensNPrevistos.Controls.Add(this.cb_TipoArtigo);
            this.groupBox_ItensNPrevistos.Controls.Add(this.txt_Observacoes);
            this.groupBox_ItensNPrevistos.Controls.Add(this.lb_Observacoes);
            this.groupBox_ItensNPrevistos.Controls.Add(this.lb_quantidade);
            this.groupBox_ItensNPrevistos.Controls.Add(this.lb_PrecoUnit);
            this.groupBox_ItensNPrevistos.Controls.Add(this.lb_Artigo);
            this.groupBox_ItensNPrevistos.Controls.Add(this.lb_TipoArtigo);
            this.groupBox_ItensNPrevistos.Controls.Add(this.btn_Remover);
            this.groupBox_ItensNPrevistos.Controls.Add(this.btn_Adicionar);
            this.groupBox_ItensNPrevistos.Controls.Add(this.ltb_ItensNPrevistos);
            this.groupBox_ItensNPrevistos.Location = new System.Drawing.Point(570, 205);
            this.groupBox_ItensNPrevistos.Name = "groupBox_ItensNPrevistos";
            this.groupBox_ItensNPrevistos.Size = new System.Drawing.Size(572, 529);
            this.groupBox_ItensNPrevistos.TabIndex = 12;
            this.groupBox_ItensNPrevistos.TabStop = false;
            this.groupBox_ItensNPrevistos.Text = "Itens Não Previstos";
            // 
            // txt_PrecoUnita
            // 
            this.txt_PrecoUnita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecoUnita.Location = new System.Drawing.Point(430, 148);
            this.txt_PrecoUnita.Name = "txt_PrecoUnita";
            this.txt_PrecoUnita.Size = new System.Drawing.Size(122, 27);
            this.txt_PrecoUnita.TabIndex = 27;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(155, 148);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(121, 27);
            this.txt_Quantidade.TabIndex = 26;
            // 
            // cb_Artigo
            // 
            this.cb_Artigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Artigo.FormattingEnabled = true;
            this.cb_Artigo.ItemHeight = 20;
            this.cb_Artigo.Location = new System.Drawing.Point(155, 97);
            this.cb_Artigo.MaxDropDownItems = 12;
            this.cb_Artigo.Name = "cb_Artigo";
            this.cb_Artigo.Size = new System.Drawing.Size(225, 28);
            this.cb_Artigo.TabIndex = 25;
            // 
            // cb_TipoArtigo
            // 
            this.cb_TipoArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoArtigo.FormattingEnabled = true;
            this.cb_TipoArtigo.ItemHeight = 20;
            this.cb_TipoArtigo.Location = new System.Drawing.Point(155, 41);
            this.cb_TipoArtigo.MaxDropDownItems = 12;
            this.cb_TipoArtigo.Name = "cb_TipoArtigo";
            this.cb_TipoArtigo.Size = new System.Drawing.Size(225, 28);
            this.cb_TipoArtigo.TabIndex = 24;
            this.cb_TipoArtigo.SelectedIndexChanged += new System.EventHandler(this.cb_TipoArtigo_SelectedIndexChanged);
            // 
            // txt_Observacoes
            // 
            this.txt_Observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Observacoes.Location = new System.Drawing.Point(142, 192);
            this.txt_Observacoes.Multiline = true;
            this.txt_Observacoes.Name = "txt_Observacoes";
            this.txt_Observacoes.Size = new System.Drawing.Size(410, 91);
            this.txt_Observacoes.TabIndex = 19;
            // 
            // lb_Observacoes
            // 
            this.lb_Observacoes.AutoSize = true;
            this.lb_Observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Observacoes.Location = new System.Drawing.Point(23, 195);
            this.lb_Observacoes.Name = "lb_Observacoes";
            this.lb_Observacoes.Size = new System.Drawing.Size(113, 20);
            this.lb_Observacoes.TabIndex = 23;
            this.lb_Observacoes.Text = "Observações:";
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantidade.Location = new System.Drawing.Point(26, 148);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(99, 20);
            this.lb_quantidade.TabIndex = 22;
            this.lb_quantidade.Text = "Quantidade:";
            // 
            // lb_PrecoUnit
            // 
            this.lb_PrecoUnit.AutoSize = true;
            this.lb_PrecoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrecoUnit.Location = new System.Drawing.Point(303, 151);
            this.lb_PrecoUnit.Name = "lb_PrecoUnit";
            this.lb_PrecoUnit.Size = new System.Drawing.Size(121, 20);
            this.lb_PrecoUnit.TabIndex = 21;
            this.lb_PrecoUnit.Text = "Preço Unitário:";
            // 
            // lb_Artigo
            // 
            this.lb_Artigo.AutoSize = true;
            this.lb_Artigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Artigo.Location = new System.Drawing.Point(26, 97);
            this.lb_Artigo.Name = "lb_Artigo";
            this.lb_Artigo.Size = new System.Drawing.Size(58, 20);
            this.lb_Artigo.TabIndex = 20;
            this.lb_Artigo.Text = "Artigo:";
            // 
            // lb_TipoArtigo
            // 
            this.lb_TipoArtigo.AutoSize = true;
            this.lb_TipoArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TipoArtigo.Location = new System.Drawing.Point(26, 44);
            this.lb_TipoArtigo.Name = "lb_TipoArtigo";
            this.lb_TipoArtigo.Size = new System.Drawing.Size(113, 20);
            this.lb_TipoArtigo.TabIndex = 19;
            this.lb_TipoArtigo.Text = "Tipo de Artigo";
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.Tomato;
            this.btn_Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.Location = new System.Drawing.Point(433, 302);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(119, 34);
            this.btn_Remover.TabIndex = 16;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Location = new System.Drawing.Point(307, 302);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(117, 34);
            this.btn_Adicionar.TabIndex = 15;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // ltb_ItensNPrevistos
            // 
            this.ltb_ItensNPrevistos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_ItensNPrevistos.FormattingEnabled = true;
            this.ltb_ItensNPrevistos.ItemHeight = 18;
            this.ltb_ItensNPrevistos.Location = new System.Drawing.Point(6, 348);
            this.ltb_ItensNPrevistos.Name = "ltb_ItensNPrevistos";
            this.ltb_ItensNPrevistos.Size = new System.Drawing.Size(546, 148);
            this.ltb_ItensNPrevistos.TabIndex = 1;
            // 
            // btn_FecharCompra
            // 
            this.btn_FecharCompra.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_FecharCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FecharCompra.Location = new System.Drawing.Point(459, 754);
            this.btn_FecharCompra.Name = "btn_FecharCompra";
            this.btn_FecharCompra.Size = new System.Drawing.Size(195, 39);
            this.btn_FecharCompra.TabIndex = 13;
            this.btn_FecharCompra.Text = "Fechar Compra";
            this.btn_FecharCompra.UseVisualStyleBackColor = false;
            this.btn_FecharCompra.Click += new System.EventHandler(this.btn_FecharCompra_Click);
            // 
            // ModoCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1154, 805);
            this.Controls.Add(this.btn_FecharCompra);
            this.Controls.Add(this.groupBox_ItensNPrevistos);
            this.Controls.Add(this.groupBox_ItensPrevistos);
            this.Controls.Add(this.groupBox_Orcamento);
            this.Controls.Add(this.panel2);
            this.Name = "ModoCompraForm";
            this.Text = "ModoCompraForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).EndInit();
            this.groupBox_Orcamento.ResumeLayout(false);
            this.groupBox_Orcamento.PerformLayout();
            this.groupBox_ItensPrevistos.ResumeLayout(false);
            this.groupBox_ItensPrevistos.PerformLayout();
            this.groupBox_ItensNPrevistos.ResumeLayout(false);
            this.groupBox_ItensNPrevistos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picbox_voltar;
        private System.Windows.Forms.Label lb_ModoCompra;
        private System.Windows.Forms.GroupBox groupBox_Orcamento;
        private System.Windows.Forms.Label lb_dinheirodisponivel;
        private System.Windows.Forms.Label lb_TotalGasto;
        private System.Windows.Forms.Label lb_orcamento;
        private System.Windows.Forms.GroupBox groupBox_ItensPrevistos;
        private System.Windows.Forms.GroupBox groupBox_ItensNPrevistos;
        private System.Windows.Forms.ListBox ltb_Itensprevistos;
        private System.Windows.Forms.ListBox ltb_ItensNPrevistos;
        private System.Windows.Forms.TextBox txt_PrecoUni;
        private System.Windows.Forms.TextBox txt_QntdAdquirida;
        private System.Windows.Forms.Label lb_PrecoUni;
        private System.Windows.Forms.Label lb_qntdAdquirida;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lb_Observacoes;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.Label lb_PrecoUnit;
        private System.Windows.Forms.Label lb_Artigo;
        private System.Windows.Forms.Label lb_TipoArtigo;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_FecharCompra;
        private System.Windows.Forms.TextBox txt_Observacoes;
        private System.Windows.Forms.ComboBox cb_TipoArtigo;
        private System.Windows.Forms.ComboBox cb_Artigo;
        private System.Windows.Forms.TextBox txt_PrecoUnita;
        private System.Windows.Forms.TextBox txt_Quantidade;
    }
}