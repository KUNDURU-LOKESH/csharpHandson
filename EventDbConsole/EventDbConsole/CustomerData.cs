using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EventDbConsole
{
    public class CustomerData
    {
        public static string connectionString = "Data Source=DESKTOP-LVVPEMG;Initial Catalog = Eventdb; Integrated Security = True";
        public DataTable displayEvent()
        {
            #region
            SqlConnection sq = new SqlConnection(connectionString);
            SqlDataAdapter adp = new SqlDataAdapter("select *from Event", sq);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion
         

        }
        public void newCustomer(int id)
        {
            #region 
            SqlConnection sq1conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("insert into Customer (eventID,venue) select eventID, venue from Event where eventID=" + id, connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Console.WriteLine("Enter the Event Date(YY-MM-DD)");
            object date = Console.ReadLine();

            Console.WriteLine("Enter the Timings(starttime - endtime )");
            object time = Console.ReadLine();

            string app = "Process in progress";

            Console.WriteLine("Enter your Mobile Number");
            long num = Convert.ToInt64(Console.ReadLine());

            SqlConnection sq2 = new SqlConnection(connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("update Customer set eventDate='" + date + "',eventTime='" + time + "',mobile=" + num + ",eventapproval='" + app + "' where eventID=" + id, connectionString);
            DataTable d = new DataTable();
            sqlDataAdapter.Fill(d);
            Console.WriteLine("We will notify your apporval soon");
            #endregion
        }
        public DataTable show(long a)
        {
            #region
            SqlConnection sq = new SqlConnection(connectionString);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Customer where mobile=" + a, sq);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion

        }
        public DataTable ssw()
        {
            #region
            SqlConnection sq = new SqlConnection(connectionString);
            SqlDataAdapter adp = new SqlDataAdapter("select *from Customer", sq);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion
        }
        public string up(long numb)
        {
            Console.WriteLine("Apporved or Not Approved");
            string asd = Console.ReadLine();
            #region
            SqlConnection sqm = new SqlConnection(connectionString);
            SqlDataAdapter adps = new SqlDataAdapter("update Customer set eventapproval='" + asd + "' where mobile=" + numb, sqm);
            DataTable dta = new DataTable();
            adps.Fill(dta);
            return "Updated";
            #endregion

        }
    }
}
