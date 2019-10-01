using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, i, j;
            int[,] triangleArray = new int[100, 100];
            Console.WriteLine("Enter no. of rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Values");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    //Getting input from the user
                    triangleArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
            Console.WriteLine("\nThe Input Triangle Is: \n");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    //Printing the triangle array
                    Console.Write(triangleArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            for (i = row - 2; i >= 0; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    //Calculating the maximum sum in a path
                    if (triangleArray[i + 1, j] > triangleArray[i + 1, j + 1])
                    {
                        triangleArray[i, j] += triangleArray[i + 1, j];
                    }
                    else
                    {
                        triangleArray[i, j] += triangleArray[i + 1, j + 1];
                    }
                }
            }
            //Printing the maximum sum
            Console.WriteLine("\nThe Max Sum in a Path is: \n");
            Console.Write("{0}", triangleArray[0, 0]);
            Console.ReadLine();
        }
    }
}
