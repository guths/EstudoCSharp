using System;
using System.Collections.Generic;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionários você quer registrar ?");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < numeroFuncionarios; i++)
            {
                Console.WriteLine($"Funcionario #{i}:");

                
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Id: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario(id,nome,salario));

            }

            Console.WriteLine("Digite o id do funcionario parar aumentar o salario: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionarioPromovido = funcionarios.Find(x => x.Id == idFuncionario);

            if (funcionarioPromovido!=null)
            {
                Console.WriteLine("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                funcionarioPromovido.AumentaSalario(porcentagem);

            }
            else
            {
                Console.WriteLine("Esse id não existe");
            }








        }
    }
}
