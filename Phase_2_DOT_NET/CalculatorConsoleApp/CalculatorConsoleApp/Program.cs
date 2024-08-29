using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");

        try
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            string opetator = Console.ReadLine();
            char op = opetator[0];

            double result = 0;

            switch (op)
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
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input format. Please enter numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
