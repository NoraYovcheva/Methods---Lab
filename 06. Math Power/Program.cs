namespace _06._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNum = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(baseNum, power));
          

            static double MathPower (int baseNum, int power)
            {
                double sum = Math.Pow(baseNum, power);
                return sum;
            }
        }
    }
}
