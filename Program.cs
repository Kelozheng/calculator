using System;

namespace mycalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose the calculator (+,-,*,/):");
            string a = Console.ReadLine();
            Console.WriteLine("Please enter the first number:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            float c = float.Parse(Console.ReadLine());
            if (a == "+")
            {
                Console.WriteLine("the result is ");
                Console.WriteLine(b + c);
            }

            else if (a == "-")
            {
                Console.WriteLine("the result is ");
                Console.WriteLine(b - c);
            }

            else if (a == "*" )
            {
                Console.WriteLine("the result is ");
                Console.WriteLine(b * c);
            }
            else if (a == "/")
            {
                Console.WriteLine("the result is ");
                Console.WriteLine(b / c);
            }
            else
                Console.WriteLine("Invalid calculator, Please try again!");
            Console.ReadLine();

        }
    }
}
