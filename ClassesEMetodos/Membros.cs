using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {

            Pessoa siclano = new Pessoa();
            siclano.Nome = "Luhan";
            siclano.Idade = 29;

            siclano.ApresentarNoConsole();
        }
    }
}
