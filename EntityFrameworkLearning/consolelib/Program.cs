using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Data;
using EntityFramework.Data.Entities;

namespace consolelib
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CRUDmanger obj = new CRUDmanger();

            //Console.WriteLine("Adding a new Employee");
            //obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
            //obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
            //PrintAllEmployees();

            //Console.WriteLine("Updating Employee with EmployeeId 2");
            //obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
            //var employee = obj.GetEmplpoyeeById(2);
            //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

            //Console.WriteLine("Deleting Employee details for EmployeeId 2");
            //obj.Delete(2);
            //PrintAllEmployees();

            //Console.ReadLine();

            Empedu emp=new Empedu();
            //emp.Insert(new EmployeeEducation { CourseName="civil",UniversityName="lbrce",PassingYear=2022,MarksPercentage=85});


            Console.WriteLine("Updating Employee with EmployeeId 2");
            
            emp.Update( 2,new EmployeeEducation { CourseName = "ece", UniversityName = "vit", PassingYear = 2022, MarksPercentage = 85 });

            Console.WriteLine("Deleting Employee details for EmployeeId 2");
            emp.delete(2);

            Console.ReadLine();

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
