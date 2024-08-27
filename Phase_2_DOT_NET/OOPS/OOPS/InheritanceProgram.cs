
namespace OOPS
{
    class ParentClass
    {
        public void ParentMethod(string name)
        {
            Console.WriteLine(name);
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("child class executed sucessfully");
        }
    
    }

    internal class InheritanceProgram
    {
        static void Main(string[] args)
        {
           ChildClass obj = new ChildClass();
                obj.ParentMethod("Parent class executed");
        }
    }
}
