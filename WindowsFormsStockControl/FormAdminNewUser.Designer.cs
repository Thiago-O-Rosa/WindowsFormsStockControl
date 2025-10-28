namespace WindowsFormsStockControl
{
    partial class FormAdminNewUser
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
            this.btnRelMat = new System.Windows.Forms.Button();
            this.btnNovoMat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnNovoUser = new System.Windows.Forms.Button();
            this._UserControlAdicionarNovoMat = new WindowsFormsStockControl._UserControlAdicionar();
            this._UserControlAddUser = new WindowsFormsStockControl._UserControlRemover();
            this.userControlRelacMat = new WindowsFormsStockControl.UserControlRelacMat();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRelMat);
            this.panel1.Controls.Add(this.btnNovoMat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnNovoUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 10;
            // 
            // btnRelMat
            // 
            this.btnRelMat.BackColor = System.Drawing.Color.DarkGray;
            this.btnRelMat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRelMat.FlatAppearance.BorderSize = 0;
            this.btnRelMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelMat.Location = new System.Drawing.Point(64, 318);
            this.btnRelMat.Name = "btnRelMat";
            this.btnRelMat.Size = new System.Drawing.Size(75, 35);
            this.btnRelMat.TabIndex = 12;
            this.btnRelMat.Text = "Relação de Materiais";
            this.btnRelMat.UseVisualStyleBackColor = false;
            this.btnRelMat.Click += new System.EventHandler(this.btnRelMat_Click);
            // 
            // btnNovoMat
            // 
            this.btnNovoMat.BackColor = System.Drawing.Color.DarkGray;
            this.btnNovoMat.FlatAppearance.BorderSize = 0;
            this.btnNovoMat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoMat.Location = new System.Drawing.Point(64, 445);
            this.btnNovoMat.Name = "btnNovoMat";
            this.btnNovoMat.Size = new System.Drawing.Size(75, 54);
            this.btnNovoMat.TabIndex = 7;
            this.btnNovoMat.Text = "Adicionar Novo Material";
            this.btnNovoMat.UseVisualStyleBackColor = false;
            this.btnNovoMat.Click += new System.EventHandler(this.btnNovoMat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsStockControl.Properties.Resources.Logo_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(64, 665);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnNovoUser
            // 
            this.btnNovoUser.BackColor = System.Drawing.Color.DarkGray;
            this.btnNovoUser.FlatAppearance.BorderSize = 0;
            this.btnNovoUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoUser.Location = new System.Drawing.Point(64, 371);
            this.btnNovoUser.Name = "btnNovoUser";
            this.btnNovoUser.Size = new System.Drawing.Size(75, 54);
            this.btnNovoUser.TabIndex = 3;
            this.btnNovoUser.Text = "Adicionar Novo Usuário";
            this.btnNovoUser.UseVisualStyleBackColor = false;
            this.btnNovoUser.Click += new System.EventHandler(this.btnNovoUser_Click);
            // 
            // _UserControlAdicionarNovoMat
            // 
            this._UserControlAdicionarNovoMat.Location = new System.Drawing.Point(200, 0);
            this._UserControlAdicionarNovoMat.Name = "_UserControlAdicionarNovoMat";
            this._UserControlAdicionarNovoMat.Size = new System.Drawing.Size(700, 700);
            this._UserControlAdicionarNovoMat.TabIndex = 11;
            // 
            // _UserControlAddUser
            // 
            this._UserControlAddUser.Location = new System.Drawing.Point(200, 0);
            this._UserControlAddUser.Name = "_UserControlAddUser";
            this._UserControlAddUser.Size = new System.Drawing.Size(700, 700);
            this._UserControlAddUser.TabIndex = 12;
            // 
            // userControlRelacMat
            // 
            this.userControlRelacMat.Location = new System.Drawing.Point(200, 0);
            this.userControlRelacMat.Name = "userControlRelacMat";
            this.userControlRelacMat.Size = new System.Drawing.Size(700, 700);
            this.userControlRelacMat.TabIndex = 13;
            // 
            // FormAdminNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.userControlRelacMat);
            this.Controls.Add(this._UserControlAddUser);
            this.Controls.Add(this._UserControlAdicionarNovoMat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminNewUser";
            this.Text = "FormAdminNewUser";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnNovoUser;
        private System.Windows.Forms.Button btnNovoMat;
        private System.Windows.Forms.Button btnRelMat;
        private _UserControlAdicionar _UserControlAdicionarNovoMat;
        private _UserControlRemover _UserControlAddUser;
        private UserControlRelacMat userControlRelacMat;
    }
}