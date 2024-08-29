using System;
using System.Collections.Generic;
using System.Linq; // Required for LINQ operations
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharp
{
    internal class LinqProgram
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers
                         .Where(n => n % 2 == 0)
                         .OrderByDescending(n => n);

            Console.WriteLine("Even numbers in descending order:");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
