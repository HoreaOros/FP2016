using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_22_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = {1, 3, 7, 10, 13, 22, 56};


            int p = BinarySearch(v, 0);
            if (p < 0)
            {
                Console.WriteLine("Nu am gasit valoarea cautata");
            }
            else
                Console.WriteLine("Am gasit valoarea cautata pe pozitia {0}", p);
        }

        private static int BinarySearch(int[] v, int key)
        {
            int left = 0;
            int right = v.Length - 1;
            int mid;
            while (left <= right)
            {
                // mid = (left + right) / 2;
                mid = left + (right - left) / 2;
                if (v[mid] == key)
                {
                    return mid;
                }
                else if (key < v[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }
    }
}
