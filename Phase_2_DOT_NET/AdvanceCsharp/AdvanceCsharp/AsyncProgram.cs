using System;
using System.Threading.Tasks;

namespace AdvanceCsharp
{
    internal class AsyncProgram
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting data fetch");

            string result = await FetchDataAsync();

            Console.WriteLine($"Data fetched: {result}");
        }

        static async Task<string> FetchDataAsync()
        {
            await Task.Delay(2000);

            return "Hello, World!";
        }
    }
}
