using System.Net;
using System.Xml.Linq;

namespace NestedTypes
{
     class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            Console.WriteLine($"employee ID: {emp.Id} : Employee Name: {emp.Name} is covered by policy {emp.Ins.PolicyId} of company {emp.Ins.CompanyName}");
        }
    }
    class employee
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public  insurance Ins{get;set;}
        public employee() =>
            (Id, Name, Ins) = (1, "Ahmed", new insurance { PolicyId = 1, CompanyName = "HDFC" });
        public class insurance
        {
            public int PolicyId { get; set; }
            public string CompanyName { get; set; }
        }
    }
    
    class  department
    {
        private int id{get;set;}
        private string name{get;set;}
    }
}

