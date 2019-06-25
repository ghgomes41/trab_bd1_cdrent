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
    public partial class FormCadastro : Form
    {
       
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            rbFuncN.Checked = true;
            groupBoxFuncionario.Hide();
        }


        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCPF.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtCPF.Text = txtCPF.Text.Remove(txtCPF.Text.Length - 1);
            }
        }

        private void TxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCEP.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtCEP.Text = txtCEP.Text.Remove(txtCEP.Text.Length - 1);
            }
        }

        private void RbFuncY_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFuncY.Checked)
            {
                groupBoxFuncionario.Show();
            }
            else
            {
                groupBoxFuncionario.Hide();
            }
        }

       
        private void TxtCTPS_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCTPS.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, insira apenas os números.");
                txtCTPS.Text = txtCTPS.Text.Remove(txtCTPS.Text.Length - 1);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
            String SaveQuery = "INSERT INTO Pessoa_Cliente_Funcionario values ('" + txtCPF.Text + "','" + txtDNasc.Text + "','" +
                txtNome.Text + "','" + cbSexo.Text + "','" + txtCEP.Text + "','" + txtRua.Text + "','" + txtNum.Text + "','" +
                txtBairro.Text + "','" + txtCidade.Text + "','" + txtUF.Text + "','" + txtSalario.Text + "','" + cbTurno.Text + "','" +
                txtFuncao.Text + "','" + txtCTPS.Text + "')";
            
                //db.testeInsert(SaveQuery);
            String mensagem = db.testeInsert(SaveQuery);
            if (mensagem != "")
            {
                MessageBox.Show("Erro na inserção: " + mensagem);
            }
            else
            {
                MessageBox.Show("Inserido com sucesso");
                this.Close();
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDNasc.Text = "";
            txtCEP.Text = "";
            txtRua.Text = "";
            txtNum.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtCTPS.Text = "";
            txtSalario.Text = "";
            txtFuncao.Text = "";
            rbFuncY.Checked = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
