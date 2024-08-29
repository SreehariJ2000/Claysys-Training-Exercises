
namespace AdvanceCSharp
{
    delegate int SumDelegate(int x , int y);
    internal class DeligateProgram
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            SumDelegate sumObject = Sum;
            Console.WriteLine(sumObject(5, 7));

        }
    }
}
