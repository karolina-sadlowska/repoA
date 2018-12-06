﻿/*
 * C# Program to Perform all Basic Arithmetic Operations
 */
using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.Write("Enter the First Number : ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            var num2 = Convert.ToDouble(Console.ReadLine());
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
                return;
            }

            var option = Convert.ToChar(line);
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