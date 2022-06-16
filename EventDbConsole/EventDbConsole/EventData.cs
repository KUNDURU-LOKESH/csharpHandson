using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EventDbConsole
{
    public class EventData
    {
        public static string connectionString = "Data Source=DESKTOP-LVVPEMG;Initial Catalog = Eventdb; Integrated Security = True";
        public string InsertEvent()
        {
            Console.WriteLine("enter the Event id:");
            int evid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Type:");
            string type = Console.ReadLine();

            Console.WriteLine("Enter the Equipments Required:");
            string equip = Console.ReadLine();

            Console.WriteLine("Enter the Venue place:");
            string venue = Console.ReadLine();

            Console.WriteLine("enter the Event cost:");
            int cost = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into Event values(" + evid + ",'" + type + "','" + equip + "','"+venue+"',"+cost+")", sqlConn);
            sqlConn.Open();
            cmd.ExecuteNonQuery();
            sqlConn.Close();
            return "inserted";

        }
        public string updateEvent()
        {
            Console.WriteLine("enter the Event id to update:");
            int evid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Type to update:");
            string type = Console.ReadLine();

            Console.WriteLine("Enter the Equipments Required to update:");
            string equip = Console.ReadLine();

            Console.WriteLine("Enter the Venue place to update:");
            string venue = Console.ReadLine();

            Console.WriteLine("enter the Event cost to update:");
            int cost = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("update Event set EventType='" + type + "', Equipreq=" + equip + ",venue='" + venue + "',cost=" + cost + "where Eventid=" + evid, sqlConn);
            sqlConn.Open();
            int a = sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
            if (a == 0)
            {
                return "Not updated";
            }
            return "updated";
        }
    }
}
