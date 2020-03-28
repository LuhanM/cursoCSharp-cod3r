using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        //modelo 1 de get e set;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        //somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //lambda 
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class Propriedades
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 8000);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Retrovisores elétricos";
            op2.Preco = 2500;
            Console.WriteLine(op2.PrecoComDesconto);



        }
    }
}
