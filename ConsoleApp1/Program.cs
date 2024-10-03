using System;

namespace EnkelKalkylator
{
    class Program
    { 
        static void Main(string[] args)
        {
            bool NyBeräkning = true;
            while (NyBeräkning)
            {
                Console.WriteLine("Enkel Kalkylator");
                Console.WriteLine("Ange operation (+, -, *, /): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine("\nAnge första talet: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ange andra talet: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = 0;
                switch (operation)
                {
                    case
                        '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case
                        '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        if (result == 0)
                        {
                            //för
                            Console.WriteLine("ogiltig operation. Division med 0 ej tillåtet");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Ogiltig operation.");
                        return;
                }

                Console.WriteLine($"Resultat: {result}");
                Console.WriteLine("Tryck valfri knapp för att göra ny beräkning");
                char knapp = Console.ReadKey(true).KeyChar;
            }
        }
    }
}