using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("olá {0}", pessoa);
            }
        }

        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}-{1:D2}-{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            Recepcionar("luhan", "felipe", "ricardo");


            Formatar(mes: 11, dia: 27, ano: 1994);

        }
    }
}
