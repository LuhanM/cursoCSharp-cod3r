using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            string entrada;

            Console.WriteLine("Digite sua nota: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);
            Console.WriteLine($"Você digitou a nota {nota}");
            bool aprovado = nota >= 7;
            if (aprovado)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            //by me
            //string mensagem = aprovado ? "Aprovado!" : "Reprovado";
            //Console.WriteLine(mensagem);
        }
    }
}
