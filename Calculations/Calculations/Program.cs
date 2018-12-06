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
            int Num1, Num2;
            double result;
            char option;
            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exponentiation");
            Console.WriteLine("6. Square root");
            Console.Write("Enter the Operation you want to perform : ");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
            case '1':
                result = Num1 + Num2;
                Console.WriteLine("The result of Addition is : {0}", result);
                break;
            case '2':
                result = Num1 - Num2;
                Console.WriteLine("The result of Subtraction is : {0}", result);
                break;
            case '3':
                result = Num1 * Num2;
                Console.WriteLine("The result of Multiplication is : {0}", result);
                break;
            case '4':
                if (Num2 == 0)
                {
                    Console.WriteLine("Invalid input data!");
                    break;
                }
                result = 1.0f * Num1 / Num2;
                Console.WriteLine("The result of Division is : {0}", result);
                break;
            case '5':
                result = Math.Pow(Num1, Num2);
                Console.WriteLine("The result of Exponentiation is : {0}", result);
                break;
            case '6':
                result = Math.Sqrt(Num1);
                Console.WriteLine("The result of Square Root Operation is : {0}", result);
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
            }
            Console.ReadLine();
        }
    }
}