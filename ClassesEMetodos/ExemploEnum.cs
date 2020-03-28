using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero Genero;
    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Comedia;
            Console.WriteLine(id);
            Console.WriteLine(Genero.Comedia.ToString());

            var filme = new Filme();
            filme.Titulo = "Senhor dos anéis";
            filme.Genero = Genero.Aventura;

            Console.WriteLine("{0} é {1}", filme.Titulo, filme.Genero);
        }


    }
}
