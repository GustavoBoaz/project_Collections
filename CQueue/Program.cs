using System;
using System.Collections;
using System.Collections.Generic;

namespace CQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Fila");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Jessuss", "Las Vegas", 33));
            pessoas.Enqueue(new Pessoa("Israel", "Jerusalem", 45));
            pessoas.Enqueue(new Pessoa("Nick", "Amsterdan", 25));

            Console.WriteLine($"Object primeiro da fila é: {pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"O numero de pessoas na Fila é: {pessoas.Count}");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }

        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public string Cidade { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, string cidade, int idade)
            {
                Nome = nome;
                Cidade = cidade;
                Idade = idade;
            }

            public override string ToString()
            {
                return $"Nome: {Nome} | Cidade: {Cidade} | Idade: {Idade}";
            }
        }
    }
}
