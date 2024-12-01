namespace _07._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            GreaterOfTwoValues(type);

            static void GreaterOfTwoValues(string type)
            {
                if (type == "string")
                {
                    string text1 = Console.ReadLine();
                    string text2 = Console.ReadLine();
                    if (String.Compare(text1, text2) > 0)
                    {
                        Console.WriteLine(text1);
                    }
                    else
                    {
                        Console.WriteLine(text2);
                    }
                }
                else if (type == "int")
                {
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    if (num1 > num2)
                    {
                        Console.WriteLine(num1);
                    }
                    else
                    {
                        Console.WriteLine(num2);
                    }
                }
                else if (type == "char")
                {
                    char one = char.Parse(Console.ReadLine());
                    char two = char.Parse(Console.ReadLine());
                    if (one > two)
                    {
                        Console.WriteLine(one);
                    }
                    else
                    {
                        Console.WriteLine(two);
                    }
                }      
            }
        }
    }
}
