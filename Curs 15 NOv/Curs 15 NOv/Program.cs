using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_15_NOv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabile si tipuri de date.
            // Definitii (declaratii)
            int n = 1, m = 2;
            float f;
            string s;
            char c;
            decimal d;
            bool b;


            // Operatori
            // Aritmetici
            n = m + n;
            n = n - m;
            n = n * n;
            n = n / 10;
            n = n % 2;
            // Relationali, egalitate si inegalitate
            b = n == m;
            b = n != m;
            b = n < m;
            b = n <= m;
            b = n >= m;
            b = n > m;
            // Operatori logici
            b = (n < m) && (n % 4 == 0); // SI
            //   && |  false   true
            // -------------------
            // false|  false   false
            // true |  false   true

            b = (n < m) || (n % 4 == 0); // SAU
            //   || |  false   true
            // -------------------
            // false|  false   true
            // true |  true    true

            b = !(n < m); // <==> n >= m


            // Instructiuni
            // if
            if (n % 4 == 0)
            {
                // Instructiunea ce se executa atunci cand conditia este adevarata 
            }
            else
            {
                // partea else este optionala.
                // Instructiunea ce se executa atunci cand conditia este falsa
            }
            // for
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
            // while
            while (n > 0)
            {
                n = n / 10;
            }
            // do.. while
            //bool dead = false;
            //do
            //{
            //    Console.WriteLine("Working...");
            //} while (!dead);

            
            // foreach
            int[] v = { 0, 2, 4, 7 };
            foreach (int item in v)
            {
                Console.WriteLine(item);
            }
            // break
            // continue

            // switch

            DateDiff();

            TwoSum();
        }

        private static void TwoSum()
        {
            int t = 1335847;
            Random rnd = new Random();
            int[] v = new int[1000000];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(int.MinValue, int.MaxValue);
            }



            //Slow2Sum(v, t);

            Fast2Sum(v, t);
            
        }

        private static void Fast2Sum(int[] v, int t)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            DateTime start = DateTime.Now;

            Array.Sort(v);
            int contor = 0;
            
            Console.WriteLine("Working...");
            for (int i = 0; i < v.Length; i++)
            {
                int index = Array.BinarySearch(v, t - v[i]);
                if (index >= 0 && index != i)
                {
                    contor++;
                }
            }
            Console.WriteLine("Done. Yuppi.");
            sw.Stop();
            
            DateTime stop = DateTime.Now;
            Console.WriteLine("Am gasit {0} perechi a caror suma este {1}", contor, t);
            Console.WriteLine("Executia a durat: {0}", stop.Subtract(start).TotalSeconds);


        }

        private static void Slow2Sum(int[] v, int t)
        {
            int contor = 0;
            DateTime start = DateTime.Now;
            Console.WriteLine("Working...");
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] + v[j] == t)
                    {
                        contor++;
                        Console.WriteLine(contor);
                    }
                }
            }
            Console.WriteLine("Done. Yuppi.");
            DateTime stop = DateTime.Now;
            Console.WriteLine("Am gasit {0} perechi a caror suma este {1}", contor, t);
            Console.WriteLine("Executia a durat: {0}", stop.Subtract(start).TotalSeconds);
        }

        private static void DateDiff()
        {
            // Preconditie: dn1 este anterior zilei curente (azi);
            DataCalendaristica dn1;
            DataCalendaristica azi;

            dn1.ziua = 13;
            dn1.luna = 11;
            dn1.anul = 1980;

            azi.ziua = DateTime.Now.Day;
            azi.luna = DateTime.Now.Month;
            azi.anul = DateTime.Now.Year;

            int contor = 0;
            while (dn1.Diferit(azi))
            {
                contor++;
                azi.ScadOZi();
            }

            Console.WriteLine("Numarul de zile dintre cele doua date calendaristice este: {0}", contor);
        }
    }
}
