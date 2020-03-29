using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("primeiro");
            fila.Enqueue("segundo");
            fila.Enqueue("terceiro");
            fila.Enqueue("quarto");
            fila.Enqueue("quinto");
            fila.Enqueue("sexto");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }


            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue(true);
            salada.Enqueue("palavra");

            foreach (var item in salada)
            {
                Console.WriteLine(item);
            }

        }
    }
}
