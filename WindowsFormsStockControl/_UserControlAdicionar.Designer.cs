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
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQtde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUserCadastro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
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
            this.tbxNomeMat.Location = new System.Drawing.Point(61, 96);
            this.tbxNomeMat.Name = "tbxNomeMat";
            this.tbxNomeMat.Size = new System.Drawing.Size(187, 20);
            this.tbxNomeMat.TabIndex = 1;
            this.tbxNomeMat.TextChanged += new System.EventHandler(this.tbxNomeMat_TextChanged);
            // 
            // lblNomeMat
            // 
            this.lblNomeMat.AutoSize = true;
            this.lblNomeMat.Location = new System.Drawing.Point(58, 80);
            this.lblNomeMat.Name = "lblNomeMat";
            this.lblNomeMat.Size = new System.Drawing.Size(93, 13);
            this.lblNomeMat.TabIndex = 2;
            this.lblNomeMat.Text = "Nome do Material:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(58, 187);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(58, 132);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo:";
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(61, 148);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(199, 20);
            this.tbxModelo.TabIndex = 6;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(58, 295);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(87, 13);
            this.lblNumSerie.TabIndex = 7;
            this.lblNumSerie.Text = "Numero de série:";
            // 
            // tbxNumSerie
            // 
            this.tbxNumSerie.Location = new System.Drawing.Point(61, 311);
            this.tbxNumSerie.Name = "tbxNumSerie";
            this.tbxNumSerie.Size = new System.Drawing.Size(90, 20);
            this.tbxNumSerie.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(234, 375);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(98, 35);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(352, 375);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 35);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "Samsung",
            "Dell",
            "Multilaser",
            "LG",
            "Lenovo"});
            this.cbxMarca.Location = new System.Drawing.Point(61, 203);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Localização:";
            // 
            // cbxLocal
            // 
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Items.AddRange(new object[] {
            "Prateleira 1",
            "Prateleira 2",
            "Prateleira 3",
            "Prateleira 4",
            "Prateleira 5"});
            this.cbxLocal.Location = new System.Drawing.Point(350, 148);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(121, 21);
            this.cbxLocal.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Categoria:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Máquina",
            "Periférico"});
            this.cbxCategoria.Location = new System.Drawing.Point(61, 255);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 19;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Location = new System.Drawing.Point(13, 416);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.Size = new System.Drawing.Size(674, 231);
            this.dgvMaterial.TabIndex = 21;
            this.dgvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            this.dgvMaterial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMaterial_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade:";
            // 
            // tbxQtde
            // 
            this.tbxQtde.Location = new System.Drawing.Point(350, 96);
            this.tbxQtde.Name = "tbxQtde";
            this.tbxQtde.Size = new System.Drawing.Size(100, 20);
            this.tbxQtde.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Usuario a cadastrar o material:";
            // 
            // cbxUserCadastro
            // 
            this.cbxUserCadastro.FormattingEnabled = true;
            this.cbxUserCadastro.Items.AddRange(new object[] {
            "Admin"});
            this.cbxUserCadastro.Location = new System.Drawing.Point(543, 43);
            this.cbxUserCadastro.Name = "cbxUserCadastro";
            this.cbxUserCadastro.Size = new System.Drawing.Size(85, 21);
            this.cbxUserCadastro.TabIndex = 25;
            // 
            // _UserControlAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxUserCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxQtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMarca);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
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
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxQtde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUserCadastro;
    }
}
