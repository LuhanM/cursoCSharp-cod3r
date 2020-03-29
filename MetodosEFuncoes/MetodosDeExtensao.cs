using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }
    }

    class MetodosDeExtensao
    {       
        public static void Executar()
        {
            int numero = 5;
            Console.WriteLine(numero.Soma(10));
        }
    }
}
