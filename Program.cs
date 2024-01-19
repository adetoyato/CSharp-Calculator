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

                Console.WriteLine("Enter First Number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Second Number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operation: ");
                Console.WriteLine("\t+ : Addition");
                Console.WriteLine("\t- : Subtraction");
                Console.WriteLine("\t* : Multiplication");
                Console.WriteLine("\t/ : Division");
                Console.Write("Enter operator: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid option: Operation not found.");
                        break;
                }
                Console.WriteLine("Continue using the calculator? (Y = Yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Understood. Shutting Down... (Press Enter to Exit.)");
            Console.ReadKey();
        }
    }
}