using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
    class Listas
    {
        public static void Executar()
        {
            var livro = new Produto("O Mago - livro 1", 39.9);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            Console.WriteLine(carrinho.Count);
            var livro2 = new Produto("O Mago - livro 2", 59.9);

            carrinho.Add(livro2);
            Console.WriteLine(carrinho.Count);

            var comboNomeDoVendo = new List<Produto>
            {
                new Produto("O nome do Vento - Volume 1", 29.9),
                new Produto("O nome do Vento - Volume 2", 49.9),
                new Produto("O nome do Vento - Volume 3", 69.9)
            };

            carrinho.AddRange(comboNomeDoVendo);

            Console.WriteLine(carrinho.Count);

            double totalCarrinho = 0;

            foreach (var item in carrinho)
            {
                totalCarrinho += item.Preco;

            }

            Console.WriteLine(totalCarrinho);

            carrinho.RemoveAt(1);

            totalCarrinho = 0;

            foreach (var item in carrinho)
            {
                totalCarrinho += item.Preco;

            }

            Console.WriteLine(totalCarrinho);
        }
    }
}