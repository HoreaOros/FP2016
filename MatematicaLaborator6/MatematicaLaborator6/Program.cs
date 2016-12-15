using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MatematicaLaborator6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Goldback conjecture
            //for (int n = 4; n <= 1000; n = n + 2)
            //{
            //    Goldbach(n);
            //}


            
            BordaCount();

        }

        private static void BordaCount()
        {
            StreamReader sw = new StreamReader("input.txt");
            string line;
            int N, K;


            N = int.Parse(sw.ReadLine());
            K = int.Parse(sw.ReadLine());

            int[] scor = new int[N];
            int[] aux = new int[N];
            char[] seps = {' ', '\t'};
            for (int i = 0; i < K; i++)
            {
                line = sw.ReadLine();
                string[] tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tokens.Length; j++)
                {
                    aux[j] = int.Parse(tokens[j]);
                }
                for (int j = 0; j < aux.Length; j++)
                {
                    scor[aux[j] - 1] += (j + 1);
                }
            }

            for (int i = 0; i < scor.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, scor[i]);
            }

            int maxim = scor[0];
            int idx = 0;
            for (int i = 1; i < scor.Length; i++)
            {
                if (scor[i] > maxim)
                {
                    maxim = scor[i];
                    idx = i;
                }
            }
            Console.WriteLine("Castigatorul alegerilor este: {0} si a obtinut scorul {1}", idx + 1, maxim);

        }

        private static int Goldbach(int n)
        {
            int contor = 0;
            Console.Write("{0} = ", n);
            for (int d = 2; d <= n / 2; d++)
            {
                if (Prim3(d) && Prim3(n - d))
                {
                    contor++;
                    //Console.Write("{0} + {1} = ", d, n - d);
                }
            }
            Console.WriteLine("x {0}", contor);
            return contor;
        }
        private static bool Prim1(int x)
        {
            int contor = 0;
            int d;
            if (x == 2)
            {
                return true;
            }
            if (x < 2 || (x % 2 == 0))
            {
                return false;
            }

            for (d = 1; d <= x; d++)
            {
                if (x % d == 0)
                {
                    contor++;
                }
            }
            if (contor == 2)
            {
                return true;
            }
            else
                return false;
        }
        private static bool Prim2(int x)
        {
            int contor = 0;
            int d;

            if (x == 2)
            {
                return true;
            }
            if (x < 2 || (x % 2 == 0))
            {
                return false;
            }
            for (d = 3; d <= x / 2; d = d + 2)
            {
                if (x % d == 0)
                {
                    contor++;
                    break;
                }
            }
            if (contor == 0)
            {
                return true;
            }
            else
                return false;
        }
        private static bool Prim3(int x)
        {
            int contor = 0;
            int d;

            if (x == 2)
            {
                return true;
            }
            if (x < 2 || (x % 2 == 0))
            {
                return false;
            }
            for (d = 3; d * d <= x; d = d + 2) // d <= Math.Sqrt(x)
            {
                if (x % d == 0)
                {
                    contor++;
                    break;
                }
            }
            if (contor == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
