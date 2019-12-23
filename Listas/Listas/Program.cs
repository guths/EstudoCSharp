using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();

            //List<string> list2 = new List<string>() { "Maria", "Joao" };

            List<string> list = new List<string>();


            list.Add("Maria");
            list.Add("Jose");
            list.Add("Anna");
            list.Insert(3, "Luis");
            list.Count();

            //Primeira e ultima ocorrencia com nome com a letra a 

            string s1 = list.Find(x => x[0] == 'A');
            string s2 = list.FindLast(x => x[0] == 'A');

            






            


        }
    }
}
