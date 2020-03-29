using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(pilha.Pop());

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(pilha.Peek());

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
