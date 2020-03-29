using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Produto1", 10.0);
            var p2 = new Produto("Produto1", 10.0);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p2 == p3);

            Console.WriteLine(p1.Equals(p2));


        }
    }
}
