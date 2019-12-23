using System;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta;
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (S/N) ?");
            char resposta = char.(Console.ReadLine());

            if (resposta=='s' || resposta=='S')
            {
                Console.Write("Entre com o valor de deposito");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }


        }
    }
}
