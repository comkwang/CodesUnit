using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesUnit.Arrays
{
    class Reverse
    {
        public static void ReverseMethod(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
        }

        public static void Test()
        {
            int[] a = { 1,2,3,4,5};
            int[] b = { 1, 2, 3, 4 };

            ReverseMethod(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}", a[i]);
                if (i != a.Length-1)
                    Console.Write(",");
            }

            Console.WriteLine();

            ReverseMethod(b);
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("{0}", b[i]);
                if (i != b.Length-1)
                    Console.Write(",");
            }

        }
    }
}
