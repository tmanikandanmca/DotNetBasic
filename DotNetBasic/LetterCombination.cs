using DotNetBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic
{
    internal class LetterCombination
    {
       public string[] arr = new string[10];

        public LetterCombination()
        {
            arr[2] = "abc";
            arr[3] = "def";
            arr[4] = "ghi";
            arr[5] = "jkl";
            arr[6] = "mno";
            arr[7] = "pqrs";
            arr[8] = "tuv";
            arr[9] = "wxyz";
        }

        public List<string> Combinations(int NumberOfChar, int[] number)
        {
            List<string> res= new List<string>();

            foreach(char step1 in arr[number[0]])
            {
                foreach (char step2 in arr[number[1]])
                {
                    string r = step1.ToString() + step2.ToString();
                    res.Add(r);
                }

            }

            

            return res;
        }
      
 
    }
}




//LetterCombination letCom = new LetterCombination();

//Console.WriteLine("How many numbers do you want to add?");
//int x = 2;
//int[] a = new int[x];
//for (int i = 0; i < x; i++)
//{
//    Console.WriteLine("Enter the Number:");
//    a[i] = Convert.ToInt32(Console.ReadLine());
//}

//List<string> res = letCom.Combinations(x, a);
//foreach (string s in res)
//{
//    Console.WriteLine(s);
//}

//Console.ReadKey();