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
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnRelMat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(61, 665);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelMat
            // 
            this.btnRelMat.BackColor = System.Drawing.Color.DarkGray;
            this.btnRelMat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRelMat.FlatAppearance.BorderSize = 0;
            this.btnRelMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelMat.Location = new System.Drawing.Point(61, 331);
            this.btnRelMat.Name = "btnRelMat";
            this.btnRelMat.Size = new System.Drawing.Size(75, 35);
            this.btnRelMat.TabIndex = 1;
            this.btnRelMat.Text = "Relação de Materiais";
            this.btnRelMat.UseVisualStyleBackColor = false;
            this.btnRelMat.Click += new System.EventHandler(this.btnRelMat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
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
            this.userControlRelacMat.Load += new System.EventHandler(this.userControlRelacMat_Load);
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
        private _UserControlAdicionar _UserControlAdicionar;
        private _UserControlRemover _UserControlAdicionarUsuario;
        private UserControlRelacMat userControlRelacMat;
    }
}