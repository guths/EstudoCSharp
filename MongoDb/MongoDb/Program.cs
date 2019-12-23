using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace MongoDb
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var settings = new MongoClientSettings
                {
                    ServerSelectionTimeout = new TimeSpan(0, 0, 5),
                    Server = new MongoServerAddress("localhost", 27017)
                };
                var client = new MongoClient(settings);
                //Instancia de conexao com o banco de dados

                var database = client.GetDatabase("loja");
                //Nome do banco de dados que queremos pegar
                //Se nao existir ele é criado


                var colecao = database.GetCollection<Usuario>("usuarios");
                //Colecoes sao iguais tabelas 
                //Se nao existir ele é criado

                //var filtro = Builders<Usuario>.Filter.Eq(u => u.Login, "Joel");
                //Classe builders herda de MongoDbDriver e é tipada como usuario, assim dispoe de varios filtros para consultar o banco
                //var alteracao = Builders<Usuario>.Update.Set(u => u.Login, "senhanova123");
                //colecao.UpdateOne(filtro, alteracao);

                //var filtro = Builders<Usuario>.Filter.Empty;
                //var alteracao = Builders<Usuario>.Update.Set(u => u.Ativo, false);

                //colecao.UpdateMany(filtro, alteracao);

                var filtro = Builders<Usuario>.Filter.Empty;

                var usuarios = colecao.Find(filtro).ToList();

                usuarios.ForEach(u => Console.WriteLine(u));


                //var usuarios = new List<Usuario>
                //{
                //    new Usuario
                //    {
                //        Login="jonathan",
                //        Senha="120"
                //    },
                //    new Usuario
                //    {
                //        Login="diego",
                //        Senha="712"
                //    }
                //};

                //colecao.InsertMany(usuarios);
                //Console.WriteLine("Sucesso");



            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
