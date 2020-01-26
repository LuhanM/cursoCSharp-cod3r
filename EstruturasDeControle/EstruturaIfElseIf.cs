using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            string entrada;

            Console.WriteLine("Digite sua nota: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);
            Console.WriteLine($"Você digitou a nota {nota}");

            bool aprovado = nota >= 7;
            bool quadroDeHonra = nota >= 9;
            bool recuperacao = nota >= 5 && nota < 7;

            if (quadroDeHonra)
            {
                Console.WriteLine("Quadro de honra!");
            }
            else if (aprovado)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (recuperacao)
            {
                Console.WriteLine("Recuperacao");
            }          
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
