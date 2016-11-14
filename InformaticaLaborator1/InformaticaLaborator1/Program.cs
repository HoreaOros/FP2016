using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaLaborator1
{
    class Program
    {
        public static void Experiment1Zar(int n)
        {
            Random rnd = new Random();
            int[] fq = new int[6];
            for (int i = 0; i < n; i++)
            {
                fq[rnd.Next(fq.Length)]++;
            }

            for (int i = 0; i < fq.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, fq[i]);
            }
        }
        public static void HO()
        {
            string line1 = "**    **   *********";
            string line2 = "**    **  ***********";
            string line3 = "**    **  **       **";
            string line4 = "********  **       **";
            string line5 = "********  **       **";
            string line6 = "********  **       **";
            string line7 = "**    **  **       **";
            string line8 = "**    **  ***********";
            string line9 = "**    **   *********";

            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(line6);
            Console.WriteLine(line7);
            Console.WriteLine(line8);
            Console.WriteLine(line9);


            // (!(a < b) && !(a > b)) <==> a == b
            // (a >= b) && (a <= b)
            // !(a && b) <==> !a || !b
            // !(a || b) <==> !a && !b



            

        }
        static void Main(string[] args)
        {
            HO();

            //Asterisc9("HOREA");

            int an = 1984;
            bool bisect = AnBisect(an);


            Experiment1Zar(1000000);
        }

        private static bool AnBisect(int an)
        {
            //return (an % 4 == 0 && an % 100 != 0) || an % 400 == 0;

            if ((((an % 4) == 0) && ((an % 100) != 0)) || ((an % 400) == 0))
            {
                return true;
            }
            else
            {
                return false;
            }

            // i < n && a[i] == 0
            // a[i] == 0 && i < n

            // i < n && x == y++

            // a || b 
        }

        private static void Asterisc9(string v)
        {
            throw new NotImplementedException();
        }
    }
}
