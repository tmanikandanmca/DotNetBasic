using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic
{
    internal class Deposit : Calculate
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int sub(int x, int y)
        {
            var res= x - y;
            return res;
        }

        public float sub(float x, float y)
        {
            var res = x - y;
            return res;
        }

        public string sub(string x, string y)
        {
            var res = x + y;
            return res;
        }


        public int Fund(int x, int y)
        {
           dynamic x123= add(x, y);
      
            return x123;
      
        }

        public void Fund1(int x, int y,ref int sub1,ref int add1)
        {
            sub1 = sub(x, y);
            add1 = add(x, y);
        }


        public void Fund2(int x, int y, out int sub1, out int add1)
        {
            sub1 = sub(x, y);
            add1 = add(x, y);
        }
    }
}
