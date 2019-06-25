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
    public partial class FormCadArtistaGenero : Form
    {
        public FormCadArtistaGenero()
        {
            InitializeComponent();
        }

        private void BtnVerificaGen_Click(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
            String campoNome = txtNomeGenero.Text.ToUpper();
            String SelectGenero = "SELECT nome FROM Genero WHERE nome = '" +campoNome+"'";
            String consulta = db.testeCon(SelectGenero);
            if (consulta != "")
            {
                MessageBox.Show("Genero ja cadastrado");
                btnSaveGen.Enabled = false;
            }
            else
            {
                MessageBox.Show("Genero nao cadastrado, tudo certo");
                btnSaveGen.Enabled = true;
            }
        }

        private void BtnVerificaArt_Click(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
            String campoNome = txtNomeArtista.Text.ToUpper();
            String SelectArtista = "SELECT nome FROM Artista WHERE nome = '" + campoNome + "'";
            String consulta = db.testeCon(SelectArtista);
            if (consulta != "")
            {
                MessageBox.Show("Artista ja cadastrado");
                btnSaveArt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Artista nao cadastrado, tudo certo");
                btnSaveArt.Enabled = true;
            }
        }

        private void BtnSaveArt_Click(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
            String SaveArtQuery = "INSERT INTO Artista values ((SELECT MAX (id_artista)+1 FROM Artista), '" + txtNomeArtista.Text.ToUpper()+ "')";
            String retorno = db.testeInsert(SaveArtQuery);
            if (retorno != "")
            {
                MessageBox.Show("Erro na inserção: " + retorno);
            }
            else
            {
                MessageBox.Show("Inserido com sucesso");
                txtNomeArtista.Text = "";
                txtNomeGenero.Text = "";
                btnSaveArt.Enabled = false;
                btnSaveGen.Enabled = false;
            }
        }

        private void FormCadArtistaGenero_Load(object sender, EventArgs e)
        {
            btnSaveArt.Enabled = false;
            btnSaveGen.Enabled = false;
        }

        private void BtnSaveGen_Click(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
            String SaveGenQuery = "INSERT INTO Genero (id_gen,nome) values ((SELECT MAX (id_gen)+1 FROM Genero), '" + txtNomeGenero.Text.ToUpper() + "')";
            String retorno = db.testeInsert(SaveGenQuery);
            if (retorno != "")
            {
                MessageBox.Show("Erro na inserção: " + retorno);
            }
            else
            {
                MessageBox.Show("Inserido com sucesso");
                txtNomeArtista.Text = "";
                txtNomeGenero.Text = "";
                btnSaveArt.Enabled = false;
                btnSaveGen.Enabled = false;
            }
        }
    }
}
