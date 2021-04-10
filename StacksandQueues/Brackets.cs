using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUnits.StacksandQueues
{
    class Brackets
    {
        public static int BracketsMethod(String S)
        {
            String temp;
            int j, k;
            k = S.Length % 2;
            if (S.Length % 2 != 0) return 0;
            j = S.Length - 1;
            temp = S.Substring(S.Length / 2);
            for (int i = 0; i < S.Length / 2; i++)
                if (S[i] != S[j--]) return 0;
            return 1;
        }
    }
}
