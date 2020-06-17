using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(2020, 06, 16);
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
                
        }
    }
}
