﻿namespace _04._1CalculateRectangleAreaReturnMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateRectangleArea(width, length));          

            static int CalculateRectangleArea(int width, int length)
            {
                int area = width * length;
                return area;
            }
        }
    }
}
