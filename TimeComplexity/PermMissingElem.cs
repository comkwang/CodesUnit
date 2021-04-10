using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnits.TimeComplexity
{
    class PermMissingElem
    {
        public static int PermMissingElemMethod(int[] A)
        {

            int j;
            Array.Sort(A);
            for (j = 1; j < A.Length + 1; j++)
                if (A[j - 1] != j) break;
            return j;
        }
        public static void Test()
        {
            int[] A = new int[] { 2, 3, 1,5};

            Console.WriteLine("PermMissingElemMethod(A)= {0}", PermMissingElemMethod(A));
        }
    }
}
