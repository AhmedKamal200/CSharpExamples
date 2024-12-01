namespace iEnumerator_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Id = 100, Name = "Ahmed", Salary = 1000m, Department = "Cs" };
            Employee e2= new Employee { Id = 100, Name = "Ahmed", Salary = 1000m, Department = "Cs" };
            Employee e3= new Employee { Id = 100, Name = "Ahmed", Salary = 1000m, Department = "Cs" };

           // Console.WriteLine(e1==e2); compare refence so false
            Console.WriteLine(e1.Equals(e2)); //compare content but must over ride equals and gethashcode methods
            Console.WriteLine(e2 == e3); // this compares content using the operator overload method


        }
        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
            public override bool Equals(object obj)
            {
             if(obj ==null || !(obj is Employee ))
                    return false;
             var emp = obj as Employee;

                return this.Id == emp.Id
                       && this.Name == emp.Name
                       && this.Salary == emp.Salary
                       && this.Department == emp.Department;
            }

            public override int GetHashCode()
            {
                var hash = 13;
                hash = (hash * 7) + Id.GetHashCode();
                hash = (hash * 7) + Name.GetHashCode();
                hash = (hash * 7) + Salary.GetHashCode();
                hash = (hash * 7) + Department.GetHashCode();
                return base.GetHashCode();
            }
            public static bool operator ==(Employee left, Employee right) => left.Equals(right);
            public static bool operator !=(Employee left, Employee right) => !left.Equals(right);



        }
    }
}
