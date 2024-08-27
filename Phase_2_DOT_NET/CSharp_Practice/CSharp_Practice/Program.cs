using System;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine(" My name is  " + name);

            Console.WriteLine(" Enter your Age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My Age is " + age);

            // Data types  and varibles

            int num = 5;               
            double doubleNum = 5.99;  
            char letter = 'D';         
            bool boolValue = true;
            Console.WriteLine(num);
            Console.WriteLine(doubleNum);
            Console.WriteLine(letter);
            Console.WriteLine(boolValue);

            // Working with strings
            string greeting = "Hello , How are you";
            Console.WriteLine(greeting.ToUpper());   
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.Length);

            string firstName = "Sreehari ";
            string lastName = "J";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine("Concatination ",fullName);
            Console.WriteLine(" First letter of name " + firstName[0]);
            Console.WriteLine("Get the index " + firstName.IndexOf('h'));





        }
    }
}
