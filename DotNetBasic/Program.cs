// See https://aka.ms/new-console-template for more information
using DotNetBasic;
using System;
using System.Collections;


string Folder = "D:\\Move\\WIP";
 

Folder = "D:\\Move\\Ready";
DirectoryInformation.GetfileInFolder(Folder);

string fileName = "test1.txt";

File.Create(Folder + fileName);


//Console.WriteLine("Enter the Number:");
//int x = Convert.ToInt32(Console.ReadLine());
//string x1 = Console.ReadLine();


//bool res = false;
//bool res1 = false;

//while(x>0)
//{
//    int y = x % 10;
//    if(y==0)
//    {
//        res1=true;
//        break;
//    }
//    x=x/10;
//}

//var outoput = res1 ? "Duck Number" : "Not Duck Number";

//Console.Write(outoput);

//foreach (char c in x1)
//{


//    if(c =='0')
//    {
//        res = true; 
//        break;
//    }
//}

//if(res)
//{
//    Console.WriteLine("Duck Number");
//}

//else
//    Console.WriteLine("Not Duck Number");







Console.ReadKey();


// 
