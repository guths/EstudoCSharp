using System;
using System.IO;

namespace ManipulaçãoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\EstudoCSharp\file1.txt"; //Esse arroba deixa escrever com apenas uma contra barra
            string targetPath = @"c:\EstudoCSharp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException erro)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(erro.Message);
            }

        }
    }
}
