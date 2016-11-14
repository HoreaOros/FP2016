using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 14.11.2016
// Laborator Matematica anul I
namespace Laborator2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Distanta eculidiana dintre doua puncte P1(x,y1), P2(x2, y2)
            float x1 = 2.3f, x2 = 5.3f;
            float y1 = 4.1f, y2 = 8.1f;

            float d12;

            d12 = DistantaEuclidiana(x1, y1, x2, y2);
            Console.WriteLine("Distanta Eculidiana dintre cele doua puncte este: {0}", d12);


            int[] zile = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // Anotimpuri
            for (int m = 1; m <= 12; m++)
                for (int d = 1; d <= zile[m]; d++)
                {
                    string s = Anotimp(d, m);
                    Console.WriteLine("Ziua {0}.{1} este in anotimpul {2}", d, m, s);
                }


            // Experiment cu un zar;
            Zar1();
        }

        private static void Zar1()
        {
            Random rnd = new Random();

            int[] zar = new int[6]; // cele 6 elemente ale vectorului sunt initializate la 0
            int a;
            for (int i = 0; i < 1000000; i++)
            {
                a = rnd.Next(0, 6);
                zar[a]++;
            }

            for (int i = 0; i < zar.Length; i++)
            {
                Console.WriteLine("{0} -  {1}", i + 1, zar[i]);
            }
        }

        private static string Anotimp(int d, int m)
        {
            if (m == 1 || m == 2)
            {
                return "iarna";
            }
            else if (m == 3)
            {
                if (d < 20)
                    return "iarna";
                else
                    return "primavara";
            }
            else if (m == 4 || m == 5)
            {
                return "primavara";
            }
            else if (m == 6)
            {
                if (d < 20)
                    return "primavara";
                else
                    return "vara";
            }
            else if (m == 7 || m == 8)
            {
                return "vara";
            }
            else if (m == 9)
            {
                if (d < 22)
                    return "vara";
                else
                    return "toamna";
            }
            else if (m == 10 || m == 11)
            {
                return "toamna";
            }
            else if (m == 12)
            {
                if (d < 21)
                    return "toamna";
                else
                    return "iarna";
            }
            else
                return "date gresite";
        }

        private static float DistantaEuclidiana(float x1, float y1, float x2, float y2)
        {
            double distanta = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return (float)distanta;
        }
    }
}
