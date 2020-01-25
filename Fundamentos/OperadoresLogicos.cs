using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true; 
            var executouTrabalho2 = false;

            var comprarTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprar TV 50\": {0}", comprarTv50 );

            var comprarTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprar TV 32\": {0}", comprarTv32);

            var comprarSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprar sorvete: {0}", comprarSorvete);

            Console.WriteLine("Ficou sem sorvete? {0}", !comprarSorvete);

        }
    }
}
