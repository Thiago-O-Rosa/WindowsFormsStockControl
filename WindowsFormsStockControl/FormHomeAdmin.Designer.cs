namespace WindowsFormsStockControl
{
    partial class FormHomeAdmin
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRelMat = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnMatDisp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlRelacMat1 = new WindowsFormsStockControl.UserControlRelacMat();
            this.userControlPesquisa1 = new WindowsFormsStockControl.UserControlPesquisa();
            this.userControlMatDisp1 = new WindowsFormsStockControl.UserControlMatDisp();
            this._UserControlAdicionar1 = new WindowsFormsStockControl._UserControlAdicionar();
            this._UserControlRemover1 = new WindowsFormsStockControl._UserControlRemover();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnRelMat);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.btnMatDisp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 8;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(65, 428);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 33);
            this.btnUsuario.TabIndex = 11;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(66, 383);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 39);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover (BD)";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(64, 665);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRelMat
            // 
            this.btnRelMat.Location = new System.Drawing.Point(65, 235);
            this.btnRelMat.Name = "btnRelMat";
            this.btnRelMat.Size = new System.Drawing.Size(75, 35);
            this.btnRelMat.TabIndex = 1;
            this.btnRelMat.Text = "Relação de Materiais";
            this.btnRelMat.UseVisualStyleBackColor = true;
            this.btnRelMat.Click += new System.EventHandler(this.btnRelMat_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(66, 354);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(64, 276);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnMatDisp
            // 
            this.btnMatDisp.Location = new System.Drawing.Point(65, 305);
            this.btnMatDisp.Name = "btnMatDisp";
            this.btnMatDisp.Size = new System.Drawing.Size(75, 34);
            this.btnMatDisp.TabIndex = 3;
            this.btnMatDisp.Text = "Material Disponivel";
            this.btnMatDisp.UseVisualStyleBackColor = true;
            this.btnMatDisp.Click += new System.EventHandler(this.btnMatDisp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsStockControl.Properties.Resources.Logo_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // userControlRelacMat1
            // 
            this.userControlRelacMat1.Location = new System.Drawing.Point(200, 0);
            this.userControlRelacMat1.Name = "userControlRelacMat1";
            this.userControlRelacMat1.Size = new System.Drawing.Size(700, 700);
            this.userControlRelacMat1.TabIndex = 15;
            // 
            // userControlPesquisa1
            // 
            this.userControlPesquisa1.Location = new System.Drawing.Point(200, 0);
            this.userControlPesquisa1.Name = "userControlPesquisa1";
            this.userControlPesquisa1.Size = new System.Drawing.Size(700, 700);
            this.userControlPesquisa1.TabIndex = 14;
            // 
            // userControlMatDisp1
            // 
            this.userControlMatDisp1.Location = new System.Drawing.Point(200, 0);
            this.userControlMatDisp1.Name = "userControlMatDisp1";
            this.userControlMatDisp1.Size = new System.Drawing.Size(700, 700);
            this.userControlMatDisp1.TabIndex = 13;
            // 
            // _UserControlAdicionar1
            // 
            this._UserControlAdicionar1.Location = new System.Drawing.Point(200, 0);
            this._UserControlAdicionar1.Name = "_UserControlAdicionar1";
            this._UserControlAdicionar1.Size = new System.Drawing.Size(700, 700);
            this._UserControlAdicionar1.TabIndex = 12;
            // 
            // _UserControlRemover1
            // 
            this._UserControlRemover1.Location = new System.Drawing.Point(200, 0);
            this._UserControlRemover1.Name = "_UserControlRemover1";
            this._UserControlRemover1.Size = new System.Drawing.Size(700, 700);
            this._UserControlRemover1.TabIndex = 11;
            // 
            // FormHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.userControlRelacMat1);
            this.Controls.Add(this.userControlPesquisa1);
            this.Controls.Add(this.userControlMatDisp1);
            this.Controls.Add(this._UserControlAdicionar1);
            this.Controls.Add(this._UserControlRemover1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomeAdmin";
            this.Text = "FormHomeAdmin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRelMat;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnMatDisp;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnUsuario;
        private _UserControlRemover _UserControlRemover1;
        private _UserControlAdicionar _UserControlAdicionar1;
        private UserControlMatDisp userControlMatDisp1;
        private UserControlPesquisa userControlPesquisa1;
        private UserControlRelacMat userControlRelacMat1;
    }
}