namespace Projeto_DA
{
    partial class OrcamentoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrcamentoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox_voltar = new System.Windows.Forms.PictureBox();
            this.btnCriarOrcamento = new System.Windows.Forms.Button();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.numericAno = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxOrcamentos = new System.Windows.Forms.ListBox();
            this.numericValorMaximo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericValorEditar = new System.Windows.Forms.NumericUpDown();
            this.numericMesEditar = new System.Windows.Forms.NumericUpDown();
            this.numericAnoEditar = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMesEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnoEditar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(470, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.picbox_voltar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 86);
            this.panel1.TabIndex = 1;
            // 
            // picbox_voltar
            // 
            this.picbox_voltar.Image = ((System.Drawing.Image)(resources.GetObject("picbox_voltar.Image")));
            this.picbox_voltar.Location = new System.Drawing.Point(50, 27);
            this.picbox_voltar.Name = "picbox_voltar";
            this.picbox_voltar.Size = new System.Drawing.Size(50, 39);
            this.picbox_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_voltar.TabIndex = 3;
            this.picbox_voltar.TabStop = false;
            this.picbox_voltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCriarOrcamento
            // 
            this.btnCriarOrcamento.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCriarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarOrcamento.Location = new System.Drawing.Point(537, 115);
            this.btnCriarOrcamento.Name = "btnCriarOrcamento";
            this.btnCriarOrcamento.Size = new System.Drawing.Size(113, 31);
            this.btnCriarOrcamento.TabIndex = 3;
            this.btnCriarOrcamento.Text = "Criar";
            this.btnCriarOrcamento.UseVisualStyleBackColor = false;
            this.btnCriarOrcamento.Click += new System.EventHandler(this.btnCriarOrcamento_Click);
            // 
            // numericMes
            // 
            this.numericMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMes.Location = new System.Drawing.Point(296, 115);
            this.numericMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(80, 28);
            this.numericMes.TabIndex = 8;
            this.numericMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericAno
            // 
            this.numericAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAno.Location = new System.Drawing.Point(440, 115);
            this.numericAno.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericAno.Minimum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numericAno.Name = "numericAno";
            this.numericAno.Size = new System.Drawing.Size(82, 28);
            this.numericAno.TabIndex = 9;
            this.numericAno.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mês";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ano";
            // 
            // listBoxOrcamentos
            // 
            this.listBoxOrcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrcamentos.FormattingEnabled = true;
            this.listBoxOrcamentos.ItemHeight = 25;
            this.listBoxOrcamentos.Location = new System.Drawing.Point(51, 175);
            this.listBoxOrcamentos.Name = "listBoxOrcamentos";
            this.listBoxOrcamentos.Size = new System.Drawing.Size(570, 379);
            this.listBoxOrcamentos.TabIndex = 14;
            this.listBoxOrcamentos.SelectedIndexChanged += new System.EventHandler(this.listBoxOrcamentos_SelectedIndexChanged);
            // 
            // numericValorMaximo
            // 
            this.numericValorMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericValorMaximo.Location = new System.Drawing.Point(121, 118);
            this.numericValorMaximo.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericValorMaximo.Name = "numericValorMaximo";
            this.numericValorMaximo.Size = new System.Drawing.Size(99, 28);
            this.numericValorMaximo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mês";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ano";
            // 
            // numericValorEditar
            // 
            this.numericValorEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericValorEditar.Location = new System.Drawing.Point(91, 71);
            this.numericValorEditar.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericValorEditar.Name = "numericValorEditar";
            this.numericValorEditar.Size = new System.Drawing.Size(207, 28);
            this.numericValorEditar.TabIndex = 22;
            // 
            // numericMesEditar
            // 
            this.numericMesEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMesEditar.Location = new System.Drawing.Point(90, 140);
            this.numericMesEditar.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMesEditar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMesEditar.Name = "numericMesEditar";
            this.numericMesEditar.Size = new System.Drawing.Size(179, 28);
            this.numericMesEditar.TabIndex = 23;
            this.numericMesEditar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericAnoEditar
            // 
            this.numericAnoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAnoEditar.Location = new System.Drawing.Point(91, 191);
            this.numericAnoEditar.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericAnoEditar.Minimum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numericAnoEditar.Name = "numericAnoEditar";
            this.numericAnoEditar.Size = new System.Drawing.Size(179, 28);
            this.numericAnoEditar.TabIndex = 24;
            this.numericAnoEditar.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(75, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 41);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericAnoEditar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericMesEditar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericValorEditar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(688, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 433);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Orçamento";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Tomato;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(221, 305);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(121, 41);
            this.btnRemover.TabIndex = 26;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // OrcamentoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1154, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericValorMaximo);
            this.Controls.Add(this.listBoxOrcamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericAno);
            this.Controls.Add(this.numericMes);
            this.Controls.Add(this.btnCriarOrcamento);
            this.Controls.Add(this.panel1);
            this.Name = "OrcamentoForm";
            this.Text = "OrcamentoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValorEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMesEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnoEditar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCriarOrcamento;
        private System.Windows.Forms.NumericUpDown numericMes;
        private System.Windows.Forms.NumericUpDown numericAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxOrcamentos;
        private System.Windows.Forms.NumericUpDown numericValorMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericValorEditar;
        private System.Windows.Forms.NumericUpDown numericMesEditar;
        private System.Windows.Forms.NumericUpDown numericAnoEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox picbox_voltar;
    }
}