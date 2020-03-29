using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class FilhoReconhecido : Subcelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorOlhos);
            Console.WriteLine(SegredoFamília);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(ModoDeFalar);
            //Console.WriteLine(UsaPhotoshop);
        }
    }
}
