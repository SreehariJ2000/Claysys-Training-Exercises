using System;

namespace OOPS
{
    abstract class Animal
    {
        public abstract void animalSound();
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog makes a sound");
        }
    }
    class AbstractclassProgram
    {
        static void Main(string[] args)
        {
            Dog dogObject = new Dog();
            dogObject.animalSound();
        }
    }
}
