using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesUnit
{
    class Getsingle
    {
        public static int MissingInteger(int[] A)
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
        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            int index = 0;
            while (index < 10)
                yield return index++;

            yield return 50;

            var items = new int[] { 100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
            foreach (var item in items)
                yield return item;
        }
    }
}
