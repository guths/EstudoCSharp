using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome,string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;         
        }
    }
}
