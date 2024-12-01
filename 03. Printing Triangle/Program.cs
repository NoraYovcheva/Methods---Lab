﻿namespace _03._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);

            static void PrintTriangle(int n)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
                for (int row = n - 1; row >= 1; row--)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}

