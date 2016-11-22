using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaLaborator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 2;


            Console.WriteLine("x = {0}, y = {1}", x, y);

            // Daca valoarea lui x este mai mare decat valoarea lui y atunci inversez valorile
            if (x > y)
            {
                int t;
                t = x;
                x = y;
                y = t;
            }
            Console.WriteLine("x = {0}, y = {1}", x, y);

            // Rezolvarea ecuatiei de gradul II cu o necunoscuta

            // Presupunem ca a este diferit de zero
            double a = 1.0, b = 0, c = 2.0;
            double delta;
            delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Ecuatia nu are solutii reale");
            }
            else if (delta == 0)
            {
                double x1;
                x1 = -b / (2 * a);
                Console.WriteLine("Solutia ecuatiei este: {0}", x1);
            }
            else
            {
                double x1, x2;
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Solutiile ecuatiei sunt: {0}, {1}", x1, x2);

            }

            //Sa se determine cea mai mare putere a lui 2 mai mica sau egala decat n;
            int n = 129;
            int putere = 1;
            while (putere <= n / 2)
            {
                putere = putere * 2;
            }
            Console.WriteLine("Cea mai mare putere al lui 2 mai mica sau egala decat {0} este {1}", n, putere);


            // Harmonic
            for (n = 1; n <= 100; n++)
            {
                double h = Harmonic(n);
                Console.WriteLine("Numarul armonic de ordin {0} este {1}", n, h);
            }

            // Methoda Newton
            c = 2.0;
            double epsilon = 0.0000001;

            double s = Newton(c, epsilon);
            Console.WriteLine("Radacina patrata a lui {0} cu precizie {1} este {2}", c, epsilon, s);

            // Conversie a unui numar natural din baza 10 in baza 2;
            n = 10;
            ConvertToBinary(n);

        }

        private static void ConvertToBinary(int n)
        {
            int[] v = new int[32];
            int i = 0;

            Console.WriteLine("Numarul {0} in baza 2 este: ", n);
            while (n > 0)
            {
                v[i] = n % 2; i++;
                n = n / 2;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(v[j]);
            }
            Console.WriteLine();
        }

        private static double Newton(double c, double epsilon)
        {
            double t = c;

            while (Math.Abs(t - c /t ) > epsilon)
            {
                t = (t + c / t) / 2;
            }

            return t;
        }

        /// <summary>
        /// Calculeaza numarul armonic de ordin n: 1/1 + 1/2 + ... + 1/n
        /// </summary>
        /// <param name="n">Ordinul numarului armonic</param>
        /// <returns></returns>
        private static double Harmonic(int n)
        {
            double suma = 0.0;

            for (int i = 1; i <= n; i++)
            {
                suma = suma + 1.0 / i;
            }

            return suma;
        }
    }
}
