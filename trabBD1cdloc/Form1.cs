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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConectaDB db = new ConectaDB();
           
         }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.Show();
        }

        private void BtnCadArtGen_Click(object sender, EventArgs e)
        {
            FormCadArtistaGenero cadArtistaGenero = new FormCadArtistaGenero();
            cadArtistaGenero.Show();

        }

        private void BtnCadastroCD_Click(object sender, EventArgs e)
        {
            FormCadastroCD cadastroCD = new FormCadastroCD();
            cadastroCD.Show();
        }

        private void BtnAltExcConta_Click(object sender, EventArgs e)
        {
            UpdateConta conta = new UpdateConta();
            conta.Show();

        }

        private void BtnAlugar_Click(object sender, EventArgs e)
        {
            AlugaCD aluga = new AlugaCD();
            aluga.Show();
        }
    }
}
