using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnits.TimeComplexity
{
    class FrogJmp
    {
        public static int FrogJmpMethod(int X, int Y, int D)
        {

            int S;
            S = Y - X;
            if (S <= 0 || D < 0) return 0;
            return (int)Math.Ceiling((double)S / (double)D);

        }
        public static void Test()
        {
            Console.WriteLine("FrogJmpMethod(10, 85, 30)= {0} ", FrogJmpMethod(10, 85, 30));
        }
    }
}
