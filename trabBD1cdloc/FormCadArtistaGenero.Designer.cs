namespace trabBD1cdloc
{
    partial class FormCadArtistaGenero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveArt = new System.Windows.Forms.Button();
            this.btnVerificaArt = new System.Windows.Forms.Button();
            this.txtNomeArtista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveGen = new System.Windows.Forms.Button();
            this.btnVerificaGen = new System.Windows.Forms.Button();
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveArt);
            this.groupBox1.Controls.Add(this.btnVerificaArt);
            this.groupBox1.Controls.Add(this.txtNomeArtista);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Artista";
            // 
            // btnSaveArt
            // 
            this.btnSaveArt.Location = new System.Drawing.Point(317, 120);
            this.btnSaveArt.Name = "btnSaveArt";
            this.btnSaveArt.Size = new System.Drawing.Size(75, 23);
            this.btnSaveArt.TabIndex = 3;
            this.btnSaveArt.Text = "Salvar";
            this.btnSaveArt.UseVisualStyleBackColor = true;
            this.btnSaveArt.Click += new System.EventHandler(this.BtnSaveArt_Click);
            // 
            // btnVerificaArt
            // 
            this.btnVerificaArt.Location = new System.Drawing.Point(236, 120);
            this.btnVerificaArt.Name = "btnVerificaArt";
            this.btnVerificaArt.Size = new System.Drawing.Size(75, 23);
            this.btnVerificaArt.TabIndex = 2;
            this.btnVerificaArt.Text = "Verificar";
            this.btnVerificaArt.UseVisualStyleBackColor = true;
            this.btnVerificaArt.Click += new System.EventHandler(this.BtnVerificaArt_Click);
            // 
            // txtNomeArtista
            // 
            this.txtNomeArtista.Location = new System.Drawing.Point(9, 62);
            this.txtNomeArtista.Name = "txtNomeArtista";
            this.txtNomeArtista.Size = new System.Drawing.Size(383, 20);
            this.txtNomeArtista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Artista:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveGen);
            this.groupBox2.Controls.Add(this.btnVerificaGen);
            this.groupBox2.Controls.Add(this.txtNomeGenero);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar Genero";
            // 
            // btnSaveGen
            // 
            this.btnSaveGen.Location = new System.Drawing.Point(317, 137);
            this.btnSaveGen.Name = "btnSaveGen";
            this.btnSaveGen.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGen.TabIndex = 5;
            this.btnSaveGen.Text = "Salvar";
            this.btnSaveGen.UseVisualStyleBackColor = true;
            this.btnSaveGen.Click += new System.EventHandler(this.BtnSaveGen_Click);
            // 
            // btnVerificaGen
            // 
            this.btnVerificaGen.Location = new System.Drawing.Point(236, 137);
            this.btnVerificaGen.Name = "btnVerificaGen";
            this.btnVerificaGen.Size = new System.Drawing.Size(75, 23);
            this.btnVerificaGen.TabIndex = 4;
            this.btnVerificaGen.Text = "Verificar";
            this.btnVerificaGen.UseVisualStyleBackColor = true;
            this.btnVerificaGen.Click += new System.EventHandler(this.BtnVerificaGen_Click);
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Location = new System.Drawing.Point(9, 68);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(383, 20);
            this.txtNomeGenero.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Genero:";
            // 
            // FormCadArtistaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadArtistaGenero";
            this.Text = "FormCadArtistaGenero";
            this.Load += new System.EventHandler(this.FormCadArtistaGenero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveArt;
        private System.Windows.Forms.Button btnVerificaArt;
        private System.Windows.Forms.TextBox txtNomeArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveGen;
        private System.Windows.Forms.Button btnVerificaGen;
        private System.Windows.Forms.TextBox txtNomeGenero;
        private System.Windows.Forms.Label label2;
    }
}