using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EventDbConsole
{
    public class AdminData
    {
        public static string connectionString = "Data Source=DESKTOP-LVVPEMG;Initial Catalog = Eventdb; Integrated Security = True";
        public string InsertAdmin()
        {
            Console.WriteLine("enter the admin id:");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the admin name:");
            string name=Console.ReadLine();

            Console.WriteLine("Enter the admin Role:");
            string role = Console.ReadLine();

            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into Admin values("+id+",'"+name+"','"+role+"')",sqlConn);
            sqlConn.Open(); 
            cmd.ExecuteNonQuery();
            sqlConn.Close();    
            return "inserted";
        }
        public string updateAdmin()
        {
            return "";
        }
        public DataTable SelectAdminData()
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);//connection establishment
            SqlCommand cmd = new SqlCommand("select * from Admin", sqlconn);
            sqlconn.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statement//read row by row
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //Datatable,dataset
            sqlconn.Close();
            return dataTable;
        }

    }
}
