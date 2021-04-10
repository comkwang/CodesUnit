using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnits.Arrays
{
    class OddOccurrencesInArray
    {
        public static int OddOccurrencesInArrayMethod(int[] A)
        {

            int i;
            Array.Sort(A);

            for (i = 0; i < A.Length; i += 2)
            {
                if (i + 1 == A.Length) break;
                if (A[i] != A[i + 1]) break;

            }

            return A[i];

        }
        public static void Test()
        {
            int[] A = new int[] { 9, 3, 9, 3, 9, 7 };

            Console.Write("OddOccurrencesInArrayMethod(A) {");
            foreach(var i in A)
                Console.Write("{0},", i);
            Console.WriteLine(" {0}", OddOccurrencesInArrayMethod(A));



        }
    }
}
