using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaLaborator4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shuffling
            //Shuffle();


            // Erathostene
            Erathostene();

            // Reverse
            Reverse();

            // Minesweeper

            // RandomWalk (Snake)
        }

        private static void Erathostene()
        {
            int n = 100;
            int[] v = new int[n];
            bool[] b = new bool[n];
            int i;

            for (i = 0; i < v.Length; i++)
            {
                v[i] = i + 2;
                b[i] = true;
            }

            i = 0;
            int j;
            do
            {
                while (i < b.Length && b[i] == false)
                {
                    i++;
                }
                Console.WriteLine(v[i]);
                j = 2;
                while (v[i] * j - 2 < v.Length)
                {
                    b[v[i] * j - 2] = false;
                    j++;
                }
                i++;
            } while (i < v.Length);
        }

        private static void Shuffle()
        {
            int[] v = new int[10];


            for (int i = 0; i < v.Length; i++)
            {
                v[i] = i;
            }

            Random rnd = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                int r = i + rnd.Next(0, v.Length - i);
                int aux;
                aux = v[i];
                v[i] = v[r];
                v[r] = aux;
            }

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
