using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetBasic;

internal class PropertyBinding
{
    private int _age;

    public int speed;


    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int age)
    {

        _age = age;
    }

    public int Speed
    {
        get { return speed; }
        set
        {
            speed = value;
        }
    }
}




//int x = f2.Count();

//Console.Write("Enter row number for an Array ==>");
//int r1 =Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter Column number for an Array ");
//int r2 = Convert.ToInt32(Console.ReadLine());

//int[,] mat1 = new int[r1,r2];
//int[,] mat2= new int[r1, r2];



//for (int i = 0; i <= r1 - 1; i++)

//{
//    for (int j = 0; j <= r2 - 1; j++)
//    {
//        mat1[i,j] = Convert.ToInt32(Console.ReadLine());
//    }

//}




//Sort();
//reverse
//copy




//for (int i = 0; i < f1.Length; i++)
//{
//    Console.WriteLine(f1[i]);
//}





//Console.Write("Enter R values for Circle ");
//float r = float.Parse(Console.ReadLine());
//Console.Write("Area of Circle:" + a.Area(r).ToString());

//Console.WriteLine("Enter R values for Square ");
//int a1 = int.Parse(Console.ReadLine());
//Console.Write("Area of Squre :" + a.Area(a1).ToString());

//Console.ReadLine();





/*Deposit ds = new Deposit();
Console.Write("add 2 number : ");

ds.Fund(1200, 200);

int x = 0, y = 0;
ds.Fund1(234, 675, ref x, ref y);
Console.WriteLine("ref add 2 number : " + x);
Console.WriteLine("ref sub 2 number : " + y);


int a = 0, b = 0;
ds.Fund2(500, 250, out a, out b);
Console.WriteLine("ref add 2 number : " + a);
Console.WriteLine("ref sub 2 number : " + b);



Console.WriteLine("Hello, World!");
*/


//out ref


//GetSetProperties fs= new GetSetProperties();
//fs.id = 4;
//fs.SetBalance(-500);

//Console.WriteLine(fs.GetBalance());

//PropertyBinding pb = new PropertyBinding();


//pb.GetAge();

//int age=pb.GetAge();
//Console.WriteLine(age);


//int x = 25, y = 5;
//int addition =0, subtraction;
//ValuesvsReference.AddData(x, y,ref addition,out subtraction);




//overloading
///circle
///square
///rectancle
///triange




////05-9 -- exception 


////var dynamic
////datatype[] variable_name = new datatype(lenth) { 1,2,2,}

////1. 6 --20

//int[] f1 = new int[3];
//int[] f2 = { 1, 4, 5, 8, 5, 7, 9, 0, 1, 3, 6 };
////ArrayList f3 = new ArrayList();
////f3[0] = 1;
////f3[1] = "mani";
////f3.Insert(5, "Besant");

//Dictionary<int,string> fe1= new Dictionary<int,string>();
//Dictionary<char, float> fe2 = new Dictionary<char, float>();


//List<string> Name= new List<string>() ;
//Name.Add("ashjdgas");
//Name.Add("ashjdgas");
//Name.Add("ashjdgas");
//Name.Add("ashjdgas");

//Hashtable  tab1= new Hashtable();
//tab1.Add('a', "india");
//tab1.Add('b', "US");
//tab1.Add('c', "Pak");
//tab1.Add('d', 1.2f);
//tab1.Add('r', 1234);


//Console.WriteLine(",Value:" + tab1['r']);


//foreach (var r in tab1.Keys)
//{
//    Console.Write("Key:"+r);
//    Console.WriteLine(",Value:" + tab1[r]);

//}

////foreach(string x in Name)
//Console.WriteLine(Name[0]);

