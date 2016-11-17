using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaLaborator2
{
    class Program
    {
        static void Main(string[] args)
        {

            ProcessCMDLineArgs(args);
            
            
        }

        private static void ProcessCMDLineArgs(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Programul a fost apelat fara argumente in Linia de comanda");
            }
            else
            {
                Console.WriteLine("Argumentele din linia de comanda sunt:");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
        }
    }
}
