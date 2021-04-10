using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesUnit
{
    class Splitletter
    {
        public static string splitletterMethod(string s)
        {
            char[] chararray = s.ToCharArray();
            int r = 1;

            for (int i = 2; i < s.Length - 1; i++)
                if (chararray[r] > chararray[i]) r = i;
            return s.Substring(0, 1) + s.Substring(r, s.Length - 1);

        }
    }
}
