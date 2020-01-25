using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 30;
            Console.WriteLine("número 1: {0}", num1);
            num1 += 10;
            Console.WriteLine("número 1: {0}", num1);
            num1 -= 24;
            Console.WriteLine("número 1: {0}", num1);
            num1 *= 3;
            Console.WriteLine("número 1: {0}", num1);
            num1 /= 2;
            Console.WriteLine("número 1: {0}", num1);

            int a = 1;
            int b = a;
            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b = a : {0}", b);

            a++;
            Console.WriteLine("a++ : {0}", a);
            Console.WriteLine("b = a : {0}", b);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            Console.WriteLine("c.nome: {0}", c.nome);
            dynamic d = c;
            d.nome = "Maria";
            Console.WriteLine("d.nome: {0}", d.nome);
            Console.WriteLine("c.nome: {0}", c.nome);
        }
    }
}
