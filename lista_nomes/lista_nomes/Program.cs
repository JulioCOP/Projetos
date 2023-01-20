using System;
using System.IO;
using System.Collections.Generic;


namespace lista_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\Curso POO C#\Projetos\lista_nomes\in.txt"; //informando um caminho (hardcode)

            try
            {
                using (StreamReader sr = File.OpenText(path))  // Comando para abri o arquivo
                {
                    List<string> lista = new List<string>(); // Lista criada
                    while (!sr.EndOfStream) // Durante o caminho a ser percorrido até o final da lista
                    {
                        lista.Add(sr.ReadLine()); // Lido e adicionado o nome do arquivo txt na lista criada
                    }
                    // Ordenar a lista criada
                    lista.Sort();
                    foreach (string str in lista)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}