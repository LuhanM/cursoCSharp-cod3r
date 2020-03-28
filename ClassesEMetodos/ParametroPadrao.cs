﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a= 1, int b = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(3));
            Console.WriteLine(Somar(2,3));
            Console.WriteLine(Somar(b: 5));
        }
    }
}
