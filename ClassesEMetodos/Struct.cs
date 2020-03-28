using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    interface Ponto
    {
        void MoverDiagonal(int delta);
    }

    struct Coordenada: Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    class Struct
    {
        public static void Executar()
        {
            Coordenada exemplo1;
            exemplo1.X = 2;
            exemplo1.Y = 3;

            Console.WriteLine("X = {0}", exemplo1.X);
            Console.WriteLine("Y = {0}", exemplo1.Y);
            exemplo1.MoverDiagonal(2);
            Console.WriteLine("X = {0}", exemplo1.X);
            Console.WriteLine("Y = {0}", exemplo1.Y);


            var exemplo2 = new Coordenada(9, 1);
            Console.WriteLine("X = {0}", exemplo2.X);
            Console.WriteLine("Y = {0}", exemplo2.Y);
            exemplo2.MoverDiagonal(10);
            Console.WriteLine("X = {0}", exemplo2.X);
            Console.WriteLine("Y = {0}", exemplo2.Y);
        }
    }
}
