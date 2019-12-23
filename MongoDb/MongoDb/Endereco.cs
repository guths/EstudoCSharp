using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDb
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Numero { get; set; }
    }
}
