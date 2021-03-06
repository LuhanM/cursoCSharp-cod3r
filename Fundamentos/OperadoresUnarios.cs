﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;
            Console.WriteLine("valorNegativo {0}", valorNegativo);
            Console.WriteLine("numero1 {0}", numero1);
            Console.WriteLine("numero2 {0}", numero2);
            Console.WriteLine("booleano {0}", booleano);

            Console.WriteLine("-valorNegativo {0}", -valorNegativo);
            Console.WriteLine("!booleano {0}", !booleano);

            //Exemplo de operador pré-fixado e pós-fixado
            Console.WriteLine($"numero1++ == numero2: {numero1++ == numero2}");

            Console.WriteLine("numero1 {0}", numero1);
            Console.WriteLine("numero2 {0}", numero2);

            numero1 = 2;
            Console.WriteLine($"++numero1 == numero2: {++numero1 == numero2}");
            Console.WriteLine("numero1 {0}", numero1);
            Console.WriteLine("numero2 {0}", numero2);
        }
    }
}
