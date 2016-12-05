using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaLaborator4
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 0.0f;
            f++;


            // Median(args);

            // Uragan();

            Gimnastica();

            Monede();

        }

        private static void Monede()
        {
            int b1 = 1, b5 = 5, b10 = 10, b50 = 50;

            int n;
            n = int.Parse(Console.ReadLine());

            int monede = 0;

            monede += n / b50;
            n = n % b50;

            monede += n / b10;
            n = n % b10;

            monede += n / b5;
            n = n % b5;

            monede += n;

            Console.WriteLine("Numarul minim de monede pe care le folosim pentru a forma {0} bani este {1}", n, monede);
        }

        /// <summary>
        /// Calculeaza nota la gimnastica. Sunt 6 arbitrii care dau fiecare cate o nota.
        /// Cea mai mare si cea mai mica nota sunt eliminate. Nota finala va fi media aritmetica a celor 4 note ramase. 
        /// </summary>
        private static void Gimnastica()
        {
            float[] note = new float[6];

            for (int i = 0; i < note.Length; i++)
            {
                note[i] = float.Parse(Console.ReadLine());
            }

            // Ordonam lista celor 6 note
            for (int i = 0; i < note.Length - 1; i++)
            {
                for (int j = 0; j < note.Length; j++)
                {
                    if (note[i] > note[j])
                    {
                        float aux;
                        aux = note[i];
                        note[i] = note[j];
                        note[j] = aux;
                    }
                }
            }

            float suma = 0.0f;
            for (int i = 1; i < note.Length - 1; i++)
            {
                suma += note[i];
            }
            Console.WriteLine("Nota finala este: {0:0.00}", suma / 4);
        }


        private static void Uragan()
        {
            double mile = 1.60934;

            int[] viteze = {74, 96, 111, 131, 155, 10000};

            Console.WriteLine("Introduceti viteza vantului: ");
            string line;

            line = Console.ReadLine();
            int v = int.Parse(line); // viteza in km/h

            double mv = v / mile; // viteza in mile/h
            int categorie = 0;
            for (int i = 0; i < viteze.Length; i++)
            {
                if (mv  < viteze[i])
                {
                    categorie = i;
                    break;
                }
            }

            Console.WriteLine("Categoria uraganului este: {0}", categorie);

        }

        private static void Median(string[] args)
        {
            // Median - se dau 5 numere in linia de comanda
            // se cere al 3-lea numar in ordine crescatoare.
            int[] v = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                // Console.WriteLine(args[i]);
                v[i] = int.Parse(args[i]);
                Console.WriteLine(v[i]);
            }

            for (int i = 0; i < v.Length - 1; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux;
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
            Console.WriteLine("Medianul este: {0}", v[2]);

        }
    }
}
