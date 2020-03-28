using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string fabricante, string modelo, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "320i";
            carro1.Ano = 2020;

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            Carro carro2 = new Carro("Mercedez", "C180", 2019);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            Carro carro3 = new Carro()
            {
                Fabricante = "Volvo",
                Ano = 2016,
                Modelo = "XC60"
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
