using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
                       
    }
    
    class CalculadoraCadeia
    {
        int memoria;
        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            Console.WriteLine(calculadoraComum.Somar(1, 2));

            var calculadoraCadeia = new CalculadoraCadeia();
            var resultado = calculadoraCadeia.Somar(10).Multiplicar(2).Imprimir().Resultado();
        }
    }
}
