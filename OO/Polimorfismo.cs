using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;
        public Comida()
        {

        }

        public Comida(double peso)
        {
            Peso = peso;
        }

    }

    public class Feijao: Comida
    {     
        public Feijao(double peso): base(peso)
        {

        }
    }
    public class Arroz: Comida
    {
        public Arroz(double peso) : base(peso)
        {

        }
    }
    public class Carne: Comida
    {
        public Carne(double peso) : base(peso)
        {

        }
    }

    public class Pessoa
    {
        public double Peso;

        public void Comer(Comida alimento)
        {
            Peso += alimento.Peso;
        }
    }
    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao feijao = new Feijao(0.250);
            Arroz arroz = new Arroz(0.150);
            Carne carne = new Carne(0.200);

            Pessoa pessoa = new Pessoa();
            pessoa.Comer(feijao);
            pessoa.Comer(carne);
            pessoa.Comer(arroz);

            Console.WriteLine($"a pessoa está pesando {pessoa.Peso}");
        }
    }
}
