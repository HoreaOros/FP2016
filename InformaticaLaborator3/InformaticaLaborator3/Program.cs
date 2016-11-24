using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// laborator 3 24.11.2016
namespace InformaticaLaborator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, k = 1000, n = 17;

            int r = Pow(a, k, n); // (a ^ k) (mod n) = ((a mod n)... (a mod n))(mod n)
            Console.WriteLine("{0} ^ {1} (mod {2}) = {3}", a, k, n, r);

            r = PowFast(a, k, n);
            Console.WriteLine("{0} ^ {1} (mod {2}) = {3}", a, k, n, r);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            f() ;
        }

        private static void f()
        {
            throw new NotImplementedException();
        }

        private static int PowFast(int a, int k, int n)
        {
            if (k == 0)
            {
                return 1;
            }
            else if (k % 2 == 1)
            {
                return (a * PowFast(a, k - 1, n)) % n;
            }
            else
            {
                int r = PowFast(a, k / 2, n);
                return (r * r) % n;
            }
        }

        private static int Pow(int a, int k, int n)
        {
            int r = 1;
            for (int i = 1; i <= k; i++)
            {
                r = ((r % n) * (a % n)) % n;
            }
            return r;
        }
    }
}
