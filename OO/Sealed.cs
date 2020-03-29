using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho 
    {
        public double ValorDaFortuna()
        {
            return 1_000_000.00;
        }
    }

    // O compilador já bloqueia
    ///class Exemplo: SemFilho
    //{
    //}

  
    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        } 
    }

    class Pai: Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Filho: Pai
    {
        //Não consegui sobrescrever método HonrarNomeFamilia()
        //public sealed override bool HonrarNomeFamilia()
        //{
        //    return true;
        //}
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            Filho filhoRebelde = new Filho();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());

        }
    }
}
