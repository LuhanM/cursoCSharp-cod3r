using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "oi.";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "luhan", "josé", "paulo", "felipe" };
            foreach (var aluno in alunos){
                Console.WriteLine(aluno);
            }
        }
    }
}
