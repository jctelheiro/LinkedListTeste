using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var ll = new LinkedList<int>(Enumerable.Range(1, 10).ToList());
            var assassino = ll.First;
            ExecutarMatanca(ll, assassino);
            Console.WriteLine("Finalizado");
            Console.ReadKey();

        }

        static void ExecutarMatanca(LinkedList<int> ll, LinkedListNode<int> assassino)
        {
            if (ll.Count > 1) 
            { 
                var vitima = assassino.Next ?? ll.First;
                Console.WriteLine($"{assassino.Value} matou {vitima.Value}");
                var novoAssassino = vitima.Next ?? ll.First;
                ll.Remove(vitima);
                ExecutarMatanca(ll, novoAssassino);
            }
            else
            {
                var suicida = ll.First;
                Console.WriteLine($"{suicida.Value} suicidou-se");
                ll.Remove(suicida);
            }
        }
    }
}
