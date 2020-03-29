using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();
        public string Tocar()
        {
            return "trim trim";
        }
    }

    public class Samsung: Celular
    {
        public override string Assistente()
        {
            return "Olá! Eu sou a Bixby!";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Eu sou a Siri!";
        }
    }


    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Samsung(),
                new IPhone()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
