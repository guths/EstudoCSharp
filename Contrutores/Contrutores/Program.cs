﻿using System;
using System.Globalization;
namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
    

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome=Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


            Produto p2 = new Produto { Nome = "Geladeira", Preco = 321, Quantidade = 232 };
        }
    }
}