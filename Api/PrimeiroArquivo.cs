﻿using System;
using System.IO;

namespace CursoCSharp.Api
{

    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX) 
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home); 
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //o @ faz ignorar a / e qualquer quebra de linha que tenha na string;
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é ");
                    sw.WriteLine("O meu primeiro");
                    sw.WriteLine("arquivo");

                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Adicionando uma nova linha"); 
            }

        }
    }
}