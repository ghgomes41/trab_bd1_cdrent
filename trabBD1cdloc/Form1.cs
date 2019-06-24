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
    }
}
