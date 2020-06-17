using System;
using System.Collections.Generic;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var destinoDir = @"~/PastaCSharpDestino".ParseHome();
            var sourceDir = @"~/source/repos/CursoCSharp".ParseHome();

            if ( Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(destinoDir))
            {
                Directory.Delete(destinoDir, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("====== lista de pastas ======");
            var pastas = Directory.GetDirectories(sourceDir);
            
            foreach ( var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("/n/n ========= Arquivos ==========");

            var arquivos = Directory.GetFiles(sourceDir);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Directory.Move(novoDir, destinoDir);

            var sourceInfo = new DirectoryInfo(sourceDir);

            var arquivosSource = sourceInfo.GetFiles();
            foreach ( var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
        }
    }
}
