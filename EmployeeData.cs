using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDBconsole
{
    public class EmployeeData
    {
        public static string connectionstr = "Data Source=DESKTOP-LVVPEMG;Initial Catalog=BankDb;Integrated Security=True";
        public string InsertEmployee()
        {
            Console.WriteLine("enter employee id:");
            int empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("enter employee salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter employee role:");
            string emprole = Console.ReadLine();

            Console.WriteLine("enter employee Experience:");
            int empexp = Convert.ToInt32(Console.ReadLine());

            SqlConnection conn = new SqlConnection(connectionstr);
            string query = "insert into Employee values("+empid+",'"+name+"',"+salary+",'"+emprole+"',"+empexp+")";

            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();



            return "Employee data inserted";
        }
        public string UpdateEmployee()
        {
            return "";
        }
    }
}
