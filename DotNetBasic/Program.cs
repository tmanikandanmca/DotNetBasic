// See https://aka.ms/new-console-template for more information
using DotNetBasic;

Console.WriteLine("Hello, World!");


PropertyBinding pb = new PropertyBinding();
 

pb.GetAge();

int age=pb.GetAge();
Console.WriteLine(age);
 

int x = 25, y = 5;
int addition =0, subtraction;
ValuesvsReference.AddData(x, y,ref addition,out subtraction);


