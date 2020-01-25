using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    /// <summary>
    /// 
    /// </summary>
    class Comentarios
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Executar()
        {   
            Console.WriteLine("Código claro é sempre melhor!");
            Console.WriteLine("Porém, pode ser usado // para comentar linhas");
            // comentário de fonte como qualquer outra linguagem

            Console.WriteLine("Comentários de multiplas linhas usa /* */");
            /*linha 1
             linha 2
             linha 3             
            */

            Console.WriteLine("Para comentar trechos por atalhos, Ctrl+K+C comenta, Ctrl+K+U descomenta");

            Console.WriteLine("Para XML comments basta colocar /// porém, só antes de métodos, classes, funcoes");
            /// <summary>
            /// 
            /// </summary>
        }
    }
}
