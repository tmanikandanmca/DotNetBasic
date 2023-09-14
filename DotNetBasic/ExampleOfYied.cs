using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic;

public class ExampleOfYied
{

    public void printData()
    {
        Console.WriteLine();
    }


    //Convertion

    public int[] result(List<int> r)
    {
        int[] x= new int[r.Count];
        foreach(int i in r)
        {
            x[i]=i;
        }
        return x;
    }
   
}
