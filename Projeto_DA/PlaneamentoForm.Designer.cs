namespace Projeto_DA
{
    partial class PlaneamentoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaneamentoForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.picbox_voltar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_criadopor = new System.Windows.Forms.Label();
            this.btn_CriarAlterarCompra = new System.Windows.Forms.Button();
            this.btn_ExportarCSV = new System.Windows.Forms.Button();
            this.comboBox_Criadopor = new System.Windows.Forms.ComboBox();
            this.comboBox_Estado = new System.Windows.Forms.ComboBox();
            this.ltbox_Compras = new System.Windows.Forms.ListBox();
            this.lb_TotalCompras = new System.Windows.Forms.Label();
            this.lb_Abertas = new System.Windows.Forms.Label();
            this.lb_Fechadas = new System.Windows.Forms.Label();
            this.groupBox_filtro = new System.Windows.Forms.GroupBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).BeginInit();
            this.groupBox_filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.picbox_voltar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 86);
            this.panel2.TabIndex = 8;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(298, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Planeamento de Compras";
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(11, 20);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(71, 22);
            this.lb_estado.TabIndex = 9;
            this.lb_estado.Text = "Estado:";
            // 
            // lb_criadopor
            // 
            this.lb_criadopor.AutoSize = true;
            this.lb_criadopor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_criadopor.Location = new System.Drawing.Point(8, 61);
            this.lb_criadopor.Name = "lb_criadopor";
            this.lb_criadopor.Size = new System.Drawing.Size(99, 22);
            this.lb_criadopor.TabIndex = 10;
            this.lb_criadopor.Text = "Criado por:";
            // 
            // btn_CriarAlterarCompra
            // 
            this.btn_CriarAlterarCompra.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_CriarAlterarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarAlterarCompra.Location = new System.Drawing.Point(696, 100);
            this.btn_CriarAlterarCompra.Name = "btn_CriarAlterarCompra";
            this.btn_CriarAlterarCompra.Size = new System.Drawing.Size(267, 46);
            this.btn_CriarAlterarCompra.TabIndex = 11;
            this.btn_CriarAlterarCompra.Text = "Criar/Alterar Compra";
            this.btn_CriarAlterarCompra.UseVisualStyleBackColor = false;
            this.btn_CriarAlterarCompra.Click += new System.EventHandler(this.btn_CriarAlterarCompra_Click);
            // 
            // btn_ExportarCSV
            // 
            this.btn_ExportarCSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ExportarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportarCSV.Location = new System.Drawing.Point(745, 153);
            this.btn_ExportarCSV.Name = "btn_ExportarCSV";
            this.btn_ExportarCSV.Size = new System.Drawing.Size(170, 46);
            this.btn_ExportarCSV.TabIndex = 12;
            this.btn_ExportarCSV.Text = "Exportar CSV";
            this.btn_ExportarCSV.UseVisualStyleBackColor = false;
            this.btn_ExportarCSV.Click += new System.EventHandler(this.btn_ExportarCSV_Click);
            // 
            // comboBox_Criadopor
            // 
            this.comboBox_Criadopor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Criadopor.FormattingEnabled = true;
            this.comboBox_Criadopor.Location = new System.Drawing.Point(135, 60);
            this.comboBox_Criadopor.Name = "comboBox_Criadopor";
            this.comboBox_Criadopor.Size = new System.Drawing.Size(174, 28);
            this.comboBox_Criadopor.TabIndex = 14;
            // 
            // comboBox_Estado
            // 
            this.comboBox_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Estado.FormattingEnabled = true;
            this.comboBox_Estado.Location = new System.Drawing.Point(110, 18);
            this.comboBox_Estado.Name = "comboBox_Estado";
            this.comboBox_Estado.Size = new System.Drawing.Size(199, 28);
            this.comboBox_Estado.TabIndex = 15;
            // 
            // ltbox_Compras
            // 
            this.ltbox_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbox_Compras.FormattingEnabled = true;
            this.ltbox_Compras.ItemHeight = 22;
            this.ltbox_Compras.Location = new System.Drawing.Point(12, 268);
            this.ltbox_Compras.Name = "ltbox_Compras";
            this.ltbox_Compras.Size = new System.Drawing.Size(977, 290);
            this.ltbox_Compras.TabIndex = 16;
            // 
            // lb_TotalCompras
            // 
            this.lb_TotalCompras.AutoSize = true;
            this.lb_TotalCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalCompras.Location = new System.Drawing.Point(30, 220);
            this.lb_TotalCompras.Name = "lb_TotalCompras";
            this.lb_TotalCompras.Size = new System.Drawing.Size(158, 22);
            this.lb_TotalCompras.TabIndex = 20;
            this.lb_TotalCompras.Text = "Total de Compras:";
            // 
            // lb_Abertas
            // 
            this.lb_Abertas.AutoSize = true;
            this.lb_Abertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Abertas.Location = new System.Drawing.Point(266, 220);
            this.lb_Abertas.Name = "lb_Abertas";
            this.lb_Abertas.Size = new System.Drawing.Size(77, 22);
            this.lb_Abertas.TabIndex = 21;
            this.lb_Abertas.Text = "Abertas:";
            // 
            // lb_Fechadas
            // 
            this.lb_Fechadas.AutoSize = true;
            this.lb_Fechadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fechadas.Location = new System.Drawing.Point(437, 220);
            this.lb_Fechadas.Name = "lb_Fechadas";
            this.lb_Fechadas.Size = new System.Drawing.Size(94, 22);
            this.lb_Fechadas.TabIndex = 22;
            this.lb_Fechadas.Text = "Fechadas:";
            // 
            // groupBox_filtro
            // 
            this.groupBox_filtro.Controls.Add(this.btn_filtrar);
            this.groupBox_filtro.Controls.Add(this.lb_estado);
            this.groupBox_filtro.Controls.Add(this.lb_criadopor);
            this.groupBox_filtro.Controls.Add(this.comboBox_Criadopor);
            this.groupBox_filtro.Controls.Add(this.comboBox_Estado);
            this.groupBox_filtro.Location = new System.Drawing.Point(34, 92);
            this.groupBox_filtro.Name = "groupBox_filtro";
            this.groupBox_filtro.Size = new System.Drawing.Size(518, 100);
            this.groupBox_filtro.TabIndex = 23;
            this.groupBox_filtro.TabStop = false;
            this.groupBox_filtro.Text = "Filtrar por:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.Location = new System.Drawing.Point(381, 37);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(116, 33);
            this.btn_filtrar.TabIndex = 16;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.Tomato;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(766, 211);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(133, 42);
            this.btn_remover.TabIndex = 24;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // PlaneamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1001, 588);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.groupBox_filtro);
            this.Controls.Add(this.lb_Fechadas);
            this.Controls.Add(this.lb_Abertas);
            this.Controls.Add(this.lb_TotalCompras);
            this.Controls.Add(this.ltbox_Compras);
            this.Controls.Add(this.btn_ExportarCSV);
            this.Controls.Add(this.btn_CriarAlterarCompra);
            this.Controls.Add(this.panel2);
            this.Name = "PlaneamentoForm";
            this.Text = "PlaneamentoForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).EndInit();
            this.groupBox_filtro.ResumeLayout(false);
            this.groupBox_filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picbox_voltar;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_criadopor;
        private System.Windows.Forms.Button btn_CriarAlterarCompra;
        private System.Windows.Forms.Button btn_ExportarCSV;
        private System.Windows.Forms.ComboBox comboBox_Criadopor;
        private System.Windows.Forms.ComboBox comboBox_Estado;
        private System.Windows.Forms.ListBox ltbox_Compras;
        private System.Windows.Forms.Label lb_TotalCompras;
        private System.Windows.Forms.Label lb_Abertas;
        private System.Windows.Forms.Label lb_Fechadas;
        private System.Windows.Forms.GroupBox groupBox_filtro;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_remover;
    }
}
