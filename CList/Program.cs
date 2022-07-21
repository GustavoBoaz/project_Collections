using System;
using System.Collections.Generic;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Lista");

            List<string> lista = new List<string>();

            lista.Add("Matheus");
            lista.Add("Maju");
            lista.Add("Felipe");

            lista.Insert(1, "Rafael");

            lista.Remove("Maju");

            lista.RemoveAt(2);

            foreach (string nome in lista)
            {
                Console.WriteLine($"Aqui esta a Pessoa: {nome}");
            }
        }
    }
}
