namespace trabBD1cdloc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnAltExcConta = new System.Windows.Forms.Button();
            this.btnCadastroCD = new System.Windows.Forms.Button();
            this.btnCadArtGen = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(12, 232);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(228, 23);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro de Conta";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // btnAltExcConta
            // 
            this.btnAltExcConta.Location = new System.Drawing.Point(12, 261);
            this.btnAltExcConta.Name = "btnAltExcConta";
            this.btnAltExcConta.Size = new System.Drawing.Size(228, 23);
            this.btnAltExcConta.TabIndex = 1;
            this.btnAltExcConta.Text = "Alteração/Exclusão de Conta";
            this.btnAltExcConta.UseVisualStyleBackColor = true;
            // 
            // btnCadastroCD
            // 
            this.btnCadastroCD.Location = new System.Drawing.Point(12, 290);
            this.btnCadastroCD.Name = "btnCadastroCD";
            this.btnCadastroCD.Size = new System.Drawing.Size(228, 23);
            this.btnCadastroCD.TabIndex = 2;
            this.btnCadastroCD.Text = "Cadastrar CD";
            this.btnCadastroCD.UseVisualStyleBackColor = true;
            // 
            // btnCadArtGen
            // 
            this.btnCadArtGen.Location = new System.Drawing.Point(12, 319);
            this.btnCadArtGen.Name = "btnCadArtGen";
            this.btnCadArtGen.Size = new System.Drawing.Size(228, 23);
            this.btnCadArtGen.TabIndex = 3;
            this.btnCadArtGen.Text = "Cadastrar Artista/Genero";
            this.btnCadArtGen.UseVisualStyleBackColor = true;
            this.btnCadArtGen.Click += new System.EventHandler(this.BtnCadArtGen_Click);
            // 
            // btnAlugar
            // 
            this.btnAlugar.Location = new System.Drawing.Point(12, 348);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(228, 23);
            this.btnAlugar.TabIndex = 4;
            this.btnAlugar.Text = "Alugar CD";
            this.btnAlugar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.btnCadArtGen);
            this.Controls.Add(this.btnCadastroCD);
            this.Controls.Add(this.btnAltExcConta);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Form1";
            this.Text = "Vinyl Record Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnAltExcConta;
        private System.Windows.Forms.Button btnCadastroCD;
        private System.Windows.Forms.Button btnCadArtGen;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

