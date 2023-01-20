using System;
using System.IO;
using System.Collections.Generic;
using lista_nomes.Entities;


namespace lista_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\Curso POO C#\Projetos\lista_nomes\in.txt"; //informando um caminho (hardcode)

            try
            {
                using (StreamReader sr = File.OpenText(path))  // Comando para abrir o arquivo
                {
                    List<Players> lista = new List<Players>(); // Lista criada
                    while (!sr.EndOfStream) // Durante o caminho a ser percorrido até o final da lista
                    {
                        lista.Add(new Players(sr.ReadLine())); // Lido e adicionado o nome do arquivo txt na lista criada
                    }
                    // Ordenar a lista criada
                    lista.Sort();
                    foreach (Players player in lista)
                    {
                        Console.WriteLine(player);
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