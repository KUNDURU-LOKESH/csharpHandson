using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Data;
using EntityFramework.Data.Entities;

namespace ClassLibConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            CRUDmanger obj = new CRUDmanger();

            Console.WriteLine("Adding a new Employee");
            obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
            obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
            PrintAllEmployees();

        }

        private static void PrintAllEmployees()
        {
            Console.WriteLine("Printing all Employees");
            CRUDmanger obj = new CRUDmanger();
            foreach (Employee employee in obj.GetAllEmployees())
            {
                Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
            }
        }
    }
}
