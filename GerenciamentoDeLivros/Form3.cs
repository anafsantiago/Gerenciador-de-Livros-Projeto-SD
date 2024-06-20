using GerenciadorLivros2.Models;
using MongoDB.Driver;
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
    public partial class PaginaExcluir : Form
    {
        public PaginaExcluir()
        {
            InitializeComponent();
        }

        private async void btnDeletarExcluir_Click(object sender, EventArgs e)
        {
            string isbn = txtExcluir.Text.Trim();

            if (!string.IsNullOrWhiteSpace(isbn))
            {
                try
                {
                    IMongoCollection<Livro> collection = Conexao.GetConectarMongoDB_Livro();

                    string caminho = "Items.VolumeInfo.IndustryIdentifiers.Identifier";
                    FilterDefinition<Livro> filter;
                    Livro existeLivro = Conexao.GetFilterDB(isbn, caminho, out filter);

                    if (existeLivro != null)
                    {
                        await collection.DeleteOneAsync(filter);
                        MessageBox.Show($"Livro deletado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"ISBN não encontrado no banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao consumir os dados do MongoDB: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtExcluir.Clear();
            }
            else
            {
                MessageBox.Show($"Por favor, insira um ISBN válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
