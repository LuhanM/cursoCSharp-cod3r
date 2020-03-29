using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);

    }
    
    // uma classe pode implementar uma ou MUITAS interfaces
    class Soma: OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    // uma classe pode implementar uma ou MUITAS interfaces
    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    // uma classe pode implementar uma ou MUITAS interfaces
    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Multiplicacao(),
            new Subtracao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";
           
            foreach (var op in operacoes)
            {
                resultado += $"usando a classe {op.GetType().Name} o resultado é: {op.Operacao(a, b)} \n";
            }

            return resultado;
        }
    }
    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            Console.WriteLine(calc.ExecutarOperacoes(50, 30));

        }
    }
}
