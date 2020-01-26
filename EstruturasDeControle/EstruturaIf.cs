using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a noda do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("O Aluno possui bom comportamento? (S/N)");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToUpper() == "S";

            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
