using System;

namespace EmployeeTaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Basic Employee Calculation:");
            BasicEmployeeCalculation.Run();

            Console.WriteLine("\nRunning Improved Employee Calculation:");
            ImprovedEmployeeCalculation.Run();

            Console.WriteLine("\nRunning Detailed Employee Calculation:");
            DetailedEmployeeCalculation.Run();
        }
    }
}
