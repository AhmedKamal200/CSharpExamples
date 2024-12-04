using System.Collections;

namespace Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            people.Add(new Person("Ahmed", "Kamal"));
            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine($"Length:{people.Count}");
            Console.WriteLine($"empty:{people.Count==0}");

            Console.WriteLine("-------------------");
            var arr=new ArrayList();
            arr.Add(1);
            arr.Add("Good morning");
            arr.Add(new Person("erwin","smith"));
            arr.Add(new {Fname="levai",LName="akrman"});
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Length:{arr.Count}items");
            Console.WriteLine($"empty:{arr.Count == 0}");
            Console.ReadKey();

            
        }
        public class Person
        {
            private string fname;
            private string lname;
            public Person(string fname, string lname)
            {
                this.fname=fname;
                this.lname=lname;
            }
            public override string ToString()
            {
                return $"'{fname}{lname}'";
            }
        }
    }
}
