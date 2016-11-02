using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float f;
            char c;
            string line;

            int[] vector = new int[15];

            Random rnd = new Random();

            // initializare vector
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 101); // [1,100]
            }

            AfisareVector(vector);

            // care este cel mai mare numar?
            int max = Maxim(vector);
            Console.WriteLine("Cel mai mare numar din vector este: {0}", max);
            
            // care este cel mai mic numar?
            int min = Minim(vector);
            Console.WriteLine("Cel mai mic numar din vector este: {0}", min);

            // care este suma numerelor
            int suma = Suma(vector);
            Console.WriteLine("Suma numerelor din vector este: {0}", suma);

            // media aritmetica a numerelor
            float mediaAritmetica;
            mediaAritmetica = 1.0f * suma / vector.Length;
            Console.WriteLine("Media artimetica a numerelor este: {0:F4}", mediaAritmetica);

            // ordonam crescator lista numerele 






        }

        private static int Suma(int[] vector)
        {
            int suma = 0; // variabila locala

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }

            return suma;
        }

        private static int Minim(int[] vector)
        {
            int min;
            min = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                }
            }

            return min;
        }

        private static int Maxim(int[] vector)
        {
            int max;
            max = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] > max)
                {
                    max = vector[i];
                }
            }

            return max;
        }

        private static void AfisareVector(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("{0} ", v[i]);
            }
            Console.WriteLine();
        }
    }
}
