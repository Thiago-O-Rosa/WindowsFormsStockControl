namespace WindowsFormsStockControl
{
    partial class FormLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.pbxEmail = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).BeginInit();
            this.pnlAzul.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsStockControl.Properties.Resources.Logo_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(270, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbxPassword
            // 
            this.pbxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbxPassword.Image")));
            this.pbxPassword.Location = new System.Drawing.Point(47, 162);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(30, 29);
            this.pbxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPassword.TabIndex = 24;
            this.pbxPassword.TabStop = false;
            // 
            // pbxEmail
            // 
            this.pbxEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbxEmail.Image")));
            this.pbxEmail.Location = new System.Drawing.Point(47, 60);
            this.pbxEmail.Name = "pbxEmail";
            this.pbxEmail.Size = new System.Drawing.Size(30, 29);
            this.pbxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEmail.TabIndex = 23;
            this.pbxEmail.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(102, 287);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(84, 31);
            this.btnEntrar.TabIndex = 22;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(88, 171);
            this.tbxPassword.MaxLength = 16;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(125, 20);
            this.tbxPassword.TabIndex = 21;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(88, 69);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(125, 20);
            this.tbxEmail.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(83, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 25);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Senha";
            // 
            // pnlAzul
            // 
            this.pnlAzul.AutoScroll = true;
            this.pnlAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlAzul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAzul.Controls.Add(this.lblEmail);
            this.pnlAzul.Controls.Add(this.pbxPassword);
            this.pnlAzul.Controls.Add(this.label1);
            this.pnlAzul.Controls.Add(this.pbxEmail);
            this.pnlAzul.Controls.Add(this.btnEntrar);
            this.pnlAzul.Controls.Add(this.lblPassword);
            this.pnlAzul.Controls.Add(this.tbxPassword);
            this.pnlAzul.Controls.Add(this.tbxEmail);
            this.pnlAzul.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAzul.ForeColor = System.Drawing.Color.Black;
            this.pnlAzul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlAzul.Location = new System.Drawing.Point(305, 246);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlAzul.Size = new System.Drawing.Size(288, 335);
            this.pnlAzul.TabIndex = 25;
            this.pnlAzul.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAzul_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(83, 41);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 25);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pnlAzul);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Apex Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).EndInit();
            this.pnlAzul.ResumeLayout(false);
            this.pnlAzul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxPassword;
        private System.Windows.Forms.PictureBox pbxEmail;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
    }
}

