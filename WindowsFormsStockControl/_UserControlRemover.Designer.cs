namespace WindowsFormsStockControl
{
    partial class _UserControlRemover
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
            this.lblPesquisaUser = new System.Windows.Forms.Label();
            this.tbxPesquisaUser = new System.Windows.Forms.TextBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.tbnOu = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar novo Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPesquisaUser
            // 
            this.lblPesquisaUser.AutoSize = true;
            this.lblPesquisaUser.Location = new System.Drawing.Point(79, 389);
            this.lblPesquisaUser.Name = "lblPesquisaUser";
            this.lblPesquisaUser.Size = new System.Drawing.Size(100, 13);
            this.lblPesquisaUser.TabIndex = 34;
            this.lblPesquisaUser.Text = "Pesquisar Usuários:";
            // 
            // tbxPesquisaUser
            // 
            this.tbxPesquisaUser.Location = new System.Drawing.Point(82, 405);
            this.tbxPesquisaUser.Name = "tbxPesquisaUser";
            this.tbxPesquisaUser.Size = new System.Drawing.Size(131, 20);
            this.tbxPesquisaUser.TabIndex = 33;
            this.tbxPesquisaUser.TextChanged += new System.EventHandler(this.tbxPesquisaUser_TextChanged);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(82, 431);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(534, 240);
            this.dgvUsuario.TabIndex = 32;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            this.dgvUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellDoubleClick);
            this.dgvUsuario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsuario_MouseDoubleClick);
            // 
            // tbnOu
            // 
            this.tbnOu.AutoSize = true;
            this.tbnOu.Location = new System.Drawing.Point(418, 176);
            this.tbnOu.Name = "tbnOu";
            this.tbnOu.Size = new System.Drawing.Size(21, 13);
            this.tbnOu.TabIndex = 31;
            this.tbnOu.Text = "Ou";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(368, 220);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 23);
            this.btnRemover.TabIndex = 30;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(368, 114);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionar.TabIndex = 29;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tbxSenha.Location = new System.Drawing.Point(47, 285);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(259, 20);
            this.tbxSenha.TabIndex = 24;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(44, 269);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(47, 159);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(259, 20);
            this.tbxEmail.TabIndex = 22;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome :";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(47, 92);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(259, 20);
            this.tbxNome.TabIndex = 19;
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(47, 223);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(259, 20);
            this.tbxTel.TabIndex = 37;
            this.tbxTel.TextChanged += new System.EventHandler(this.tbxTel_TextChanged);
            this.tbxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTel_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(44, 207);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(25, 13);
            this.lblTel.TabIndex = 36;
            this.lblTel.Text = "Tel:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsStockControl.Properties.Resources.view;
            this.pictureBox1.Location = new System.Drawing.Point(312, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // _UserControlRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPesquisaUser);
            this.Controls.Add(this.tbxPesquisaUser);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.tbnOu);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Name = "_UserControlRemover";
            this.Size = new System.Drawing.Size(700, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPesquisaUser;
        private System.Windows.Forms.TextBox tbxPesquisaUser;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Label tbnOu;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
