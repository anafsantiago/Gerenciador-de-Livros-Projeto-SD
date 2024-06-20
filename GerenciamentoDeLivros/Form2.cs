using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GerenciadorLivros2.Models;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using MongoDB.Driver;
using System.Collections.ObjectModel;

namespace GerenciamentoDeLivros
{
    public partial class PaginaAdicionar : Form
    {
        private const string isbnUrl = "https://www.googleapis.com/books/v1/volumes?q=isbn:{0}";

        public PaginaAdicionar()
        {
            InitializeComponent();
        }

        private async void btnIncluirAdicionar_Click(object sender, EventArgs e)
        {
            string isbn = txtAdicionar.Text.Trim();

            if (!string.IsNullOrWhiteSpace(isbn))
            {
                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        string url = string.Format(isbnUrl, isbn);

                        HttpResponseMessage response = await httpClient.GetAsync(url);
                        response.EnsureSuccessStatusCode();

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync(); // Sempre que houver um método "Async", coloca-se um await antes

                            // Verificar se existem itens ao retornar da API
                            if (responseBody.Contains("\"totalItems\": 0"))
                            {
                                MessageBox.Show($"ISBN inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Desserializa JSON para um objeto Livro
                                Livro livro = JsonConvert.DeserializeObject<Livro>(responseBody);

                                #region Gravar o resultado JSON (Livro) no banco de dados (Mongo DB)

                                IMongoCollection<Livro> collection = Conexao.GetConectarMongoDB_Livro();

                                string caminho = "Items.VolumeInfo.IndustryIdentifiers.Identifier";
                                FilterDefinition<Livro> filter;
                                Livro existeLivro = Conexao.GetFilterDB(isbn, caminho, out filter);

                                if (existeLivro != null)
                                {
                                    // Atualizar o livro (dados) na coleção
                                    await collection.ReplaceOneAsync(filter, livro);
                                    MessageBox.Show($"Livro já existente. Apenas atualizado no banco de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    // Incluir o livro (dados) na coleção
                                    await collection.InsertOneAsync(livro);
                                    MessageBox.Show($"Livro adicionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                #endregion
                            }
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            MessageBox.Show($"Não Encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            MessageBox.Show($"Não Autorizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (response.StatusCode == HttpStatusCode.Forbidden)
                        {
                            MessageBox.Show($"Proibido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            MessageBox.Show($"BadRequest.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Erro na requisição HTTP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtAdicionar.Clear();
                }
            }
            else
            {
                MessageBox.Show($"Por favor, insira um ISBN válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
