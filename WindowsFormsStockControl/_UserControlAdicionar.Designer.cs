namespace WindowsFormsStockControl
{
    partial class _UserControlAdicionar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNomeMat = new System.Windows.Forms.TextBox();
            this.lblNomeMat = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.tbxNumSerie = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.tbnOu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Novo Material";
            // 
            // tbxNomeMat
            // 
            this.tbxNomeMat.Location = new System.Drawing.Point(175, 98);
            this.tbxNomeMat.Name = "tbxNomeMat";
            this.tbxNomeMat.Size = new System.Drawing.Size(259, 20);
            this.tbxNomeMat.TabIndex = 1;
            // 
            // lblNomeMat
            // 
            this.lblNomeMat.AutoSize = true;
            this.lblNomeMat.Location = new System.Drawing.Point(172, 82);
            this.lblNomeMat.Name = "lblNomeMat";
            this.lblNomeMat.Size = new System.Drawing.Size(93, 13);
            this.lblNomeMat.TabIndex = 2;
            this.lblNomeMat.Text = "Nome do Material:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(172, 149);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(175, 165);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(259, 20);
            this.tbxMarca.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(172, 231);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo:";
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(175, 247);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(259, 20);
            this.tbxModelo.TabIndex = 6;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(172, 311);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(87, 13);
            this.lblNumSerie.TabIndex = 7;
            this.lblNumSerie.Text = "Numero de série:";
            // 
            // tbxNumSerie
            // 
            this.tbxNumSerie.Location = new System.Drawing.Point(175, 327);
            this.tbxNumSerie.Name = "tbxNumSerie";
            this.tbxNumSerie.Size = new System.Drawing.Size(259, 20);
            this.tbxNumSerie.TabIndex = 8;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(172, 377);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação:";
            // 
            // tbxObservacao
            // 
            this.tbxObservacao.Location = new System.Drawing.Point(175, 393);
            this.tbxObservacao.Name = "tbxObservacao";
            this.tbxObservacao.Size = new System.Drawing.Size(259, 20);
            this.tbxObservacao.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(175, 473);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(259, 23);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(175, 579);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(259, 23);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // tbnOu
            // 
            this.tbnOu.AutoSize = true;
            this.tbnOu.Location = new System.Drawing.Point(293, 535);
            this.tbnOu.Name = "tbnOu";
            this.tbnOu.Size = new System.Drawing.Size(21, 13);
            this.tbnOu.TabIndex = 14;
            this.tbnOu.Text = "Ou";
            // 
            // _UserControlAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbnOu);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxNumSerie);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNomeMat);
            this.Controls.Add(this.tbxNomeMat);
            this.Controls.Add(this.label1);
            this.Name = "_UserControlAdicionar";
            this.Size = new System.Drawing.Size(700, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNomeMat;
        private System.Windows.Forms.Label lblNomeMat;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox tbxNumSerie;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label tbnOu;
    }
}
