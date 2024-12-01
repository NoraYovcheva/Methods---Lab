namespace _04._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int area = 0;

            PrintRectangleArea(width, length, area);

            static void PrintRectangleArea(int width, int length, int area)
            {
                area = width * length;
                Console.WriteLine(area);
            }
        }
    }
    
}
