namespace inheirtance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Developer(1, "ahmed", 190, 10, true);
            Employee emp1 = new Maintanence(1, "hossam", 190, 10);
            Employee emp2 = new Manager(1, "ashraf", 190, 10);
            Employee emp3 = new Sales(1, "omar", 190, 10, 20,0.03m);

            Console.WriteLine(emp);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);



        }
    }
}