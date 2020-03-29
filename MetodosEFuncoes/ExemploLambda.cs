﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            // numero é o primeiro parâmetro do Func int. Nesse caso ele se torna um parâmetro de entrada
            Func<int, string> conversorHex = (numero) =>
            {
                return numero.ToString();
            };
            // Pode ser escrito nesse formato também 
            //Func<int, string> conversorHex = (numero) => numero.ToString();
            Console.WriteLine(conversorHex(2));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => 
                String.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);

            Console.WriteLine(formatarData(25, 8, 2018));
        }
    }
}
