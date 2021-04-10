using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesUnit.Iterations
{
    public class BinaryGap
    {
       
        public static string BinaryGapMethod(int n) // 십진수를 이진수를 바꿔서 1과 1사이에서 가장 많은 0의 갯수를 리런
        {
            int i, idx=0;
            string nstring = Convert.ToString(n, 2);
        
            do
            {                
                i = nstring.IndexOf("1");
                if (i < 0) break;
                if (i > idx) idx = i;     
                nstring = nstring.Substring(++i);
            } while (nstring != null);
      

            return string.Format("{0,-10} {1,-32} {2}", n, Convert.ToString(n, 2), idx);
        }
        public static void Test()
        {
            Console.WriteLine(BinaryGapMethod(0));
            Console.WriteLine(BinaryGapMethod(15));
            Console.WriteLine(BinaryGapMethod(32));
            Console.WriteLine(BinaryGapMethod(33));
            Console.WriteLine(BinaryGapMethod(1041));
            Console.WriteLine(BinaryGapMethod(65541));
        }
    }
}
