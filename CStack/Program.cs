using System;
using System.Collections.Generic;
using static CQueue.Program;

namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Pilha!");

            Stack<Pessoa> stack = new Stack<Pessoa>();

            stack.Push(new Pessoa("Fabio", "Bruxelas", 36));
            stack.Push(new Pessoa("Amanda", "Rio", 49));
            stack.Push(new Pessoa("Thaina", "Barcelona", 12));
            stack.Push(new Pessoa("Gabriel", "Tokio", 30));

            Console.WriteLine($"Quantidade de pessoasl: {stack.Count}");

            Console.WriteLine($"Primeira pessoa do topo: {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Primeira pessoa do topo: {stack.Peek()}");

            foreach (var item in stack)
            {
                Console.WriteLine($"{item.ToString()}");

            }
        }
    }
}
