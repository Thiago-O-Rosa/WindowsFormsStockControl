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
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblLocalização = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.dtpCautela = new System.Windows.Forms.DateTimePicker();
            this.lblDataCautela = new System.Windows.Forms.Label();
            this.lblDataDescautela = new System.Windows.Forms.Label();
            this.dtpDataDescautela = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
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
            this.tbxProduto.Size = new System.Drawing.Size(138, 20);
            this.tbxProduto.TabIndex = 1;
            // 
            // tbxNumSerie
            // 
            this.tbxNumSerie.Location = new System.Drawing.Point(80, 187);
            this.tbxNumSerie.Name = "tbxNumSerie";
            this.tbxNumSerie.Size = new System.Drawing.Size(140, 20);
            this.tbxNumSerie.TabIndex = 2;
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(80, 281);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(140, 20);
            this.tbxModelo.TabIndex = 3;
            // 
            // tbxLocalização
            // 
            this.tbxLocalização.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbxLocalização.Location = new System.Drawing.Point(82, 355);
            this.tbxLocalização.Name = "tbxLocalização";
            this.tbxLocalização.Size = new System.Drawing.Size(138, 20);
            this.tbxLocalização.TabIndex = 4;
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
            this.lblNumSerie.Location = new System.Drawing.Point(79, 171);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(59, 13);
            this.lblNumSerie.TabIndex = 7;
            this.lblNumSerie.Text = "Num_Serie";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(79, 265);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo";
            // 
            // lblLocalização
            // 
            this.lblLocalização.AutoSize = true;
            this.lblLocalização.Location = new System.Drawing.Point(79, 339);
            this.lblLocalização.Name = "lblLocalização";
            this.lblLocalização.Size = new System.Drawing.Size(64, 13);
            this.lblLocalização.TabIndex = 9;
            this.lblLocalização.Text = "Localização";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(342, 292);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(342, 198);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(22, 13);
            this.lblTel.TabIndex = 18;
            this.lblTel.Text = "Tel";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(342, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(343, 308);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(141, 20);
            this.tbxEmail.TabIndex = 14;
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(343, 214);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(141, 20);
            this.tbxTel.TabIndex = 13;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(345, 124);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(139, 20);
            this.tbxNome.TabIndex = 12;
            // 
            // dtpCautela
            // 
            this.dtpCautela.Location = new System.Drawing.Point(343, 379);
            this.dtpCautela.Name = "dtpCautela";
            this.dtpCautela.Size = new System.Drawing.Size(200, 20);
            this.dtpCautela.TabIndex = 20;
            // 
            // lblDataCautela
            // 
            this.lblDataCautela.AutoSize = true;
            this.lblDataCautela.Location = new System.Drawing.Point(340, 363);
            this.lblDataCautela.Name = "lblDataCautela";
            this.lblDataCautela.Size = new System.Drawing.Size(69, 13);
            this.lblDataCautela.TabIndex = 21;
            this.lblDataCautela.Text = "Data Cautela";
            // 
            // lblDataDescautela
            // 
            this.lblDataDescautela.AutoSize = true;
            this.lblDataDescautela.Location = new System.Drawing.Point(340, 418);
            this.lblDataDescautela.Name = "lblDataDescautela";
            this.lblDataDescautela.Size = new System.Drawing.Size(133, 13);
            this.lblDataDescautela.TabIndex = 23;
            this.lblDataDescautela.Text = "Data Descautela/Previsão";
            // 
            // dtpDataDescautela
            // 
            this.dtpDataDescautela.Location = new System.Drawing.Point(343, 434);
            this.dtpDataDescautela.Name = "dtpDataDescautela";
            this.dtpDataDescautela.Size = new System.Drawing.Size(200, 20);
            this.dtpDataDescautela.TabIndex = 22;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(368, 508);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(83, 45);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(116, 393);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // UserControlCautela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblDataDescautela);
            this.Controls.Add(this.dtpDataDescautela);
            this.Controls.Add(this.lblDataCautela);
            this.Controls.Add(this.dtpCautela);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblLocalização);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.tbxLocalização);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.tbxNumSerie);
            this.Controls.Add(this.tbxProduto);
            this.Controls.Add(this.lblCautela);
            this.Name = "UserControlCautela";
            this.Size = new System.Drawing.Size(700, 700);
            this.Load += new System.EventHandler(this.UserControlCautela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCautela;
        private System.Windows.Forms.TextBox tbxProduto;
        private System.Windows.Forms.TextBox tbxNumSerie;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.TextBox tbxLocalização;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblLocalização;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.DateTimePicker dtpCautela;
        private System.Windows.Forms.Label lblDataCautela;
        private System.Windows.Forms.Label lblDataDescautela;
        private System.Windows.Forms.DateTimePicker dtpDataDescautela;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVoltar;
    }
}
