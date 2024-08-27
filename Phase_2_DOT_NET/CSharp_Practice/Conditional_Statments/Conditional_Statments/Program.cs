

namespace Conditional_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If else statments 

            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine($"{number} is less than 100");
            }
            else if (number > 100)
            {
                Console.WriteLine($"{number} is greater than 100");
            }
            else {
                Console.WriteLine("Enter a valid number ");
            }
                
        }
    }
}