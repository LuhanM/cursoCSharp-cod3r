using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 56, seconds: 15);
            Console.WriteLine(intervalo.TotalMinutes);
            Console.WriteLine(intervalo.TotalMilliseconds);
            Console.WriteLine(intervalo.Days);
        }
    }
}
