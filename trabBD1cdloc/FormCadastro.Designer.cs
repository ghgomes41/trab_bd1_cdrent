namespace trabBD1cdloc
{
    partial class FormCadastro
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
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtCTPS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rbFuncY = new System.Windows.Forms.RadioButton();
            this.rbFuncN = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.txtDNasc = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.NumericUpDown();
            this.groupBoxFuncionario.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Funcionário?";
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.txtSalario);
            this.groupBoxFuncionario.Controls.Add(this.cbTurno);
            this.groupBoxFuncionario.Controls.Add(this.txtFuncao);
            this.groupBoxFuncionario.Controls.Add(this.txtCTPS);
            this.groupBoxFuncionario.Controls.Add(this.label13);
            this.groupBoxFuncionario.Controls.Add(this.label15);
            this.groupBoxFuncionario.Controls.Add(this.label14);
            this.groupBoxFuncionario.Controls.Add(this.label12);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(39, 367);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(500, 130);
            this.groupBoxFuncionario.TabIndex = 11;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "Funcionário:";
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cbTurno.Location = new System.Drawing.Point(50, 89);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(103, 21);
            this.cbTurno.TabIndex = 22;
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(376, 86);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(103, 20);
            this.txtFuncao.TabIndex = 24;
            // 
            // txtCTPS
            // 
            this.txtCTPS.Location = new System.Drawing.Point(50, 30);
            this.txtCTPS.MaxLength = 13;
            this.txtCTPS.Name = "txtCTPS";
            this.txtCTPS.Size = new System.Drawing.Size(103, 20);
            this.txtCTPS.TabIndex = 22;
            this.txtCTPS.TextChanged += new System.EventHandler(this.TxtCTPS_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(329, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Salário: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(329, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Função:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Turno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "CTPS:";
            // 
            // rbFuncY
            // 
            this.rbFuncY.AutoSize = true;
            this.rbFuncY.Location = new System.Drawing.Point(122, 318);
            this.rbFuncY.Name = "rbFuncY";
            this.rbFuncY.Size = new System.Drawing.Size(42, 17);
            this.rbFuncY.TabIndex = 22;
            this.rbFuncY.TabStop = true;
            this.rbFuncY.Text = "Sim";
            this.rbFuncY.UseVisualStyleBackColor = true;
            this.rbFuncY.CheckedChanged += new System.EventHandler(this.RbFuncY_CheckedChanged);
            // 
            // rbFuncN
            // 
            this.rbFuncN.AutoSize = true;
            this.rbFuncN.Location = new System.Drawing.Point(170, 318);
            this.rbFuncN.Name = "rbFuncN";
            this.rbFuncN.Size = new System.Drawing.Size(45, 17);
            this.rbFuncN.TabIndex = 23;
            this.rbFuncN.TabStop = true;
            this.rbFuncN.Text = "Não";
            this.rbFuncN.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(616, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(616, 428);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 23);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Limpar Campos";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtNum);
            this.gbEndereco.Controls.Add(this.txtUF);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.label10);
            this.gbEndereco.Controls.Add(this.label9);
            this.gbEndereco.Controls.Add(this.label8);
            this.gbEndereco.Controls.Add(this.label7);
            this.gbEndereco.Controls.Add(this.label6);
            this.gbEndereco.Controls.Add(this.label5);
            this.gbEndereco.Location = new System.Drawing.Point(42, 132);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(734, 165);
            this.gbEndereco.TabIndex = 27;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(63, 103);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(87, 20);
            this.txtNum.TabIndex = 33;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(574, 103);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(154, 20);
            this.txtUF.TabIndex = 32;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(574, 42);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(154, 20);
            this.txtBairro.TabIndex = 31;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(220, 103);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(277, 20);
            this.txtCidade.TabIndex = 30;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(63, 42);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(87, 20);
            this.txtCEP.TabIndex = 29;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(220, 42);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(290, 20);
            this.txtRua.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "CEP:";
            // 
            // gbPersonal
            // 
            this.gbPersonal.Controls.Add(this.txtDNasc);
            this.gbPersonal.Controls.Add(this.cbSexo);
            this.gbPersonal.Controls.Add(this.txtCPF);
            this.gbPersonal.Controls.Add(this.txtNome);
            this.gbPersonal.Controls.Add(this.label4);
            this.gbPersonal.Controls.Add(this.label3);
            this.gbPersonal.Controls.Add(this.label2);
            this.gbPersonal.Controls.Add(this.label1);
            this.gbPersonal.Location = new System.Drawing.Point(42, 12);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Size = new System.Drawing.Size(734, 100);
            this.gbPersonal.TabIndex = 28;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Informações Pessoais:";
            // 
            // txtDNasc
            // 
            this.txtDNasc.Location = new System.Drawing.Point(123, 70);
            this.txtDNasc.Mask = "00/00/0000";
            this.txtDNasc.Name = "txtDNasc";
            this.txtDNasc.Size = new System.Drawing.Size(91, 20);
            this.txtDNasc.TabIndex = 34;
            this.txtDNasc.ValidatingType = typeof(System.DateTime);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(443, 70);
            this.cbSexo.MaxDropDownItems = 2;
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(103, 21);
            this.cbSexo.TabIndex = 33;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(443, 13);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(103, 20);
            this.txtCPF.TabIndex = 32;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // txtSalario
            // 
            this.txtSalario.DecimalPlaces = 2;
            this.txtSalario.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtSalario.Location = new System.Drawing.Point(374, 31);
            this.txtSalario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(120, 20);
            this.txtSalario.TabIndex = 25;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.gbPersonal);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbFuncN);
            this.Controls.Add(this.rbFuncY);
            this.Controls.Add(this.groupBoxFuncionario);
            this.Controls.Add(this.label11);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.TextBox txtCTPS;
        private System.Windows.Forms.RadioButton rbFuncY;
        private System.Windows.Forms.RadioButton rbFuncN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.MaskedTextBox txtDNasc;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtSalario;
    }
}