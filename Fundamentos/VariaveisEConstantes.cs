using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area de circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("byte não aceita valores negativos");
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; 
            Console.WriteLine("sbyte aceita valores com sinal" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Melhor Valor Inteiro " + menorValorInt);

            // uint aceita apenas inteiro positivos, ou seja, sem sinal 
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Popoulação Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço Computador" + precoComputador);

            double valorDeMercadoDaApple = 1000000000000.00;
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as Estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra );

            string texto = "Finalizando Variáveis e Constantes";
            Console.WriteLine(texto);

        }

    }
}
