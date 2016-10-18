using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipuriDeDate
{
    class Program
    {
        // calculez suma numerelor de la 1 la n
        static void Main(string[] args)
        {
            int n;
            int suma = 0;

            n = 10;

            // Sn = 1+  2  + ... + n
            // Sn = n+(n-1)+ ... + 1
            // 2Sn= (n+1) + (n+1) + .. + (n+1)
            // 2Sn = n(n+1)
            // Sn = n(n+1)/2;

            suma = n * (n + 1) / 2;

            Console.WriteLine("Suma este: {0}", suma);
        }
    }
}
