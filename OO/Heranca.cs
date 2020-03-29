using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        } 

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno: Carro
    {
        // : base porque na classe base não tem construtor padrão 
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari: Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        // oculta o método da classe pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }
    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());


            Console.WriteLine("Exemplo public new frear");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            // por estar usando  public new int Frear() na classe, é chamado ao método da classe base, ao contrario de quando o método é override;
            Console.WriteLine(carro3.Frear());


        }
    }
}
