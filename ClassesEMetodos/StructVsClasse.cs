using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct StructPonto
    {
        public int X;
        public int Y;
    }

    public class ClassPonto
    {
        public int X;
        public int Y;
    }
    class StructVsClasse
    {
        public static void Executar()
        {
            StructPonto ponto1 = new StructPonto{ X = 1, Y = 2};
            StructPonto copiaPonto1 = ponto1; //Atribuição por Valor
            ponto1.X = 3;

            Console.WriteLine(ponto1.X);
            Console.WriteLine(copiaPonto1.X);

            ClassPonto ponto2 = new ClassPonto { X = 2, Y = 3 };
            ClassPonto copiaPonto2 = ponto2; // Atribuição por referência
            ponto2.X = 5;

            Console.WriteLine(ponto2.X);
            Console.WriteLine(copiaPonto2.X);
        }
    }
}
