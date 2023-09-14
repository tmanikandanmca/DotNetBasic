using DotNetBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic
{

    // Compare int--
    // Compare
    internal static class GenericTest
    {
        //public static bool AreEqual(int Value1,int Value2)
        //{
        //    bool res=Value1.Equals(Value2);
        //    return res;
        //}

        public static bool AreEqual<T>(T Value1, T Value2)
        {
            bool res = Value1.Equals(Value2);
            return res;
        }

    }
}



//Console.WriteLine("This is my first Delegate");


//bool res = GenericTest.AreEqual(3, 3);
//Console.WriteLine(res);
//res = GenericTest.AreEqual("Besant", "Besant");
//Console.WriteLine(res);
//res = GenericTest.AreEqual(10.5f, 2.34f);
//Console.WriteLine(res);

//res = GenericTest.AreEqual<float>(2.4f, 2.34f);
//Console.WriteLine(res);
