using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("=================");
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("=================");

                Console.Write($"Enter First Number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Enter Second Number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Operations Available: ");
                Console.WriteLine("\t+ or 1 : Addition");
                Console.WriteLine("\t- or 2 : Subtraction");
                Console.WriteLine("\t* or 3 : Multiplication");
                Console.WriteLine("\t/ or 4 : Division");
                Console.Write($"Enter operator selected: ");

                switch (Console.ReadLine())
                {
                    case "+":
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                    case "4":
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid option: Operation not found.");
                        break;
                }
                Console.WriteLine("Continue using the calculator? (Y = Yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Understood. Shutting Down... (Press Any Key to Terminate Process.)");
            Console.ReadKey();
        }
    }
}