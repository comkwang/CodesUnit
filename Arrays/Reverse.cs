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
            foreach (int va in a)
                Console.Write($" {va} ");
            Console.WriteLine();

            ReverseMethod(b);
            foreach (int vb in b)
                Console.Write($" {vb} ");

        }
    }
}
