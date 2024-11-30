using System;

namespace EmployeeTaxCalculation
{
    class BasicEmployeeCalculation
    {
        public static void Run()
        {
            Employeee[] employees = new Employeee[2];
            Employeee e1 = new Employeee();
            Console.WriteLine("Enter the first employee details:");
            Console.Write("First Name: ");
            e1.fname = Console.ReadLine();
            Console.Write("Last Name: ");
            e1.lname = Console.ReadLine();
            Console.Write("Wage: ");
            e1.wage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Logged Hours: ");
            e1.loggedhours = Convert.ToDouble(Console.ReadLine());
            employees[0] = e1;

            Employeee e2 = new Employeee();
            Console.WriteLine("Enter the second employee details:");
            Console.Write("First Name: ");
            e2.fname = Console.ReadLine();
            Console.Write("Last Name: ");
            e2.lname = Console.ReadLine();
            Console.Write("Wage: ");
            e2.wage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Logged Hours: ");
            e2.loggedhours = Convert.ToDouble(Console.ReadLine());
            employees[1] = e2;

            foreach (var emp in employees)
            {
                var netSalary = emp.wage * emp.loggedhours - (emp.wage * Employeee.Tax);
                Console.WriteLine($"First Name: {emp.fname}");
                Console.WriteLine($"Last Name: {emp.lname}");
                Console.WriteLine($"Wage: {emp.wage}");
                Console.WriteLine($"Logged Hours: {emp.loggedhours}");
                Console.WriteLine($"Net Salary: {netSalary}");
            }
        }
    }
}
