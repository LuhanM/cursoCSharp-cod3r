using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoeArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "palavra",
                1,
                true
            };

            arrayList.Add(3.4);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item);
            }
        }
    }
}
