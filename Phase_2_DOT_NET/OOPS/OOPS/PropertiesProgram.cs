
namespace OOPS
{
    public class AddProperty
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class PropertiesProgram
    {
        static void Main(string[] args)
        {
            AddProperty obj = new AddProperty();
            obj.Name = "sree";
            Console.WriteLine(obj.Name);
            
        }
    }
}
