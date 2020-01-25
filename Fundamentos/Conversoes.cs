using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            double nota = 9.7;

            //int notaTruncada = nota;
            int notaTruncada = (int) nota;

            Console.WriteLine("Nota Truncada: {0}", notaTruncada);


            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            //idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            Console.WriteLine("Digite um número:");
            string palavra = Console.ReadLine();

            int numero;
            int.TryParse(palavra, out numero);            
            Console.WriteLine("Resultado1: {0}", numero);

            int.TryParse(palavra, out int numero2);
            Console.WriteLine("Resultado2: {0}", numero2);
        }
    }
}
