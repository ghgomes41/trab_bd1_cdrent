namespace trabBD1cdloc
{
    partial class UpdateConta
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
            this.dgvConta = new System.Windows.Forms.DataGridView();
            this.gbExcluir = new System.Windows.Forms.GroupBox();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPFDelete = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.txtUpNum = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpUF = new System.Windows.Forms.TextBox();
            this.txtUpCidade = new System.Windows.Forms.TextBox();
            this.txtUpBairro = new System.Windows.Forms.TextBox();
            this.txtUpRua = new System.Windows.Forms.TextBox();
            this.txtUpCEP = new System.Windows.Forms.TextBox();
            this.cbUpSexo = new System.Windows.Forms.ComboBox();
            this.txtUpDNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtUpNome = new System.Windows.Forms.TextBox();
            this.txtUpCPF = new System.Windows.Forms.TextBox();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.nupSalario = new System.Windows.Forms.NumericUpDown();
            this.txtUpFuncao = new System.Windows.Forms.TextBox();
            this.cbUpTurno = new System.Windows.Forms.ComboBox();
            this.txtUpCTPS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFunc = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).BeginInit();
            this.gbExcluir.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConta
            // 
            this.dgvConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConta.Location = new System.Drawing.Point(12, 12);
            this.dgvConta.Name = "dgvConta";
            this.dgvConta.Size = new System.Drawing.Size(776, 175);
            this.dgvConta.TabIndex = 0;
            
            // 
            // gbExcluir
            // 
            this.gbExcluir.Controls.Add(this.btnDeleta);
            this.gbExcluir.Controls.Add(this.label1);
            this.gbExcluir.Controls.Add(this.txtCPFDelete);
            this.gbExcluir.Location = new System.Drawing.Point(478, 246);
            this.gbExcluir.Name = "gbExcluir";
            this.gbExcluir.Size = new System.Drawing.Size(310, 314);
            this.gbExcluir.TabIndex = 1;
            this.gbExcluir.TabStop = false;
            this.gbExcluir.Text = "Excluir Conta:";
            // 
            // btnDeleta
            // 
            this.btnDeleta.Location = new System.Drawing.Point(229, 285);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(75, 23);
            this.btnDeleta.TabIndex = 2;
            this.btnDeleta.Text = "Excluir";
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.BtnDeleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o CPF da Conta que Deseja Excluir:";
            // 
            // txtCPFDelete
            // 
            this.txtCPFDelete.Location = new System.Drawing.Point(6, 76);
            this.txtCPFDelete.MaxLength = 11;
            this.txtCPFDelete.Name = "txtCPFDelete";
            this.txtCPFDelete.Size = new System.Drawing.Size(298, 20);
            this.txtCPFDelete.TabIndex = 0;
            this.txtCPFDelete.TextChanged += new System.EventHandler(this.TxtCPFDelete_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancela);
            this.groupBox1.Controls.Add(this.txtUpNum);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtUpUF);
            this.groupBox1.Controls.Add(this.txtUpCidade);
            this.groupBox1.Controls.Add(this.txtUpBairro);
            this.groupBox1.Controls.Add(this.txtUpRua);
            this.groupBox1.Controls.Add(this.txtUpCEP);
            this.groupBox1.Controls.Add(this.cbUpSexo);
            this.groupBox1.Controls.Add(this.txtUpDNasc);
            this.groupBox1.Controls.Add(this.txtUpNome);
            this.groupBox1.Controls.Add(this.txtUpCPF);
            this.groupBox1.Controls.Add(this.gbFuncionario);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnConfirma);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 314);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Conta:";
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(297, 285);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 24;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // txtUpNum
            // 
            this.txtUpNum.Location = new System.Drawing.Point(401, 121);
            this.txtUpNum.Name = "txtUpNum";
            this.txtUpNum.Size = new System.Drawing.Size(52, 20);
            this.txtUpNum.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(378, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtUpUF
            // 
            this.txtUpUF.Location = new System.Drawing.Point(407, 152);
            this.txtUpUF.MaxLength = 2;
            this.txtUpUF.Name = "txtUpUF";
            this.txtUpUF.Size = new System.Drawing.Size(46, 20);
            this.txtUpUF.TabIndex = 22;
            // 
            // txtUpCidade
            // 
            this.txtUpCidade.Location = new System.Drawing.Point(200, 152);
            this.txtUpCidade.Name = "txtUpCidade";
            this.txtUpCidade.Size = new System.Drawing.Size(157, 20);
            this.txtUpCidade.TabIndex = 21;
            // 
            // txtUpBairro
            // 
            this.txtUpBairro.Location = new System.Drawing.Point(49, 152);
            this.txtUpBairro.Name = "txtUpBairro";
            this.txtUpBairro.Size = new System.Drawing.Size(101, 20);
            this.txtUpBairro.TabIndex = 20;
            // 
            // txtUpRua
            // 
            this.txtUpRua.Location = new System.Drawing.Point(192, 121);
            this.txtUpRua.Name = "txtUpRua";
            this.txtUpRua.Size = new System.Drawing.Size(151, 20);
            this.txtUpRua.TabIndex = 19;
            // 
            // txtUpCEP
            // 
            this.txtUpCEP.Location = new System.Drawing.Point(43, 121);
            this.txtUpCEP.MaxLength = 8;
            this.txtUpCEP.Name = "txtUpCEP";
            this.txtUpCEP.Size = new System.Drawing.Size(107, 20);
            this.txtUpCEP.TabIndex = 18;
            this.txtUpCEP.TextChanged += new System.EventHandler(this.TxtUpCEP_TextChanged);
            // 
            // cbUpSexo
            // 
            this.cbUpSexo.FormattingEnabled = true;
            this.cbUpSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbUpSexo.Location = new System.Drawing.Point(333, 80);
            this.cbUpSexo.Name = "cbUpSexo";
            this.cbUpSexo.Size = new System.Drawing.Size(121, 21);
            this.cbUpSexo.TabIndex = 17;
            // 
            // txtUpDNasc
            // 
            this.txtUpDNasc.Location = new System.Drawing.Point(121, 80);
            this.txtUpDNasc.Mask = "00/00/0000";
            this.txtUpDNasc.Name = "txtUpDNasc";
            this.txtUpDNasc.Size = new System.Drawing.Size(100, 20);
            this.txtUpDNasc.TabIndex = 16;
            this.txtUpDNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtUpDNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtUpNome
            // 
            this.txtUpNome.Location = new System.Drawing.Point(200, 44);
            this.txtUpNome.Name = "txtUpNome";
            this.txtUpNome.Size = new System.Drawing.Size(253, 20);
            this.txtUpNome.TabIndex = 15;
            // 
            // txtUpCPF
            // 
            this.txtUpCPF.Location = new System.Drawing.Point(42, 44);
            this.txtUpCPF.MaxLength = 11;
            this.txtUpCPF.Name = "txtUpCPF";
            this.txtUpCPF.Size = new System.Drawing.Size(108, 20);
            this.txtUpCPF.TabIndex = 14;
            this.txtUpCPF.TextChanged += new System.EventHandler(this.TxtUpCPF_TextChanged);
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.nupSalario);
            this.gbFuncionario.Controls.Add(this.txtUpFuncao);
            this.gbFuncionario.Controls.Add(this.cbUpTurno);
            this.gbFuncionario.Controls.Add(this.txtUpCTPS);
            this.gbFuncionario.Controls.Add(this.label17);
            this.gbFuncionario.Controls.Add(this.label16);
            this.gbFuncionario.Controls.Add(this.label15);
            this.gbFuncionario.Controls.Add(this.label14);
            this.gbFuncionario.Location = new System.Drawing.Point(9, 195);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(445, 83);
            this.gbFuncionario.TabIndex = 13;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionario";
            // 
            // nupSalario
            // 
            this.nupSalario.DecimalPlaces = 2;
            this.nupSalario.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nupSalario.Location = new System.Drawing.Point(270, 14);
            this.nupSalario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupSalario.Name = "nupSalario";
            this.nupSalario.Size = new System.Drawing.Size(120, 20);
            this.nupSalario.TabIndex = 26;
            // 
            // txtUpFuncao
            // 
            this.txtUpFuncao.Location = new System.Drawing.Point(270, 57);
            this.txtUpFuncao.Name = "txtUpFuncao";
            this.txtUpFuncao.Size = new System.Drawing.Size(117, 20);
            this.txtUpFuncao.TabIndex = 25;
            // 
            // cbUpTurno
            // 
            this.cbUpTurno.FormattingEnabled = true;
            this.cbUpTurno.Items.AddRange(new object[] {
            "MANHÃ",
            "TARDE"});
            this.cbUpTurno.Location = new System.Drawing.Point(50, 56);
            this.cbUpTurno.Name = "cbUpTurno";
            this.cbUpTurno.Size = new System.Drawing.Size(94, 21);
            this.cbUpTurno.TabIndex = 23;
            // 
            // txtUpCTPS
            // 
            this.txtUpCTPS.Location = new System.Drawing.Point(50, 13);
            this.txtUpCTPS.MaxLength = 13;
            this.txtUpCTPS.Name = "txtUpCTPS";
            this.txtUpCTPS.Size = new System.Drawing.Size(140, 20);
            this.txtUpCTPS.TabIndex = 23;
            this.txtUpCTPS.TextChanged += new System.EventHandler(this.TxtUpCTPS_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Função:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Turno:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(222, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Salario:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "CTPS:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rua:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(366, 13);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 20);
            this.btnConfirma.TabIndex = 2;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(212, 13);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(129, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.TextChanged += new System.EventHandler(this.TxtCPF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Insira o CPF da conta que deseja Alterar:";
            // 
            // rbFunc
            // 
            this.rbFunc.AutoSize = true;
            this.rbFunc.Location = new System.Drawing.Point(12, 219);
            this.rbFunc.Name = "rbFunc";
            this.rbFunc.Size = new System.Drawing.Size(85, 17);
            this.rbFunc.TabIndex = 3;
            this.rbFunc.TabStop = true;
            this.rbFunc.Text = "Funcionários";
            this.rbFunc.UseVisualStyleBackColor = true;
            this.rbFunc.CheckedChanged += new System.EventHandler(this.RbFunc_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(103, 219);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(62, 17);
            this.rbCliente.TabIndex = 4;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Clientes";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.RbCliente_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(171, 219);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(74, 17);
            this.rbAll.TabIndex = 5;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Ver Todos";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar Contas:";
            // 
            // UpdateConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.rbFunc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbExcluir);
            this.Controls.Add(this.dgvConta);
            this.Name = "UpdateConta";
            this.Text = "UpdateConta";
            this.Load += new System.EventHandler(this.UpdateConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConta)).EndInit();
            this.gbExcluir.ResumeLayout(false);
            this.gbExcluir.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.gbFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConta;
        private System.Windows.Forms.GroupBox gbExcluir;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPFDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFunc;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpUF;
        private System.Windows.Forms.TextBox txtUpCidade;
        private System.Windows.Forms.TextBox txtUpBairro;
        private System.Windows.Forms.TextBox txtUpRua;
        private System.Windows.Forms.TextBox txtUpCEP;
        private System.Windows.Forms.ComboBox cbUpSexo;
        private System.Windows.Forms.MaskedTextBox txtUpDNasc;
        private System.Windows.Forms.TextBox txtUpNome;
        private System.Windows.Forms.TextBox txtUpCPF;
        private System.Windows.Forms.TextBox txtUpFuncao;
        private System.Windows.Forms.ComboBox cbUpTurno;
        private System.Windows.Forms.TextBox txtUpCTPS;
        private System.Windows.Forms.TextBox txtUpNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nupSalario;
        private System.Windows.Forms.Button btnCancela;
    }
}