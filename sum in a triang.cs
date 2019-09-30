using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int r, i, j;
            int[,] a = new int[10, 10];
            Console.WriteLine("Enter no. of rows");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Values");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    a[i,j]= int.Parse(Console.ReadLine());
                    //Console.WriteLine(data);
                    //a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < r; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(a[i,j]);
                    //a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = r - 2; i >= 0; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    if (a[i + 1, j] > a[i + 1, j + 1])
                    {
                        a[i, j] += a[i + 1, j];
                    }
                    else
                    {
                        a[i, j] += a[i + 1, j + 1];
                    }
                }
            }
            Console.Write("{0}",a[0,0]);
            Console.ReadLine();
        }
    }
}