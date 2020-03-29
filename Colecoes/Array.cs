using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "luhan";
            alunos[1] = "felipe";
            alunos[2] = "gleison";
            alunos[3] = "paulo";
            alunos[4] = "ivo";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 7.6, 10, 9.5 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine(media);
        }
    }
}
