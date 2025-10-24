namespace WindowsFormsStockControl
{
    partial class UserControlCautela
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
            this.lblCautela = new System.Windows.Forms.Label();
            this.tbxProduto = new System.Windows.Forms.TextBox();
            this.tbxNumSerie = new System.Windows.Forms.TextBox();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.tbxLocalização = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblLocalização = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCautela
            // 
            this.lblCautela.AutoSize = true;
            this.lblCautela.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCautela.Location = new System.Drawing.Point(259, 9);
            this.lblCautela.Name = "lblCautela";
            this.lblCautela.Size = new System.Drawing.Size(179, 25);
            this.lblCautela.TabIndex = 0;
            this.lblCautela.Text = "Cautela de material";
            // 
            // tbxProduto
            // 
            this.tbxProduto.Location = new System.Drawing.Point(82, 119);
            this.tbxProduto.Name = "tbxProduto";
            this.tbxProduto.Size = new System.Drawing.Size(100, 20);
            this.tbxProduto.TabIndex = 1;
            // 
            // tbxNumSerie
            // 
            this.tbxNumSerie.Location = new System.Drawing.Point(80, 209);
            this.tbxNumSerie.Name = "tbxNumSerie";
            this.tbxNumSerie.Size = new System.Drawing.Size(100, 20);
            this.tbxNumSerie.TabIndex = 2;
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(80, 303);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(100, 20);
            this.tbxModelo.TabIndex = 3;
            // 
            // tbxLocalização
            // 
            this.tbxLocalização.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxLocalização.Location = new System.Drawing.Point(82, 377);
            this.tbxLocalização.Name = "tbxLocalização";
            this.tbxLocalização.Size = new System.Drawing.Size(100, 20);
            this.tbxLocalização.TabIndex = 4;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(80, 453);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 20);
            this.tbxNome.TabIndex = 5;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(79, 103);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(43, 13);
            this.lblProduto.TabIndex = 6;
            this.lblProduto.Text = "produto";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(79, 193);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(59, 13);
            this.lblNumSerie.TabIndex = 7;
            this.lblNumSerie.Text = "Num_Serie";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(79, 287);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo";
            // 
            // lblLocalização
            // 
            this.lblLocalização.AutoSize = true;
            this.lblLocalização.Location = new System.Drawing.Point(79, 361);
            this.lblLocalização.Name = "lblLocalização";
            this.lblLocalização.Size = new System.Drawing.Size(64, 13);
            this.lblLocalização.TabIndex = 9;
            this.lblLocalização.Text = "Localização";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(79, 437);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "produto, numSerie, modelo, localizacao, nome";
            // 
            // UserControlCautela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblLocalização);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.tbxLocalização);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.tbxNumSerie);
            this.Controls.Add(this.tbxProduto);
            this.Controls.Add(this.lblCautela);
            this.Name = "UserControlCautela";
            this.Size = new System.Drawing.Size(700, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCautela;
        private System.Windows.Forms.TextBox tbxProduto;
        private System.Windows.Forms.TextBox tbxNumSerie;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.TextBox tbxLocalização;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblLocalização;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label6;
    }
}
