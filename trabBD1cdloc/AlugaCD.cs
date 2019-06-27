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
    public partial class AlugaCD : Form
    {
        public AlugaCD()
        {
            InitializeComponent();
        }

        private void AlugaCD_Load(object sender, EventArgs e)
        {
            ConectaDB dB = new ConectaDB();
            String tabela = "SELECT C.id_cd AS 'id', C.nome AS 'Titulo', A.nome AS 'Artista', G.nome AS 'Genero', C.qtd_estoque AS 'Qtd. Disponivel' "
                               + "FROM CDs C "
                               + "JOIN Inclui AS I ON C.id_cd = I.id_cd"
                               + "JOIN Artista AS A ON I.id_artista = A.id_artista "
                               + "JOIN CDGenero AS CDGen ON C.id_cd = CDGen.id_cd "
                               + "JOIN Genero AS G ON CDGen.id_gen = G.id_gen "
                               + "ORDER BY A.nome";
            DataTable retorno = dB.mostraTabela(tabela);
            dgvCDs.DataSource = retorno;
        }
    }
}
