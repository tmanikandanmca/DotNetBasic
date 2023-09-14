using DotNetBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DotNetBasic
{
    internal class Matrix
    {

        public int[,] GetMatrixValues(int x, int y)
        {
            int[,] DArray = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    DArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return DArray;

        }

        //a
        // 2 3
        // 4 6


        //
        // 1 3
        // 4 8


        public int[,] AddMatrix(int[,] a, int[,] b, int x, int y)
        {
            int[,] DArray = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    DArray[i, j] = a[i, j] + b[i, j];
                }
            }


            return DArray;
        }



        public int[,] SubMatrix(int[,] a, int[,] b, int x, int y)
        {
            int[,] DArray = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    DArray[i, j] = a[i, j] - b[i, j];
                }
            }
            return DArray;
        }

        public void PrintMatrix(int[,] a, int x, int y)
        {

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
 

        
        public int[,] MultiMatrix(int[,] a, int[,] b, int x, int y)
        {
            int[,] DArray = new int[x, y];
            int sum = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for(int k = 0; k < y; k++)
                    {
                        sum = sum + (a[i,k] * b[k,j]);
                    }
                    DArray[i,j] = sum;
                    sum = 0;

                }
            }
            return DArray;
        }
    }
}




//Matrix m = new Matrix();

//Console.WriteLine("Enter the Row Size:");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the Column Size:");
//int y = Convert.ToInt32(Console.ReadLine());

//int[,] mat1 = new int[x, y];
//int[,] mat2 = new int[x, y];
//int[,] res = new int[x, y];


//Console.WriteLine("Enter First Matrix");
//mat1 = m.GetMatrixValues(x, y);

//Console.WriteLine("Enter Second Matrix");
//mat2 = m.GetMatrixValues(x, y);


//Console.WriteLine("Sum of 2 Matrix");
//res = m.AddMatrix(mat1, mat2, x, y);
//m.PrintMatrix(res, x, y);

//Console.ReadKey();