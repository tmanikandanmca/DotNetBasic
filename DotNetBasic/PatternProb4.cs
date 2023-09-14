using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//square 1=>1 2=>4 3=>9 10  --- CTS
//1
//4
//9
//16
//25
//.... 100
namespace DotNetBasic
{
    internal class PatternProb4
    {
        public void result(int num)
        {
            int sum = 1, y = 0;
            for (int i = 1; i <= num; i++)
            {
                 sum = y + sum;
                Console.WriteLine(sum);
                if (i == 1)
                    y = 3;
                else
                    y = y + 2;

            }
        }

    }
}
