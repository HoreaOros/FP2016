using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MatematicaLaborator5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triunghi();
            //Triunghi2();
            //Ex();
            //BowTie();


            ProcesareNumereDinFisier();
        }

        private static void ProcesareNumereDinFisier()
        {
            int n;
            string line;

            StreamReader fin = new StreamReader("input.txt");
            line = fin.ReadLine();
            n = int.Parse(line);

            line = fin.ReadLine();

            int[] v = new int[n];

            string[] tokens = line.Split(' ', '\t');
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
            }

            int m = Maxim(v);
            Console.WriteLine("Cel mai mare numar din lista este: {0}", m);

            m = Minim(v);
            Console.WriteLine("Cel mai mic numar din lista este: {0}", m);


            m = SumaModulo(v, n);
            Console.WriteLine("Suma modulo {0} a numerelor este: {1}", n, m);

            int p;
            p = NumerePare(v);
            Console.WriteLine("Numarul de numere pare este: {0}", p);

        }

        private static int NumerePare(int[] v)
        {
            int p = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    p++;
                }
            }
            return p;
        }

        private static int SumaModulo(int[] v, int n)
        {
            int suma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                suma = (suma + v[i]) % n;
            }

            return suma % n;
        }

        private static int Minim(int[] v)
        {
            int minim = int.MaxValue; // cea mai mare valoare ce se poate reprezenta pe int
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < minim)
                {
                    minim = v[i];
                }
            }
            return minim;
        }

        private static int Maxim(int[] v)
        {
            int maxim = int.MinValue; // cea mai mica valoare ce se poate reprezenta pe int
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > maxim)
                {
                    maxim = v[i];
                }
            }
            return maxim;
        }

        private static void BowTie()
        {
            // Citim un numar intreg de la tastatura.
            Console.WriteLine("Introduceti un numar: ");
            string line;
            line = Console.ReadLine();
            int n;
            n = int.Parse(line);

            for (int i = 1; i <= 2 * n + 1; i++)
            {
                for (int j = 1; j <= 2 * n + 1; j++)
                {
                    //      sub diagonala principale SI deasupra diagonalei secundara
                    // SAU
                    //     deasupra diagonalei principale SI sub diagonala secundara
                    if ((i >= j && i + j <= 2 * n + 2) || 
                        (i <= j && i + j >= 2 * n + 2))
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Functia afiseaza
        /// * . . . *
        /// . * . * .
        /// . . * . . 
        /// . * . * . 
        /// * . . . *
        /// </summary>
        private static void Ex()
        {
            // Citim un numar intreg de la tastatura.
            Console.WriteLine("Introduceti un numar: ");
            string line;
            line = Console.ReadLine();
            int n;
            n = int.Parse(line);

            for (int i = 1; i <= 2 * n + 1; i++)
            {
                for (int j = 1; j <= 2 * n + 1; j++)
                {
                    if (i == j || i + j == 2 * n + 2)
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }

        private static void Triunghi2()
        {
            // Citim un numar intreg de la tastatura.
            Console.WriteLine("Introduceti un numar: ");
            string line;
            line = Console.ReadLine();
            int n;
            n = int.Parse(line);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j <= n + 1) // acest if se va executa de n * n ori
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }

        }

        private static void Triunghi()
        {
            // Citim un numar intreg de la tastatura.
            Console.WriteLine("Introduceti un numar: ");
            string line;
            line = Console.ReadLine();
            int n;
            n = int.Parse(line);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i <= j) // acest if se va executa de n * n ori
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
}
