using System;
using System.Collections.Generic;

namespace EnkelKalkylator
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<string> historik = new List<string>();

            Console.WriteLine("Simpel Kalkylator");

            bool fortsätt = true;
            while (fortsätt)
            {

                Console.WriteLine("Ange Operation (+, -, *, /) eller A för att avsluta:");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToUpper(operation) == 'A')
                    return;

                Console.WriteLine("Ange första talet:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ange andra talet:");
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
                        Console.WriteLine("Ogiltig tal!");
                        return;
                }
                Console.WriteLine($"Resultat: {result}");
                historik.Add($"{num1} {operation} {num2} = {result}");
                Console.WriteLine("Historik:");
                foreach (var rad in historik)
                    Console.WriteLine(rad);
                Console.ReadKey();

                Console.WriteLine("Skapa en ny beräkning J/N");
                char svar = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToUpper(svar) != 'J')
                    fortsätt = false;
            }
        }
    }
}

