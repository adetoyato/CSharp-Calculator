﻿using System;

public static class SimpleCalculator
{
    enum Operations
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Loading Calculator, please wait...");
        Console.WriteLine();
        Thread.Sleep(1000);
        Calculator();
    }
    static void Calculator()
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        Console.Write($"Enter first number: "); //Asks to enter first number
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Operations operators = Operations.Addition;

        Console.WriteLine("Select operator to use using arrow keys: "); //Using the arrow keys, user must choose what operator to use to compute for the answer
        Console.WriteLine("Up Arrow Key: Addition (+)\nDown Arrow Key: Subtraction (-)\nLeft Arrow Key: Multiplication (*)\nRight Arrow Key: Division (/)");
        Console.WriteLine();
        ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key) //Gives the function for the arrow keys
            {
                case ConsoleKey.UpArrow:
                    operators = Operations.Addition;
                    break;
                case ConsoleKey.DownArrow:
                    operators = Operations.Subtraction;
                    break;
                case ConsoleKey.LeftArrow:
                    operators = Operations.Multiplication;
                    break;
                case ConsoleKey.RightArrow:
                    operators = Operations.Division;
                    break;
            }
        Console.WriteLine($"Selected operator to be used: {operators}"); //Shows what operator is to be used
        Console.WriteLine();
        Console.Write($"Enter second number: "); //Asks for second number to complete computation
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        switch (operators)
        {
            case Operations.Addition: //Addition formula
                result = num1 + num2;
                Console.WriteLine($"Sum: {num1} + {num2} = {result}");
                Console.WriteLine();
                break;
            case Operations.Subtraction: //Subtraction formula
                result = num1 - num2;
                Console.WriteLine($"Difference: {num1} - {num2} = {result}");
                Console.WriteLine();
                break;
            case Operations.Multiplication: //Multiplication formula
                result = num1 * num2;
                Console.WriteLine($"Product: {num1} * {num2} = {result}");
                Console.WriteLine();
                break;
            case Operations.Division: //Division formula
                result = num1 / num2;
                Console.WriteLine($"Quotient: {num1} / {num2} = {result}");
                Console.WriteLine();
                break;
        }
        Console.WriteLine("Would you like to continue using the calculator? Y = Yes || N = No"); //Asks if user would like to continue using calculator
        Console.WriteLine();

        bool inputTrue = false;
        do
        {
            String booleanInput = Console.ReadLine();
            Console.WriteLine();

            if (booleanInput.Equals("yes", StringComparison.OrdinalIgnoreCase) || booleanInput.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Calculator();
            }
            else if (booleanInput.Equals("no", StringComparison.OrdinalIgnoreCase) || booleanInput.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Calculator Shutting Down...");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please use only Y or N in your input.");
            }
        } while (!inputTrue);
    }
}