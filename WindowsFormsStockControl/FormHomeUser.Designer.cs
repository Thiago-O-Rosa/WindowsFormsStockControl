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
            this.button6 = new System.Windows.Forms.Button();
            this.btnRelMat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMatDisp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.@__userControlRelacMat = new WindowsFormsStockControl.UserControlRelacMat();
            this._userControlPesquisa = new WindowsFormsStockControl.UserControlPesquisa();
            this._userControlMatDisp = new WindowsFormsStockControl.UserControlMatDisp();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnRelMat);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnMatDisp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 700);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(61, 665);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRelMat
            // 
            this.btnRelMat.Location = new System.Drawing.Point(61, 306);
            this.btnRelMat.Name = "btnRelMat";
            this.btnRelMat.Size = new System.Drawing.Size(75, 35);
            this.btnRelMat.TabIndex = 1;
            this.btnRelMat.Text = "Relação de Materiais";
            this.btnRelMat.UseVisualStyleBackColor = true;
            this.btnRelMat.Click += new System.EventHandler(this.btnRelMat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(61, 359);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMatDisp
            // 
            this.btnMatDisp.Location = new System.Drawing.Point(61, 410);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // __userControlRelacMat
            // 
            this.@__userControlRelacMat.Location = new System.Drawing.Point(200, 0);
            this.@__userControlRelacMat.Name = "__userControlRelacMat";
            this.@__userControlRelacMat.Size = new System.Drawing.Size(700, 700);
            this.@__userControlRelacMat.TabIndex = 8;
            // 
            // _userControlPesquisa
            // 
            this._userControlPesquisa.Location = new System.Drawing.Point(200, 0);
            this._userControlPesquisa.Name = "_userControlPesquisa";
            this._userControlPesquisa.Size = new System.Drawing.Size(700, 700);
            this._userControlPesquisa.TabIndex = 9;
            // 
            // _userControlMatDisp
            // 
            this._userControlMatDisp.Location = new System.Drawing.Point(200, 0);
            this._userControlMatDisp.Name = "_userControlMatDisp";
            this._userControlMatDisp.Size = new System.Drawing.Size(700, 700);
            this._userControlMatDisp.TabIndex = 10;
            // 
            // FormHomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this._userControlMatDisp);
            this.Controls.Add(this._userControlPesquisa);
            this.Controls.Add(this.@__userControlRelacMat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomeUser";
            this.Text = "FormHomeUser";
            this.Load += new System.EventHandler(this.FormHomeUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRelMat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMatDisp;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControlRelacMat __userControlRelacMat;
        private UserControlPesquisa _userControlPesquisa;
        private UserControlMatDisp _userControlMatDisp;
    }
}