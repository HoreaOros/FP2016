using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // secventa de cod de mai jos calculeaza suma 10 + 11 + 12 ... + 20 si afiseaza rezultatul.
            int suma = 10;
            int i = 1;

            while (i <= 10)
            {
                suma = suma + i;
                i = i + 1;
            }

            Console.WriteLine("Suma este: {0}", suma);

        }
    }
}
