using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic
{
    internal class YeidTest
    {
        public void PrintResult(int num)
        {

            foreach (int i in ProduceEvenNumber(num))
            {
                Console.WriteLine(i);
                Console.Write(" ");
            }

            foreach (int i in ProduceEvenNumbers(num))
            {
                Console.WriteLine(i);
                Console.Write(" ");
            }
        }
 

       private IEnumerable<int> ProduceEvenNumbers(int upto)
        {
            for (int i = 0; i <= upto; i ++)
            {
                yield return i;
            }
        }



        private int[] ProduceEvenNumber(int upto)
        {
            int[] x=new int[upto];

            for (int i = 0; i < upto; i++)
            {
               x[i]=i;
            }
            return x;
        }


    }
}
