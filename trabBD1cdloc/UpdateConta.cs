using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabBD1cdloc
{
    public partial class UpdateConta : Form
    {
        public UpdateConta()
        {
            InitializeComponent();
        }

        private void BtnDeleta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir essa conta?", "Excluir Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ConectaDB db = new ConectaDB();
                String QueryDeleta = "DELETE FROM Pessoa_Cliente_Funcionario WHERE cpf = '" + txtCPFDelete.Text + "'";
                String exclui = db.testeInsert(QueryDeleta);
                if (exclui == "")
                    MessageBox.Show("Excluida com sucesso");
                else
                    MessageBox.Show("Erro na exclusão: " + exclui);
            }
            else
            {
                
                txtCPFDelete.Text = "";
                txtCPFDelete.Focus();
            }
        }

        private void TxtUpCEP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUpCEP.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtUpCEP.Text = txtUpCEP.Text.Remove(txtUpCEP.Text.Length - 1);
            }
        }

        private void TxtUpCPF_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUpCPF.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtUpCPF.Text = txtUpCPF.Text.Remove(txtUpCPF.Text.Length - 1);
            }
        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCPF.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtCPF.Text = txtCPF.Text.Remove(txtCPF.Text.Length - 1);
            }
        }

        private void TxtUpCTPS_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUpCTPS.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtUpCTPS.Text = txtUpCTPS.Text.Remove(txtUpCTPS.Text.Length - 1);
            }
        }

        private void TxtCPFDelete_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCPFDelete.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtCPFDelete.Text = txtCPFDelete.Text.Remove(txtCPFDelete.Text.Length - 1);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
           
                int FlagEntrou = 0;
                String QueryAtualiza = "UPDATE Pessoa_Cliente_Funcionario SET ";
                if (txtUpCPF.Text != "")  
                {
                    if (FlagEntrou == 1)
                    {
                        QueryAtualiza += ",";
                    }
                        FlagEntrou = 1;
                        QueryAtualiza += "cpf = '" + txtUpCPF.Text.ToUpper() + "'";
                }
                if (txtUpNome.Text != "")
                {
                    if (FlagEntrou == 1)
                    {
                        QueryAtualiza += ",";
                    }
                    FlagEntrou = 1;
                    QueryAtualiza += "nome = '" + txtUpNome.Text.ToUpper() + "'";
                }
            if (txtUpDNasc.Text != "__/__/____")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "dt_nasc = '" + txtUpDNasc.Text.ToUpper() + "'";
            }
            if (cbUpSexo.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "sexo = '" + cbUpSexo.Text.ToUpper() + "'";
            }
            if (txtUpCEP.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "cep = '" + txtUpCEP.Text.ToUpper() + "'";
            }
            if (txtUpRua.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "rua = '" + txtUpRua.Text.ToUpper() + "'";
            }
            if (txtUpNum.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "num = '" + txtUpNum.Text.ToUpper() + "'";
            }
            if (txtUpBairro.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "bairro = '" + txtUpNum.Text.ToUpper() + "'";
            }

            if (txtUpCidade.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "cidade = '" + txtUpCidade.Text.ToUpper() + "'";
            }

            if (txtUpUF.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "estado = '" + txtUpUF.Text.ToUpper() + "'";
            }

            if (txtUpCTPS.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "cpts = '" + txtUpCTPS.Text + "'";
            }

            if (nupSalario.Value != 0)
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "salario = '" + nupSalario.Value.ToString() + "'";
            }

            if (cbUpTurno.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "turno = '" + cbUpTurno.Text.ToUpper() + "'";
            }
            if(txtUpFuncao.Text != "")
            {
                if (FlagEntrou == 1)
                {
                    QueryAtualiza += ",";
                }
                FlagEntrou = 1;
                QueryAtualiza += "funcao = '" + txtUpFuncao.Text.ToUpper() + "'";
            }

            QueryAtualiza += " WHERE cpf = '" + txtCPF.Text + "'";

            if (QueryAtualiza == "UPDATE Pessoa_Cliente_Funcionario SET  WHERE cpf = '" + txtCPF.Text + "'")
                MessageBox.Show("Preencha pelo menos um campo");
            else
            {
                MessageBox.Show(QueryAtualiza);
                String atualiza = db.testeInsert(QueryAtualiza);
                 if (atualiza == "")
                 {
                     MessageBox.Show("Alterada com sucesso");
                    btnUpdate.Enabled = false;
                    txtCPF.Enabled = true;
                    btnConfirma.Enabled = true;
                    txtUpCPF.Enabled = false;
                    txtUpNome.Enabled = false;
                    txtUpDNasc.Enabled = false;
                    cbUpSexo.Enabled = false;
                    txtUpCEP.Enabled = false;
                    txtUpRua.Enabled = false;
                    txtUpNum.Enabled = false;
                    txtUpBairro.Enabled = false;
                    txtUpCidade.Enabled = false;
                    txtUpUF.Enabled = false;
                    txtUpCTPS.Enabled = false;
                    cbUpTurno.Enabled = false;
                    nupSalario.Enabled = false;
                    txtUpFuncao.Enabled = false;
                    txtCPF.Text = "";
                    txtUpCPF.Text = "";
                    txtUpNome.Text = "";
                    txtUpDNasc.Text = "";
                    cbUpSexo.Text = "";
                    txtUpCEP.Text = "";
                    txtUpRua.Text = "";
                    txtUpNum.Text = "";
                    txtUpBairro.Text = "";
                    txtUpCidade.Text = "";
                    txtUpUF.Text = "";
                    txtUpCTPS.Text = "";
                    cbUpTurno.Text = "";
                    nupSalario.Value = 0;
                    txtUpFuncao.Text = "";
                    String tabela = "Select * from Pessoa_Cliente_Funcionario";
                    DataTable retorno = db.mostraTabela(tabela);
                    dgvConta.DataSource = retorno;
                    rbAll.Checked = true;
                    txtCPF.Focus();
                    

                }
                 else
                     MessageBox.Show("Erro na Alteração: " + atualiza);
            }
            
        }

        private void UpdateConta_Load(object sender, EventArgs e)
        {
            txtUpCPF.Enabled = false;
            txtUpNome.Enabled = false;
            txtUpDNasc.Enabled = false;
            cbUpSexo.Enabled = false;
            txtUpCEP.Enabled = false;
            txtUpRua.Enabled = false;
            txtUpNum.Enabled = false;
            txtUpBairro.Enabled = false;
            txtUpCidade.Enabled = false;
            txtUpUF.Enabled = false;
            txtUpCTPS.Enabled = false;
            cbUpTurno.Enabled = false;
            nupSalario.Enabled = false;
            txtUpFuncao.Enabled = false;
            btnUpdate.Enabled = false;
            rbAll.Checked = true;
            gbFuncionario.Hide();
            ConectaDB dB = new ConectaDB();
            String tabela = "Select * from Pessoa_Cliente_Funcionario";
            DataTable retorno = dB.mostraTabela(tabela);
            dgvConta.DataSource = retorno;


        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
            String campoCPF = txtCPF.Text.ToUpper();
            String SelectArtista = "SELECT nome FROM Pessoa_Cliente_Funcionario WHERE cpf = '" + campoCPF + "'";
            String consulta = db.testeCon(SelectArtista);
            if (consulta != "")
            {
                MessageBox.Show("CPF Encontrado");
                btnUpdate.Enabled = true;
                txtCPF.Enabled = false;
                btnConfirma.Enabled = false;
                txtUpCPF.Enabled = true;
                txtUpNome.Enabled = true;
                txtUpDNasc.Enabled = true;
                cbUpSexo.Enabled = true;
                txtUpCEP.Enabled = true;
                txtUpRua.Enabled = true;
                txtUpNum.Enabled = true;
                txtUpBairro.Enabled = true;
                txtUpCidade.Enabled = true;
                txtUpUF.Enabled = true;
                txtUpCTPS.Enabled = true;
                cbUpTurno.Enabled = true;
                nupSalario.Enabled = true;
                txtUpFuncao.Enabled = true;
            }
            else
            {
                MessageBox.Show("CPF Não Encontrado");
                btnUpdate.Enabled = false;
                txtCPF.Enabled = true;
                btnConfirma.Enabled = true;
                txtUpCPF.Enabled = false;
                txtUpNome.Enabled = false;
                txtUpDNasc.Enabled = false;
                cbUpSexo.Enabled = false;
                txtUpCEP.Enabled = false;
                txtUpRua.Enabled = false;
                txtUpNum.Enabled = false;
                txtUpBairro.Enabled = false;
                txtUpCidade.Enabled = false;
                txtUpUF.Enabled = false;
                txtUpCTPS.Enabled = false;
                cbUpTurno.Enabled = false;
                nupSalario.Enabled = false;
                txtUpFuncao.Enabled = false;
            }

            String SelectFunCli = "SELECT ctps FROM Pessoa_Cliente_Funcionario WHERE cpf = '" + campoCPF + "'";
            string verificaFunCli = db.consultaClienteFuncionario(SelectFunCli);
            if(verificaFunCli == "")
            {
                txtUpCTPS.Enabled = false;
                cbUpTurno.Enabled = false;
                nupSalario.Enabled = false;
                txtUpFuncao.Enabled = false;
                gbFuncionario.Hide();
            }
            else
            {
                txtUpCTPS.Enabled = true;
                cbUpTurno.Enabled = true;
                nupSalario.Enabled = true;
                txtUpFuncao.Enabled = true;
                gbFuncionario.Show();
            }
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            txtCPF.Enabled = true;
            btnConfirma.Enabled = true;
            txtUpCPF.Enabled = false;
            txtUpNome.Enabled = false;
            txtUpDNasc.Enabled = false;
            cbUpSexo.Enabled = false;
            txtUpCEP.Enabled = false;
            txtUpRua.Enabled = false;
            txtUpNum.Enabled = false;
            txtUpBairro.Enabled = false;
            txtUpCidade.Enabled = false;
            txtUpUF.Enabled = false;
            txtUpCTPS.Enabled = false;
            cbUpTurno.Enabled = false;
            nupSalario.Enabled = false;
            txtUpFuncao.Enabled = false;
            txtCPF.Text = "";
            txtUpCPF.Text = "";
            txtUpNome.Text = "";
            txtUpDNasc.Text = "";
            cbUpSexo.Text = "";
            txtUpCEP.Text = "";
            txtUpRua.Text = "";
            txtUpNum.Text = "";
            txtUpBairro.Text = "";
            txtUpCidade.Text = "";
            txtUpUF.Text = "";
            txtUpCTPS.Text = "";
            cbUpTurno.Text = "";
            nupSalario.Value = 0;
            txtUpFuncao.Text = "";
            txtCPF.Focus();
        }

        private void RbFunc_CheckedChanged(object sender, EventArgs e)
        {
            ConectaDB dB = new ConectaDB();
            String tabela = "Select * from Pessoa_Cliente_Funcionario where ctps != ''";
            DataTable retorno = dB.mostraTabela(tabela);
            dgvConta.DataSource = retorno;
        }

        private void RbCliente_CheckedChanged(object sender, EventArgs e)
        {
            ConectaDB dB = new ConectaDB();
            String tabela = "Select * from Pessoa_Cliente_Funcionario where ctps = ''";
            DataTable retorno = dB.mostraTabela(tabela);
            dgvConta.DataSource = retorno;
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            ConectaDB dB = new ConectaDB();
            String tabela = "Select * from Pessoa_Cliente_Funcionario";
            DataTable retorno = dB.mostraTabela(tabela);
            dgvConta.DataSource = retorno;
        }

        
    }
}
