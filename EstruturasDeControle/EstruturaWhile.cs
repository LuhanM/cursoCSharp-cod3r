using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativasUtilizadas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite seu palpite, sendo um número de 1 a 15:");
                int.TryParse(Console.ReadLine(), out palpite);

                tentativasRestantes--;
                tentativasUtilizadas++;

                numeroEncontrado = numeroSecreto == palpite;
                bool palpiteMaiorQueNumeroSecreto = palpite > numeroSecreto;
                bool palpiteMenorQueNumeroSecreto = palpite < numeroSecreto;
                if (numeroEncontrado)
                {
                    Console.WriteLine("Número encontrado em {0} tentativa(s)", tentativasUtilizadas);
                }
                else if (palpiteMaiorQueNumeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else if (palpiteMenorQueNumeroSecreto)
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
