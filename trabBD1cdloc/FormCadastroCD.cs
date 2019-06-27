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
    public partial class FormCadastroCD : Form
    {
        public FormCadastroCD()
        {
            InitializeComponent();
        }

        private void FormCadastroCD_Load(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
            String CarregaArtista = "SELECT * FROM Artista ORDER BY nome ASC";
            DataTable retornoArt = db.carregaCB(CarregaArtista);
            cbArtista.DataSource = retornoArt;
            cbArtista.DisplayMember = "nome";
            cbArtista.ValueMember = "id_artista";
            cbArtista.Text = "";

            String CarregaGenero = "SELECT * FROM Genero ORDER BY nome ASC";
            DataTable retornoGen = db.carregaCB(CarregaGenero);
            cbGenero.DataSource = retornoGen;
            cbGenero.DisplayMember = "nome";
            cbGenero.ValueMember = "id_gen";
            cbGenero.Text = "";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSaveCD_Click(object sender, EventArgs e)
        {
            if (cbArtista.Text == "" || cbGenero.Text == "" || txtTituloCD.Text == "" || txtAno.Text == "")
            {
               MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //MessageBox.Show(cbArtista.SelectedValue.ToString());
                ConectaDB dB = new ConectaDB();
                String QueryInsereCD = "INSERT INTO CDs values ((SELECT MAX(id_cd)+1 FROM CDs), '" + txtTituloCD.Text.ToUpper() + "','" + txtAno.Text + "'," + qtdestoque.Value + ")";
                String QueryInsereRelacionamento = "INSERT INTO Inclui values ((SELECT MAX(id_cd) FROM CDs)," + cbArtista.SelectedValue + ")" +
                                                   "INSERT INTO CDGenero values ((SELECT MAX(id_cd) FROM CDs)," + cbGenero.SelectedValue + ")";
                String retorno = dB.testeInsert(QueryInsereCD);
                
                if (retorno != "")
                {
                    MessageBox.Show("Erro na inserção: " + retorno);
                }
                else
                {
                    string retorno2 = dB.testeInsert(QueryInsereRelacionamento);
                   
                    if (retorno2 != "")
                    {
                        MessageBox.Show("Erro na inserção nas tabelas de relacionamento: " + retorno2);
                    }
                    else
                    {
                        MessageBox.Show("Inserido com sucesso");
                    }
                    txtTituloCD.Text = "";
                    cbArtista.Text = "";
                    cbGenero.Text = "";
                    txtAno.Text = "";
                    qtdestoque.Value = 0;
                    txtTituloCD.Focus();
                }

            }
            /**/
        }
    }
}
