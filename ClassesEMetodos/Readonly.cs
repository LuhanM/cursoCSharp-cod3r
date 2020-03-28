using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(String nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Luhan Meireles da Silva", new DateTime(1990, 12, 12));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            //novoCliente.Nascimento = new DateTime(1990, 12, 12);
            //Erro    CS0191 Um campo somente leitura não pode ser atribuído(exceto em um construtor ou inicializador de variável) 

        }

    }
}
