using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal (string nome)
        {
            Nome = nome;
        }

    }

    public class Cachorro: Animal
    {
        public double Altura { get; set; }
        public Cachorro(string nome): base(nome)
        {
            Console.WriteLine($"{nome} instanciado");
        }

        public Cachorro (string nome, double altura): this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem altura de {Altura} centimetros!";
        }
    }
    class ConstrutorThis
    {
        public static void Executar()
        {
            var belinha = new Cachorro("Belinha");
            var pituka = new Cachorro("Pituka", 35.0);

            Console.WriteLine(belinha);
            Console.WriteLine(pituka);
        }
    }
}
