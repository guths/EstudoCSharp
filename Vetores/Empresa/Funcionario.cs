using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    public class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id,string nome,double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentaSalario(double porcentagem)
        {
            Salario+=(Salario * porcentagem / 100);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
}
