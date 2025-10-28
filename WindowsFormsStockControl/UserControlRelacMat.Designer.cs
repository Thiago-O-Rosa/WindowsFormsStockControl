namespace WindowsFormsStockControl
{
    partial class UserControlRelacMat
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
            this.lblRelacMat = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pbxPesquisa = new System.Windows.Forms.PictureBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNnumSerie = new System.Windows.Forms.TextBox();
            this.tbxLocal = new System.Windows.Forms.TextBox();
            this.btnCautela = new System.Windows.Forms.Button();
            this.userControlCautela1 = new WindowsFormsStockControl.UserControlCautela();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelacMat
            // 
            this.lblRelacMat.AutoSize = true;
            this.lblRelacMat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelacMat.Location = new System.Drawing.Point(233, 14);
            this.lblRelacMat.Name = "lblRelacMat";
            this.lblRelacMat.Size = new System.Drawing.Size(209, 30);
            this.lblRelacMat.TabIndex = 0;
            this.lblRelacMat.Text = "Relação de Materiais";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(36, 204);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(631, 434);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick_1);
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            this.dgvProduct.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRelacMat_MouseDoubleClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(41, 78);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(51, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Perquisa:";
            this.lblSearch.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearch.Location = new System.Drawing.Point(44, 94);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(113, 20);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // pbxPesquisa
            // 
            this.pbxPesquisa.Image = global::WindowsFormsStockControl.Properties.Resources.serach;
            this.pbxPesquisa.Location = new System.Drawing.Point(162, 92);
            this.pbxPesquisa.Name = "pbxPesquisa";
            this.pbxPesquisa.Size = new System.Drawing.Size(25, 25);
            this.pbxPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPesquisa.TabIndex = 4;
            this.pbxPesquisa.TabStop = false;
            this.pbxPesquisa.Click += new System.EventHandler(this.pbxPesquisa_Click);
            this.pbxPesquisa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxPesquisa_MouseClick);
            // 
            // tbxModel
            // 
            this.tbxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxModel.Location = new System.Drawing.Point(44, 178);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 22;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(41, 162);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 13);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Modelo:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(85, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(41, 34);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 19;
            this.lblCode.Text = "Código";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(169, 162);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(40, 13);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Marca:";
            // 
            // tbxMarca
            // 
            this.tbxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMarca.Location = new System.Drawing.Point(172, 178);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxMarca.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Númedo de série:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Localização:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxNnumSerie
            // 
            this.tbxNnumSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNnumSerie.Location = new System.Drawing.Point(307, 178);
            this.tbxNnumSerie.Name = "tbxNnumSerie";
            this.tbxNnumSerie.Size = new System.Drawing.Size(100, 20);
            this.tbxNnumSerie.TabIndex = 27;
            // 
            // tbxLocal
            // 
            this.tbxLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLocal.Location = new System.Drawing.Point(451, 178);
            this.tbxLocal.Name = "tbxLocal";
            this.tbxLocal.Size = new System.Drawing.Size(100, 20);
            this.tbxLocal.TabIndex = 28;
            // 
            // btnCautela
            // 
            this.btnCautela.Location = new System.Drawing.Point(578, 178);
            this.btnCautela.Name = "btnCautela";
            this.btnCautela.Size = new System.Drawing.Size(89, 20);
            this.btnCautela.TabIndex = 29;
            this.btnCautela.Text = "Cautela";
            this.btnCautela.UseVisualStyleBackColor = true;
            this.btnCautela.Click += new System.EventHandler(this.btnCautela_Click);
            // 
            // userControlCautela1
            // 
            this.userControlCautela1.Location = new System.Drawing.Point(0, 0);
            this.userControlCautela1.Name = "userControlCautela1";
            this.userControlCautela1.Size = new System.Drawing.Size(700, 700);
            this.userControlCautela1.TabIndex = 30;
            // 
            // UserControlRelacMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlCautela1);
            this.Controls.Add(this.btnCautela);
            this.Controls.Add(this.tbxLocal);
            this.Controls.Add(this.tbxNnumSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.pbxPesquisa);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.lblRelacMat);
            this.Name = "UserControlRelacMat";
            this.Size = new System.Drawing.Size(700, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelacMat;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.PictureBox pbxPesquisa;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNnumSerie;
        private System.Windows.Forms.TextBox tbxLocal;
        private System.Windows.Forms.Button btnCautela;
        private UserControlCautela userControlCautela1;
    }
}
