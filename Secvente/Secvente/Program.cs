using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            Random rnd = new Random();
            //n = rnd.Next(1, 7); // [1, 6]

            f1(n);
            f2(n);
        }

        private static void f2(int n)
        {
            int linie = 1;
            int spatii = 0;
            int stelute = n;

            while (linie <= n)
            {
                for (int i = 0; i < spatii; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < stelute; i++)
                {
                    Console.Write("*");
                }
                linie++;
                spatii++;
                stelute--;
                Console.WriteLine();
            }
        }

        private static void f1(int n)
        {
            // i,j,k,l,m,n,s,t,p
            int linie = 1;
            int numarStelutePeLinie = 0;

            while (linie <= n)
            {
                Console.Write("*");
                numarStelutePeLinie++; // numarStelutePeLinie = numarStelutePeLinie + 1 
                                       // numarStelutePeLinie += 1
                if (numarStelutePeLinie == linie)
                {
                    Console.WriteLine();
                    numarStelutePeLinie = 0;
                    linie++;
                }
            }

            Separator(n, '-');
        }

        private static void Separator(int n, char v)
        {
            Console.Write("<");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v);
            }
            Console.Write(">");
            Console.WriteLine();
        }
    }
}
