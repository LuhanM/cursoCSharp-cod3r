using System;
using System.IO;

namespace CursoCSharp.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("produto;preco;qtde");
                sw.WriteLine("caneta;3.69;50");
                sw.WriteLine("borracha;1.50;25");
            }

            using (StreamReader sr = new StreamReader(path))
            {
                var texto = sr.ReadToEnd();
                Console.WriteLine(texto);
            }
        }
    }
}
