using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic;

public class ValuesvsReference
{

    //Difference1: Updating the Ref and Out variables Inside the Method
    public static void AddData(int x, int y, ref int addition
       , out int subtraction)
    {
        subtraction = 0;
    }
    //Difference1:  Initializing the Ref and Out variables while passing to the Method
    public static void AddData1(int x, int y, ref int addition
       , out int subtraction)
    {

        subtraction = x - y;
    }


}




public static class RefClass
{

    //Difference1: Updating the Ref and Out variables Inside the Method
    public static void AddData(int x, int y, ref int addition
       , out int subtraction)
    {
        subtraction = 0;
    }
    //Difference1:  Initializing the Ref and Out variables while passing to the Method
    public static void AddData1(int x, int y, ref int addition
       , out int subtraction)
    {
        subtraction = 0;

    }

    public static void basicOperation(int x, int y, ref int addition
        , ref int subtraction, ref int multiplication
        , ref int dividion, ref int modules)
    {


    }
}


public class OutClass
{

    public void basicOperation(int x, int y, out int addition
        , out int subtraction, out int multiplication
        , out int dividion, out int modules)
    {
        addition = x + y;
        subtraction = x - y;
        multiplication = x * y;
        dividion = x / y;
        modules = x % y;

    }
}
