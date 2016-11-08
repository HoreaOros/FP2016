using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


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
            Debug.WriteLine("Lungimea vecorului este: {0}", vector.Length);
            
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
            //BubbleSort(vector);
            //AfisareVector(vector);

            BubbleSort2(vector);
            AfisareVector(vector);



        }

        private static void BubbleSort2(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        Swap(vector, i, j);
                    }
                }
            }
        }

        private static void BubbleSort(int[] vector)
        {
            bool sortat = true;
            
            do
            {
                sortat = true;
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    if (vector[i] > vector[i + 1])
                    {
                        Swap(vector, i, i + 1);
                        sortat = false;
                    }
                }
            } while (!sortat);
        }

        private static void Swap(int[] vector, int i, int j)
        {
            int aux = vector[i];
            vector[i] = vector[j];
            vector[j] = aux;
        }

        private static int Suma(int[] vector)
        {
            int suma = 0; // variabila locala

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i]; // suma = suma + vector[i];
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
