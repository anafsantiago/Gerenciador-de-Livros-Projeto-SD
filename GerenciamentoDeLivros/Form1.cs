using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeLivros
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btnInicioPesquisar_Click(object sender, EventArgs e)
        {
            PaginaPesquisa abrirPagPesquisa = new PaginaPesquisa();
            abrirPagPesquisa.ShowDialog();
        }

        private void bntInicioAdicionar_Click(object sender, EventArgs e)
        {
            PaginaAdicionar abrirPagAdicionar = new PaginaAdicionar();
            abrirPagAdicionar.ShowDialog();
        }

        private void btnInicioExcluir_Click(object sender, EventArgs e)
        {
            PaginaExcluir abrirPagExcluir = new PaginaExcluir();
            abrirPagExcluir.ShowDialog();
        }
    }
}
