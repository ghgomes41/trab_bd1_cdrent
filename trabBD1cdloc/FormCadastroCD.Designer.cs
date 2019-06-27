namespace trabBD1cdloc
{
    partial class FormCadastroCD
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
            this.qtdestoque = new System.Windows.Forms.NumericUpDown();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbArtista = new System.Windows.Forms.ComboBox();
            this.txtTituloCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCD = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdestoque)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qtdestoque);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Controls.Add(this.cbGenero);
            this.groupBox1.Controls.Add(this.cbArtista);
            this.groupBox1.Controls.Add(this.txtTituloCD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de CD";
            // 
            // qtdestoque
            // 
            this.qtdestoque.Location = new System.Drawing.Point(9, 212);
            this.qtdestoque.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.qtdestoque.Name = "qtdestoque";
            this.qtdestoque.Size = new System.Drawing.Size(120, 20);
            this.qtdestoque.TabIndex = 14;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(329, 156);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 13;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "--- ESCOLHA GENERO ---"});
            this.cbGenero.Location = new System.Drawing.Point(9, 156);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(288, 21);
            this.cbGenero.TabIndex = 12;
            // 
            // cbArtista
            // 
            this.cbArtista.FormattingEnabled = true;
            this.cbArtista.Items.AddRange(new object[] {
            "--- ESCOLHA ARTISTA ---"});
            this.cbArtista.Location = new System.Drawing.Point(9, 106);
            this.cbArtista.Name = "cbArtista";
            this.cbArtista.Size = new System.Drawing.Size(420, 21);
            this.cbArtista.TabIndex = 11;
            // 
            // txtTituloCD
            // 
            this.txtTituloCD.Location = new System.Drawing.Point(9, 47);
            this.txtTituloCD.Name = "txtTituloCD";
            this.txtTituloCD.Size = new System.Drawing.Size(420, 20);
            this.txtTituloCD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qtd. em Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Artista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Título:";
            // 
            // btnSaveCD
            // 
            this.btnSaveCD.Location = new System.Drawing.Point(372, 369);
            this.btnSaveCD.Name = "btnSaveCD";
            this.btnSaveCD.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCD.TabIndex = 1;
            this.btnSaveCD.Text = "Salvar";
            this.btnSaveCD.UseVisualStyleBackColor = true;
            this.btnSaveCD.Click += new System.EventHandler(this.BtnSaveCD_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(291, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // FormCadastroCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 397);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveCD);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastroCD";
            this.Text = "FormCadastroCD";
            this.Load += new System.EventHandler(this.FormCadastroCD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdestoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbArtista;
        private System.Windows.Forms.TextBox txtTituloCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qtdestoque;
        private System.Windows.Forms.Button btnSaveCD;
        private System.Windows.Forms.Button btnReset;
    }
}