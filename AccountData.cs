using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDBconsole
{
    public class AccountData
    {
        public static string sqlconnectionStr = "Data Source=DESKTOP-LVVPEMG;Initial Catalog=BankDb;Integrated Security=True";
        public string InsertAccount()
        {
            Console.WriteLine("enter account id:");
            int accid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter account holder name:");
            string name = Console.ReadLine();

            Console.WriteLine("enter account holder age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter type of account :");
            string acctype = Console.ReadLine();

            Console.WriteLine("enter account holder address:");
            string address = Console.ReadLine();

            //insert account data into sql server
            SqlConnection sqlconn = new SqlConnection(sqlconnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Account values(" + accid + ",'" + name + "'," + age + ",'" +acctype + "','" + address + "')", sqlconn);
            sqlconn.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlconn.Close();//connection state is close

            return "Inserted account details";
        }
        public string UpdateAccount()
        {
            return "";
        }
        public string DeleteAccount()
        {
            return "";
        }
    }
}
