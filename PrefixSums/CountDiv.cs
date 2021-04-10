using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnits.PrefixSums
{
    class CountDiv
    {
        public static int CountDivMethod(int A, int B, int K)
        {
            int num;

            if (B - A < 0) return 0; // negative value
            if (B == A) return A % K == 0 ? 1 : 0; // same value
            if (B < K) return 0; // less than mod key
            if (K == 1) return B - A + 1; // if mod value is 1
            num = A % K == 0 ? 1 : 0; // first value check 
            return (B / K) - (A / K) + num;
        }
        public static void Test()
        {
            Console.WriteLine("CountDivMethod(6, 11, 2)={0}", CountDivMethod(6, 11, 2));
        }
    }
}
