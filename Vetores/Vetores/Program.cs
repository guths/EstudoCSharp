using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa[] vetorestudante = new Pessoa[10];

            Console.Write("Quantos quartos serão alugados");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetorestudante[quarto] = new Pessoa(nome, email);

            }

           


        }
    }
}
