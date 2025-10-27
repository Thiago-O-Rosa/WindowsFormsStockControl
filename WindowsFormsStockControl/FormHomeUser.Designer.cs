namespace WindowsFormsStockControl
{
    partial class FormHomeUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionarMat = new System.Windows.Forms.Button();
            this.btnAdicionarUser = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelMat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlRelacMat = new WindowsFormsStockControl.UserControlRelacMat();
            this._UserControlAdicionarUsuario = new WindowsFormsStockControl._UserControlRemover();
            this._UserControlAdicionar = new WindowsFormsStockControl._UserControlAdicionar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdicionarMat);
            this.panel1.Controls.Add(this.btnAdicionarUser);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnRelMat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 0;
            // 
            // btnAdicionarMat
            // 
            this.btnAdicionarMat.Location = new System.Drawing.Point(61, 435);
            this.btnAdicionarMat.Name = "btnAdicionarMat";
            this.btnAdicionarMat.Size = new System.Drawing.Size(75, 54);
            this.btnAdicionarMat.TabIndex = 14;
            this.btnAdicionarMat.Text = "Adicionar Novo Material";
            this.btnAdicionarMat.UseVisualStyleBackColor = true;
            this.btnAdicionarMat.Click += new System.EventHandler(this.btnAdicionarMat_Click);
            // 
            // btnAdicionarUser
            // 
            this.btnAdicionarUser.Location = new System.Drawing.Point(61, 363);
            this.btnAdicionarUser.Name = "btnAdicionarUser";
            this.btnAdicionarUser.Size = new System.Drawing.Size(75, 54);
            this.btnAdicionarUser.TabIndex = 11;
            this.btnAdicionarUser.Text = "Adicnionar novo usuário";
            this.btnAdicionarUser.UseVisualStyleBackColor = true;
            this.btnAdicionarUser.Click += new System.EventHandler(this.btnAdicionarUser_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(61, 665);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelMat
            // 
            this.btnRelMat.Location = new System.Drawing.Point(61, 311);
            this.btnRelMat.Name = "btnRelMat";
            this.btnRelMat.Size = new System.Drawing.Size(75, 35);
            this.btnRelMat.TabIndex = 1;
            this.btnRelMat.Text = "Relação de Materiais";
            this.btnRelMat.UseVisualStyleBackColor = true;
            this.btnRelMat.Click += new System.EventHandler(this.btnRelMat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsStockControl.Properties.Resources.Logo_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // userControlRelacMat
            // 
            this.userControlRelacMat.Location = new System.Drawing.Point(200, 0);
            this.userControlRelacMat.Name = "userControlRelacMat";
            this.userControlRelacMat.Size = new System.Drawing.Size(700, 700);
            this.userControlRelacMat.TabIndex = 10;
            // 
            // _UserControlAdicionarUsuario
            // 
            this._UserControlAdicionarUsuario.Location = new System.Drawing.Point(200, 0);
            this._UserControlAdicionarUsuario.Name = "_UserControlAdicionarUsuario";
            this._UserControlAdicionarUsuario.Size = new System.Drawing.Size(700, 700);
            this._UserControlAdicionarUsuario.TabIndex = 9;
            // 
            // _UserControlAdicionar
            // 
            this._UserControlAdicionar.Location = new System.Drawing.Point(200, 0);
            this._UserControlAdicionar.Name = "_UserControlAdicionar";
            this._UserControlAdicionar.Size = new System.Drawing.Size(700, 700);
            this._UserControlAdicionar.TabIndex = 8;
            // 
            // FormHomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.userControlRelacMat);
            this.Controls.Add(this._UserControlAdicionarUsuario);
            this.Controls.Add(this._UserControlAdicionar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomeUser";
            this.Text = "FormHomeUser";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRelMat;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionarUser;
        private System.Windows.Forms.Button btnAdicionarMat;
        private _UserControlAdicionar _UserControlAdicionar;
        private _UserControlRemover _UserControlAdicionarUsuario;
        private UserControlRelacMat userControlRelacMat;
    }
}