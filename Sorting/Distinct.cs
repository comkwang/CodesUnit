using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesUnit.Sorting
{
    class Distinct
    {
        public static int DistinctMethod(int[] A)
        {

       

            return  (from a in A group a by a into g select g.Key).Count();           
                      
         
        }
        public static void Test()
        {
            int[] A = new int[] { 2, 2, 1, 2, 3, 2};
            Console.WriteLine("DistinctMethod(A)={0}", DistinctMethod(A));
        }
    }
}
