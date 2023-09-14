using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    XO
//   OOXX
//  XXXOOO
// OOOOXXXX

namespace DotNetBasic
{
    internal class PatternProb1
    {
        public void GetPattern(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string res1 = String.Empty;
                string res2 = String.Empty;
                for (int j = 1; j <= i; j++)
                {
                    res1 += "O";
                    res2 += "X";
                }
                string res = (i % 2) == 0 ? res2 + res1 : res1 + res2;
                Console.WriteLine(res);

            }

        }
    }
}


