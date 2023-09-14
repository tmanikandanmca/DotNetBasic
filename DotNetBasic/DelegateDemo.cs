using DotNetBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic
{
    public delegate int MyFirstDelegate(int x, int y);

    //[access modifier] delegate [return type] [delegate name]([parameters])

    public class DelegateDemo
    {
      
        //2.creating a handler method with same signature 
        public static int reactangle(int a,int b)
        {
                return a * b;

        }
    }
}



////3.creating an instance of delegate
//MyFirstDelegate md = new MyFirstDelegate(DelegateDemo.reactangle);

////Invoking the delegate
//int res = md(9, 8);

//Console.WriteLine(res);

