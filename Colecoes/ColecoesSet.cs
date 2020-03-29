using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("O Mago - livro 1", 39.9); 
            
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            Console.WriteLine(carrinho.Count);
            var livro2 = new Produto("O Mago - livro 2", 59.9);

            carrinho.Add(livro2);
            Console.WriteLine(carrinho.Count);

            var comboNomeDoVendo = new HashSet<Produto>
            {
                new Produto("O nome do Vento - Volume 1", 29.9),
                new Produto("O nome do Vento - Volume 2", 49.9),
                new Produto("O nome do Vento - Volume 3", 69.9)
            };

            carrinho.UnionWith(comboNomeDoVendo);

            Console.WriteLine(carrinho.Count);

            double totalCarrinho = 0;

            foreach (var item in carrinho)
            {
                totalCarrinho += item.Preco;

            }

            Console.WriteLine(totalCarrinho);

            //carrinho.RemoveAt(1);

            totalCarrinho = 0;

            foreach (var item in carrinho)
            {
                totalCarrinho += item.Preco;

            }
       
            Console.WriteLine(totalCarrinho);
        }
    }
}