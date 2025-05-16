using System;
using System.Collections.Generic;

namespace EnkelKalkylator
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<string> historik = new List<string>();

            Console.WriteLine("Simple Calculator");

            bool fortsätt = true;
            while (fortsätt)
            {

                Console.WriteLine("Enter Operation (+, -, *, /) or E to Exit:");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToUpper(operation) == 'E')
                    return;

                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Invalid Number!");
                        return;
                }
                Console.WriteLine($"Result: {result}");
                historik.Add($"{num1} {operation} {num2} = {result}");
                Console.WriteLine("History:");
                foreach (var rad in historik)
                    Console.WriteLine(rad);
                Console.ReadKey();

                Console.WriteLine("Create a new calculation Y/N");
                char svar = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToUpper(svar) != 'Y')
                    fortsätt = false;
            }
        }
    }
}

