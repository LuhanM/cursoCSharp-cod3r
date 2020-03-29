using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class AmigoProximo
    {
        public readonly Subcelebridade amigo = new Subcelebridade();
        
        public void MeusAcessos()
        {
            Console.WriteLine("amigo proximo ");

            Console.WriteLine(amigo.InfoPublica);
            Console.WriteLine(amigo.ModoDeFalar);
            Console.WriteLine(amigo.NumeroCelular);
        }
    }
}
