using System.Reflection;

namespace Reflection_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Type type = typeof(BankAccount);

            Console.WriteLine("Class Name: " + type.Name);

            // constructing properties
            Console.WriteLine("\nProperties:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine($"- {prop.Name} ({prop.PropertyType})");
            }

            // constructing methods
            Console.WriteLine("\nMethods:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"- {method.Name}");
            }

            // constructng Events
            Console.WriteLine("\nEvents:");
            foreach (var eventInfo in type.GetEvents())
            {
                Console.WriteLine($"- {eventInfo.Name}");
            }
        }
    }
}
