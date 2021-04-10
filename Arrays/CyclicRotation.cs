using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnits.Arrays
{
    class CyclicRotation
    {
        public static int[] CyclicRotationMethod(int[] A, int K) // 주어진 배열에서 K만큼 오른쪽으로 쉬프트한 값을 리턴
        {

            if (A == null) return null;
            int lenght = A.Length;
            K %= lenght;             
            if ( K == 0) return A;
            int[] R = new int[lenght];
            int p = 0;                    
            for (int i = lenght - K; i < lenght; i++)
                R[p++] = A[i];
            for (int i = 0; i < lenght - K; i++)
                R[p++] = A[i];

            return R;

        }
        public static void Test()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5};
            int[] ab = new int[] { 1 };
            int[] abc = new int[] { };


           // foreach (var i in CyclicRotationMethod(null, 0))
            //    Console.Write("{0} ", i);
            //Console.WriteLine();
            foreach (var i in CyclicRotationMethod(a, 0))
                Console.Write("{0} ", i);
            Console.WriteLine();
            foreach (var i in CyclicRotationMethod(a, 1))
                Console.Write("{0} ", i);
            Console.WriteLine();
            foreach (var i in CyclicRotationMethod(a, 2))
                Console.Write("{0} ", i);
            Console.WriteLine();
            foreach (var i in CyclicRotationMethod(a, 3))
                Console.Write("{0} ", i);
            Console.WriteLine();
            foreach (var i in CyclicRotationMethod(a, 4))
                Console.Write("{0} ", i);
            Console.WriteLine();
            foreach (var i in CyclicRotationMethod(a, 5))
                Console.Write("{0} ", i);
            Console.WriteLine();
        }
    }
}
