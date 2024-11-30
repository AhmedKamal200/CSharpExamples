class Program
{
    static void Main(string[] args)
    {
        // مصفوفة الموظفين
        var emps = new Employee[]
        {
            new Employee { Id = 1, Name = "Issam A", Gender = "M", TotalSales = 65000m },
            new Employee { Id = 2, Name = "Reem S", Gender = "F", TotalSales = 50000m },
            new Employee { Id = 3, Name = "Suzan B", Gender = "F", TotalSales = 65000m },
            new Employee { Id = 4, Name = "Sara A", Gender = "F", TotalSales = 40000m },
            new Employee { Id = 5, Name = "Salah C", Gender = "M", TotalSales = 42000m },
            new Employee { Id = 6, Name = "Rateb A", Gender = "M", TotalSales = 30000m },
            new Employee { Id = 7, Name = "Abeer C", Gender = "F", TotalSales = 16000m },
            new Employee { Id = 8, Name = "Marwan M", Gender = "M", TotalSales = 15000m }
        };

        // عرض الموظفين بناءً على شروط مختلفة باستخدام دالة واحدة
        Console.WriteLine("Employees with sales above 50,000:");
        Employee.Display(emps, emp => emp.TotalSales > 50000m);

        Console.WriteLine("\nEmployees with sales below 30,000:");
        Employee.Display(emps, emp => emp.TotalSales < 30000m);

        Console.WriteLine("\nFemale employees:");
        Employee.Display(emps, emp => emp.Gender == "F");

        Console.ReadKey();
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal TotalSales { get; set; }
    public string Gender { get; set; }

    // تعريف delegate داخل الكلاس
    public delegate bool EmployeeFilter(Employee employee);

    // دالة عامة لعرض الموظفين
    public static void Display(Employee[] employees, EmployeeFilter filter)
    {
        foreach (var emp in employees)
        {
            if (filter(emp)) // تطبيق الشرط الممرر باستخدام الـ delegate
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Sales: {emp.TotalSales}, Gender: {emp.Gender}");
            }
        }
    }
}
