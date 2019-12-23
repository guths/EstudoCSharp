using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int produtos)
        {
            Quantidade += produtos;
        }

        public void RemoverProdutos(int produtos)
        {
            Quantidade -= produtos;
        }




    }

}
