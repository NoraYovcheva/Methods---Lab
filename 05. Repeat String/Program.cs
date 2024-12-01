namespace _05._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, count));

            static string RepeatString(string text, int count)
            {
                string result = "";
                for (int i = 1; i <= count; i++)
                {
                    result += text; 
                }
               return result;
            }
        }
    }
}
