using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikLinQ
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<int> sayilar = new List<int> { -25, 30, 92, 65, -51, 38, 43, -86, 99, 100 };

            var ciftSayilar = sayilar.Where(x => x % 2 == 0);
            var tekSayilar = sayilar.Where(y => y % 2 != 0);  
            var negatifSayilar = sayilar.Where(z => z < 0);
            var pozitifSayilar = sayilar.Where(w => w > 0);
            var kosul = sayilar.Where(k => k > 30 && k < 45);
            var kareler = sayilar.Select(x => x * x); 

            Console.WriteLine("---------- ÇİFT SAYILAR ----------");
            foreach (var x in ciftSayilar) Console.WriteLine(x);

            Console.WriteLine("---------- TEK SAYILAR ----------");
            foreach (var y in tekSayilar) Console.WriteLine(y);

            Console.WriteLine("---------- NEGATİF SAYILAR ----------");
            foreach (var z in negatifSayilar) Console.WriteLine(z);

            Console.WriteLine("---------- POZİTİF SAYILAR ----------");
            foreach (var w in pozitifSayilar) Console.WriteLine(w);

            Console.WriteLine("---------- >30 <45 KOŞULU ----------");
            foreach (var k in kosul) Console.WriteLine(k);

            Console.WriteLine("---------- SAYILARIN KARESİ ----------");
            foreach (var kare in kareler) Console.WriteLine(kare);
        }
    }
}
