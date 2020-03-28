using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

    }
    class MetodoEstatico
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine(resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(1,1));
        }
    }
}
