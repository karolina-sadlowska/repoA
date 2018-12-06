/*
 * C# Program to Perform all Basic Arithmetic Operations
 */
using System;

namespace Calculations
{
    class Program
    {
        public static bool ProvideParameters(out double m, out double n)
        {
            Console.Write("Enter the First Number : ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            n = Convert.ToDouble(Console.ReadLine());

            return true;
        }

        public static bool ProvideOperation(out char operation)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform : ");

            var line = Console.ReadLine();
            if (line == null)
            {
                Console.WriteLine("Invalid input!");
                operation = '';
                return false;
            }

            operation = Convert.ToChar(line);

            return true;
        }

        static void Main(string[] args)
        {
            double result;

            if (!ProvideParameters(out var num1, out var num2))
            {
                Console.WriteLine("Could not read input parameters!");
                return;
            }

            if (!ProvideOperation(out var option))
            {
                Console.WriteLine("Could not read operation kind!");
                return;
            }

            switch (option)
            {
            case '1':
                result = num1 + num2;
                Console.WriteLine("The result of Addition is : {0}", result);
                break;
            case '2':
                result = num1 - num2;
                Console.WriteLine("The result of Subtraction is : {0}", result);
                break;
            case '3':
                result = num1 * num2;
                Console.WriteLine("The result of Multiplication is : {0}", result);
                break;
            case '4':
                if (num2 == 0)
                {
                    Console.WriteLine("Invalid input data!");
                    break;
                }

                result = num1 / num2;
                Console.WriteLine("The result of Division is : {0}", result);
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
            }
            Console.ReadLine();
        }
    }
}