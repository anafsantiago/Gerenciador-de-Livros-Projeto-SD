using GerenciadorLivros2.Models;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MongoDB.Bson;
using System.Collections.Generic;

namespace GerenciamentoDeLivros
{
    public partial class PaginaPesquisa : Form
    {
        public PaginaPesquisa()
        {
            InitializeComponent();
        }

        private void btnBuscarPesquisar_Click(object sender, EventArgs e)
        {
            IMongoCollection<Livro> collection = Conexao.GetConectarMongoDB_Livro();

            string isbn = txtPesquisarIsbn.Text.Trim();
            string autor = txtPesquisarAutor.Text;
            string titulo = txtPesquisarTitulo.Text;

            // Pesquisar por ISBN
            if (!string.IsNullOrWhiteSpace(isbn))
            {
                try
                {
                    boxPesquisarResultado.Clear();

                    string caminho = "Items.VolumeInfo.IndustryIdentifiers.Identifier";
                    FilterDefinition<Livro> filter;
                    Livro existeLivro = Conexao.GetFilterDB(isbn, caminho, out filter);

                    //Exibe o resultado de retorno do livro no componente de texto

                    if (existeLivro != null)
                    {
                        Exibir_Dados(existeLivro);
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
                txtPesquisarIsbn.Clear();
                txtPesquisarTitulo.Enabled = true;
                txtPesquisarAutor.Enabled = true;
            }
            else if (!string.IsNullOrWhiteSpace(autor))
            {
                try
                {
                    boxPesquisarResultado.Clear();

                    string autorNormalizado = NormalizarString(autor);
                    var campoAutorNormalizado = new BsonRegularExpression(autorNormalizado, "i");
                    var caminho = "Items.VolumeInfo.Authors";

                    FilterDefinition<Livro> filter;
                    List<Livro> existeLivro = Conexao.GetFilterDBLista(campoAutorNormalizado, caminho, out filter);

                    //Exibe o resultado de retorno do livro no componente de texto

                    if (existeLivro != null && existeLivro.Count() > 0)
                    {
                        foreach (var livro in existeLivro)
                        {
                            Exibir_Dados(livro);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Autor não encontrado no banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtPesquisarAutor.Clear();
                    txtPesquisarIsbn.Enabled = true;
                    txtPesquisarTitulo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao consumir os dados do MongoDB: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrWhiteSpace(titulo))
            {
                try
                {
                    boxPesquisarResultado.Clear();

                    string tituloNormalizado = NormalizarString(titulo);
                    var campoTituloNormalizado = new BsonRegularExpression(tituloNormalizado, "i");
                    var caminho = "Items.VolumeInfo.Title";

                    FilterDefinition<Livro> filter;
                    List<Livro> existeLivro = Conexao.GetFilterDBLista(campoTituloNormalizado, caminho, out filter);

                    // Exibir os resultados dos livros encontrados
                    if (existeLivro != null && existeLivro.Count > 0)
                    {
                        foreach (var livro in existeLivro)
                        {
                            Exibir_Dados(livro);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Título não encontrado no banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtPesquisarTitulo.Clear();
                    txtPesquisarIsbn.Enabled = true;
                    txtPesquisarAutor.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao consumir os dados do MongoDB: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                boxPesquisarResultado.Clear();
                MessageBox.Show("Por favor, digite uma informação válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exibir_Dados(Livro existeLivro)
        {
            boxPesquisarResultado.AppendText($"\n");
            foreach (var identifier_isbn in existeLivro.Items[0].VolumeInfo.IndustryIdentifiers)
            {
                boxPesquisarResultado.AppendText($"{identifier_isbn.Type}: {identifier_isbn.Identifier} \n");
            }

            boxPesquisarResultado.AppendText($"Título: {existeLivro.Items[0].VolumeInfo.Title}\n");
            boxPesquisarResultado.AppendText($"Autor: ");
            foreach (var autores in existeLivro.Items[0].VolumeInfo.Authors)
            {
                boxPesquisarResultado.AppendText($"{autores}, ");
            }
            boxPesquisarResultado.AppendText($"\n");
            boxPesquisarResultado.AppendText($"Descrição: {existeLivro.Items[0].VolumeInfo.Description}\n");
            boxPesquisarResultado.AppendText($"\n--- FIM DO LIVRO ---\n");
        }

        static string NormalizarString(string texto)
        {
            // Remover espaços adicionais
            texto = Regex.Replace(texto, @"\s+", " ").Trim();
            return texto;
        }

        private void txtPesquisarIsbn_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarTitulo.Enabled = false;
            txtPesquisarAutor.Enabled = false;
        }

        private void txtPesquisarTitulo_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarIsbn.Enabled = false;
            txtPesquisarAutor.Enabled = false;
        }

        private void txtPesquisarAutor_TextChanged(object sender, EventArgs e)
        {
            txtPesquisarIsbn.Enabled = false;
            txtPesquisarTitulo.Enabled = false;
        }
    }
}
