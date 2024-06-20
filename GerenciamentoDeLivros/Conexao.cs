using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorLivros2.Models
{
    public static class Conexao
    {
        // Método para conectar ao MongoDB e obter a coleção de livros
        private static IMongoCollection<Livro> ConectarMongoDB_Livro()
        {
            // Faz a conexão com o MongoDB
            var client = new MongoClient("mongodb://localhost:27017/");

            // Cria um novo DB
            var database = client.GetDatabase("DBLIVRO");

            // Cria uma coleção (tabela) no BD "DBLIVRO"
            var collection = database.GetCollection<Livro>("Livro");
            return collection;
        }

        // Método para filtrar e retornar um único livro
        private static Livro FilterDB(string campo, IMongoCollection<Livro> collection, string caminho, out FilterDefinition<Livro> filter)
        {
            filter = Builders<Livro>.Filter.Eq(caminho, campo);
            var projection = Builders<Livro>.Projection.Exclude("_id");
            return collection.Find(filter).Project<Livro>(projection).FirstOrDefault();
        }

        // Método para filtrar e retornar uma lista de livros
        private static List<Livro> FilterDBLista<T>(T campo, IMongoCollection<Livro> collection, string caminho, out FilterDefinition<Livro> filter)
        {
            if (campo is BsonRegularExpression regexCampo)
            {
                filter = Builders<Livro>.Filter.Regex(caminho, regexCampo);
                var projection = Builders<Livro>.Projection.Exclude("_id");
                return collection.Find(filter).Project<Livro>(projection).ToList();
            }
            throw new ArgumentException("Tipo de filtro não suportado");
        }

        // Método público para obter a coleção de livros
        public static IMongoCollection<Livro> GetConectarMongoDB_Livro()
        {
            return ConectarMongoDB_Livro();
        }

        // Método público para buscar um único livro filtrado por campo e valor
        public static Livro GetFilterDB(string campo, string caminho, out FilterDefinition<Livro> filter)
        {
            var collection = ConectarMongoDB_Livro();
            return FilterDB(campo, collection, caminho, out filter);
        }


        // Método público para buscar uma lista de livros
        public static List<Livro> GetFilterDBLista<T>(T campo, string caminho, out FilterDefinition<Livro> filter)
        {
            var collection = ConectarMongoDB_Livro();
            return FilterDBLista(campo, collection, caminho, out filter);
        }
    }
}

