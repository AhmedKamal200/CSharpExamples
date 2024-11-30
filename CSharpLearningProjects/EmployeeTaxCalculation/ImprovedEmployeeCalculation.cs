using System;

namespace EmployeeTaxCalculation
{
    public class ImprovedEmployeeCalculation
    {
        public static void Run()
        {
            Employeee[] employees = new Employeee[2];

            // First employee details
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

            // Second employee details
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

            // Process and display the employee details with tax calculation
            foreach (var emp in employees)
            {
                var salary = emp.wage * emp.loggedhours;
                var taxAmount = salary * Employeee.Tax;
                var netSalary = salary - taxAmount;

                Console.WriteLine($"First Name: {emp.fname}");
                Console.WriteLine($"Last Name: {emp.lname}");
                Console.WriteLine($"Wage: {emp.wage}");
                Console.WriteLine($"Logged Hours: {emp.loggedhours}");
                Console.WriteLine($"Salary: {salary}");
                Console.WriteLine($"Tax Deducted ({Employeee.Tax * 100}%): {taxAmount}");
                Console.WriteLine($"Net Salary: {netSalary}");
            }
        }
    }
}
