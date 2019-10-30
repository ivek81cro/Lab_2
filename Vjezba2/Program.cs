using System;

namespace Vjezba2
{
    class Program
    {
        class KompleksniBrojKlasa
        {
            public double RealniDio;
            public double ImaginarniDio;

            public KompleksniBrojKlasa(double real, double imag)
            {
                RealniDio = real; ImaginarniDio = imag;
            }
            public override string ToString()
            {
                return string.Format("{0} + {1}i", RealniDio, ImaginarniDio);
            }
        }

        struct KompleksniBrojStruktura
        {
            public double RealniDio;
            public double ImaginarniDio;

            public KompleksniBrojStruktura(double real, double imag)
            {
                RealniDio = real; ImaginarniDio = imag;
            }
            public override string ToString()
            {
                return string.Format("{0} + {1}i", RealniDio, ImaginarniDio);
            }
        }

        static void Main(string[] args)
        {
            KompleksniBrojKlasa kbk = new KompleksniBrojKlasa(1, 2);
            KompleksniBrojStruktura kbs = new KompleksniBrojStruktura(3, 4);

            Console.WriteLine(kbk.ToString());
            Console.WriteLine(kbs.ToString());

            KompleksniBrojKlasa kbk2 = kbk;
            KompleksniBrojStruktura kbs2 = kbs;

            kbk2.RealniDio = 5;
            kbs2.RealniDio = 6;

            Console.WriteLine(kbk2.ToString());
            Console.WriteLine(kbs2.ToString());
            Console.WriteLine(kbk.ToString());
            Console.WriteLine(kbs.ToString());


        }
    }
}
