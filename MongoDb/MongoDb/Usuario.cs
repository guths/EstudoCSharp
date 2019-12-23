using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDb
{
    class Usuario
    {
        public ObjectId _id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public Endereco Endereco { get; set; }


        public override string ToString()
        {
            return $"Usuario: {Login}| Status : {(Ativo ? "Ativo" : "Inativo")}";
        }
    }
}
