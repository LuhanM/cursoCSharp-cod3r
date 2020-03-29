using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class Subcelebridade
    {
        // acesso universal
        public string InfoPublica = "Tenho Instagram!";

        // acesso somente pela herança, igual ao delphi.
        protected string CorOlhos = "Verde";

        // acesso somente de dentro do mesmo projeto, Encapsulamento
        internal ulong NumeroCelular = 5549991547172;

        //herança ou mesmo projeto
        protected internal string ModoDeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto ( disponível apenas na versão 7.2 ou > do C#)
        private protected string SegredoFamília = "Bla Bla";

        //private padrão por default
        bool UsaPhotshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(ModoDeFalar);
            Console.WriteLine(SegredoFamília);
            Console.WriteLine(UsaPhotshop);
        }
    }
}
