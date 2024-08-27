
namespace ClassAndObjects
{
    class Program
    {
     
        public Program(string color) { 
            Console.WriteLine(color);
        }

        void SetData()
        {
            Console.WriteLine("success");
        }

        static void Main(string[] args)
        {
            Program myObj = new Program("red");
            myObj.SetData();
        }
    }
}