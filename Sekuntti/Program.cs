using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekuntti
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Sec;
            Console.WriteLine("Anna sekunttimäärä");
            Sec = uint.Parse(Console.ReadLine());
            uint T = (Sec / 3600);
            uint M = ((Sec - (T * 3600)) / 60);
            uint S = ((Sec - (T * 3600)) - (M * 60));
            Console.WriteLine("Antamasi sekunttimäärä voidaan esittää myös muodossa " + T + " tuntia, " + M + " minuuttia ja " + S + " sekunttia.");

        }
    }
}


