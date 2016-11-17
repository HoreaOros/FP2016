using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaLaborator2
{
    class Program
    {
        static void Main(string[] args)
        {

            //ProcessCMDLineArgs(args);
            //DivisorPattern(40);

            //ulong n = 12;
            ulong n = 9201111169755555649; 
            //Factorizare(n);


            n = 100;

            CuponColectorExperiment(n, 1000);
            
        }

        private static void CuponColectorExperiment(ulong n, int v)
        {
            double medie = 0;
            ulong e;
            for (int i = 0; i < v; i++)
            {
                e = CouponCollector(n);
                medie = medie + (double)e / v;
            }
            Console.WriteLine("Pentru a obtine toata colectia de {0} cupoane fac in medie {1} extrageri", n, medie);
        }

        private static ulong CouponCollector(ulong n)
        {
            bool[] colectie = new bool[n];
            ulong distinct = 0;

            Random rnd = new Random();
            int r;
            ulong e = 0;
            while (distinct < n)
            {
                r = rnd.Next((int)n);
                e++;
                if (colectie[r] == false)
                {
                    colectie[r] = true;
                    distinct++;
                }
            }
            //Console.WriteLine("Pentru a obtine toata colectia de {0} cupoane am extras {1}", n, e);
            return e;
        }

        private static void Factorizare(ulong n)
        {
            ulong d = 2;
            while (n > 1)
            {
                while (n % d == 0)
                {
                    Console.Write("{0} ", d);
                    n = n / d;
                }
                d++;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Functia afiseaza intr-un patart patternul de mai jos
        /// </summary>
        /// <param name="v">Dimensiunea patratului</param>
        /*  * * * * * * * * * * * * * * * * * * * * 1
         *  * *   *   *   *   *   *   *   *   *   * 2
         *  *   *     *     *     *     *     *     3
         *  * *   *       *       *       *       * 4
         *  *       *         *         *         * 5
         *  * * *     *           *           *     6
         *  *           *             *             7
         *  * *   *       *               *         8
         *  *   *           *                 *     9
         *  * *     *         *                   * 10
         *  *                   *                   11
         *  * * * *   *           *                 12
         *  *                       *               13
         *  * *         *             *             14
         *  *   *   *                   *           15
         *  * *   *       *               *         16
         *  *                               *       17
         *  * * *     *     *                 *     18
         *  *                                   *   19
         *  * *   * *         *                   * 20 */
        private static void DivisorPattern(int v)
        {
            for (int i = 1; i <= v; i++)
            {
                for (int j = 1; j <= v; j++)
                {
                    if (i % j == 0 || j % i == 0)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine(" {0}", i);
            }
        }

        private static void ProcessCMDLineArgs(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Programul a fost apelat fara argumente in Linia de comanda");
            }
            else
            {
                Console.WriteLine("Argumentele din linia de comanda sunt:");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
        }
    }
}
