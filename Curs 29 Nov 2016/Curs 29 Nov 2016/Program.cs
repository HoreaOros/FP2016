using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Curs_29_Nov_2016
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] v;

            string line;
            int binCapacity = 0;
            using (StreamReader sw = new StreamReader("input.txt"))
            {
                line = sw.ReadLine();
                binCapacity = int.Parse(line);
                line = sw.ReadToEnd();
            }

                

            char[] seps = new char[] {' ', '\t', '\n', ';', ',', '\r'};
            string[] tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in tokens)
                Console.WriteLine(item);


            v = new int[tokens.Length];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
            }


            int bins;
            bins = NF(v, binCapacity);
            Console.WriteLine("Numarul de containere pe care le folosesc cu procedura NextFit este: {0}", bins);

            bins = FF(v, binCapacity);
            Console.WriteLine("Numarul de containere pe care le folosesc cu procedura FirstFit este: {0}", bins);


            bins = BF(v, binCapacity);
            Console.WriteLine("Numarul de containere pe care le folosesc cu procedura BestFit este: {0}", bins);

            bins = WF(v, binCapacity);
            Console.WriteLine("Numarul de containere pe care le folosesc cu procedura WorstFit este: {0}", bins);


        }

        private static int WF(int[] v, int binCapacity)
        {
            int count = 1;
            int[] total = new int[v.Length];

            for (int i = 0; i < v.Length; i++)
            {
                int maxim = 0;
                int maxBin = -1;
                for (int j = 0; j < count; j++)
                {
                    if (total[j] + v[i] <= binCapacity && (binCapacity - (total[j] + v[i])) > maxim)
                    {
                        maxim = binCapacity - (total[j] + v[i]);
                        maxBin = j;
                    }
                }
                if (maxBin >= 0)
                {
                    total[maxBin] += v[i];
                }
                else
                {
                    total[count] = v[i];
                    count++;
                }

            }
            return count;
        }

        private static int BF(int[] v, int binCapacity)
        {
            int count = 1;
            int[] total = new int[v.Length];

            for (int i = 0; i < v.Length; i++)
            {
                int minim = binCapacity;
                int minBin = -1;
                for (int j = 0; j < count; j++)
                {
                    if (total[j] + v[i] <= binCapacity && (binCapacity - (total[j] + v[i])) < minim)
                    {
                        minim = binCapacity - (total[j] + v[i]);
                        minBin = j;
                    }
                }
                if (minBin >= 0)
                {
                    total[minBin] += v[i];
                }
                else
                {
                    total[count] = v[i];
                    count++;
                }
               
            }
            return count;
        }

        private static int FF(int[] v, int binCapacity)
        {
            int count = 1;
            int[] total = new int[v.Length];

            for (int i = 0; i < v.Length; i++)
            {
                bool inserted = false;
                for (int j = 0; j < count; j++)
                {
                    if (total[j] + v[i] <= binCapacity)
                    {
                        total[j] += v[i];
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    total[count] = v[i];
                    count++;
                }
            }
            return count;
        }

        private static int NF(int[] v, int binCapacity)
        {
            int count = 1; // numarul total de containere folosite 
            int total = 0; // 

            for (int i = 0; i < v.Length; i++)
            {
                if (total + v[i] <= binCapacity)
                {
                    total += v[i];
                }
                else
                {
                    count++;
                    total = v[i];
                }
            }
            return count;
        }
    }
}
