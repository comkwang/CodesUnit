using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesUnit.Arrays
{
    class MissingInteger
    {

        public static int MissingIntegerMethod(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int number = 1, idx;
            Array.Sort(A);
            idx = Array.FindIndex(A, x => x > 0);

            if (idx < 0) return number;
            for (; idx < A.Length; idx++)
            {

                if (number < A[idx]) break;
                if (idx == A.Length - 1) { number++; break; }
                if (A[idx] == A[idx + 1]) continue;

                number++;

            }
            return number;

        }
    }

}
