using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC
            double peso = 84;
            double altura = 1.79;
            //double imc = peso / (altura * altura);
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}");


            int par = 20;
            int impar = 35;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
