using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] origArray = new int[10];
            CreateArray(origArray);
            Printer(ReverseArray(origArray));

            Console.ReadKey();

        }


        static int[] CreateArray(int[] a)
        {
            for (int i = 0; i < 10; i++)
            {
                a[i] = i + 1;
            }
                return a;
        }

        static int[] ReverseArray(int[] a)
        {
            int[] b = new int[10];
            int bIndex = 9;

            for (int i = 0; i < 10; i++ )
            {
                b[i] = a[bIndex--];
            }

                return b;
        }


        static void Printer(int[] a)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }









    }
}
