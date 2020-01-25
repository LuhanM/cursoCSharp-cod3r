using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digita uma nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            Console.WriteLine($"Nota digitada: {nota}");
            double notaCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0.0 );
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            Console.WriteLine("Passou por média? {0}", nota >= notaCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

        }
    }
}
