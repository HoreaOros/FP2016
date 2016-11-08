using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Program
    {
        static void Main(string[] args)
        {
            // sa se determine numarul de cifre al unui numar intreg
            int n = 123;
            Console.WriteLine("n = {0}", n);

            int numarCifre;
            numarCifre = NumarCifre(n);
            Console.WriteLine("Numarul de cifre din {0} este {1}", n, numarCifre);

            // sa se determine suma cifrelor unui numar
            int sumaCifre = SumaCifre(n);
            Console.WriteLine("Suma cifrelor lui {0} este {1}", n, sumaCifre);

            // sa se determine cea mai mare cifra dintr-un numar
            int maxim = CifraMaxima(n);
            Console.WriteLine("Cea mai mare cifra a numarului {0} este {1}", n, maxim);


            // sa se determine cea mai mica cifra dintr-un numar
            int minim = CifraMinima(n);
            Console.WriteLine("Cea mai mica cifra a numarului {0} este {1}", n, minim);


            // sa se determine oglinditul unui numar natural 
            // ex. pentru n = 123 oglindit(123) = 321;
            int oglindit = Oglindit(n);
            Console.WriteLine("Oglinditul lui {0} este {1}", n, oglindit);


            // sa se determine daca un numar este palindrom (numar egal cu oglinditul sau)
            // 121 este palindrom, 123 nu este palindrom

            if (Palindrom(n))
            {
                Console.WriteLine("Numarul {0} este palindrom", n);
            }
            else
            {
                Console.WriteLine("Numarul {0} NU este palindrom", n);
            }
        }

        private static bool Palindrom(int n)
        {
            if (n == Oglindit(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int Oglindit(int n)
        {
            int oglindit = 0;
            int c;
            while (n > 0)
            {
                c = n % 10;
                oglindit = oglindit * 10 + c;
                n = n / 10;
            }

            return oglindit;
        }

        private static int CifraMinima(int n)
        {
            int minim = 10;
            int c;

            while (n > 0)
            {
                c = n % 10;
                if (c < minim)
                {
                    minim = c;
                }

                n = n / 10;
            }

            return minim;
        }

        private static int CifraMaxima(int n)
        {
            int maxim = -1;
            int c;

            while (n > 0)
            {
                c = n % 10;
                if (c > maxim)
                {
                    maxim = c;
                }

                n = n / 10;
            }

            return maxim;
        }

        /// <summary>
        /// Functia determina numarul de cifre al unui numar
        /// </summary>
        /// <param name="n">Numarul pentru care se calculeaza suma cifrelor</param>
        /// <returns></returns>
        private static int NumarCifre(int n)
        {
            int numarCifre = 0;
            //int c;

            while (n > 0)
            {
                //c = n % 10;
                numarCifre++; // operatorul de incrementare (creste cu 1)
                n = n / 10;
            }

            return numarCifre;
        }

        /// <summary>
        /// Functia calculeaza suma cifrelor unui numar
        /// </summary>
        /// <param name="n">numarul pentru care se calculeaza suma cifrelor</param>
        /// <returns></returns>
        private static int SumaCifre(int n)
        {
            int suma = 0;
            int c;

            while (n > 0)
            {
                c = n % 10;
                suma = suma + c;
                n = n / 10;
            }

            return suma;
        }
    }
}
