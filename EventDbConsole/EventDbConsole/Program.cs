using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EventDbConsole
{
    public class Program
    {
        static void Main(string[] args)
        {

            AdminData adminData = new AdminData();
            EventData ed = new EventData();
            CustomerData customerDt = new CustomerData();
            Console.WriteLine("press 1 to act as a superadmin");
            Console.WriteLine("press 2 to act as a admin");
            Console.WriteLine("press 3 to act as a customer");
            int selectedItem=Convert.ToInt32(Console.ReadLine());

            switch (selectedItem)
            {
                case 1:
                    Console.WriteLine("press 1 to add admin");
                    Console.WriteLine("press 2 to exit");
                    int adsel=Convert.ToInt32(Console.ReadLine());
                    switch (adsel)
                    {
                        case 1:
                            string result = adminData.InsertAdmin();
                            Console.WriteLine(result);
                            Console.ReadLine();
                            break;
                        case 2:
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("press 1 to see the admin table:");
                    Console.WriteLine("press 2 to see the available events:");
                    Console.WriteLine("press 3 to add(or)insert another Events:");
                    Console.WriteLine("press 4 to see how many customers wait for approval:");
                    Console.WriteLine("press 5 to approve(or)reject the Events:");
                    int sel=Convert.ToInt32(Console.ReadLine());
                    switch (sel)
                    {
                        case 1:
                            DataTable dt = adminData.SelectAdminData();
                            for (int i = 0; i < dt.Rows.Count; i++)//row iteration
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)//column iteration
                               {
                                    Console.Write(dt.Rows[i][j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 2:

                            break;
                        case 3:
                            string msg = ed.InsertEvent();
                            Console.WriteLine(msg);
                            //Console.ReadLine();
                            break;
                        case 4:
                            DataTable dt1 = customerDt.ssw();
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt1.Columns.Count; j++)
                                {
                                    Console.Write(dt1.Rows[i][j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 5:
                            Console.WriteLine("enter the mobile no:");
                            long mb=Convert.ToInt64(Console.ReadLine());

                            customerDt.up(mb);
                            break;
                        default:
                            Console.WriteLine("you choose wrong option");
                            break;
                    }
                  
                    break;
                case 3:
                    Console.WriteLine("press 1 to see the events:");
                    Console.WriteLine("press 2 to booked the event");
                    Console.WriteLine("press 3 to see the approved status");
                    int custsel=Convert.ToInt32(Console.ReadLine());
                    switch (custsel)
                    {
                        case 1:
                            DataTable data = customerDt.displayEvent();
                            for (int i = 0; i < data.Rows.Count; i++)
                            {
                                for (int j = 0; j < data.Columns.Count; j++)
                                {
                                    Console.Write(data.Rows[i][j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            Console.WriteLine("you want to book an event?(yes/no)");
                            string sel1 = Console.ReadLine();
                            if (sel1 == "yes")
                            {
                                Console.WriteLine("enter the event id:");
                                int abc = Convert.ToInt32(Console.ReadLine());
                                customerDt.newCustomer(abc);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the Registered Mobile Number to see the approved status:");
                            long ll = Convert.ToInt64(Console.ReadLine());
                            DataTable sss = customerDt.show(ll);
                            for (int i = 0; i < sss.Rows.Count; i++)
                            {
                                for (int j = 0; j < sss.Columns.Count; j++)
                                {
                                    Console.Write(sss.Rows[i][j] + "\t");
                                }
                                Console.ReadLine();
                            }
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("you choose wrong input");
                    break;

            }
            //----------------------------LEAVE THIS PART---------------------------------
            /*string result = adminData.InsertAdmin();
            Console.WriteLine(result);
            Console.ReadLine();

            DataTable dt = adminData.SelectAdminData();
            for (int i = 0; i < dt.Rows.Count; i++)//row iteration
            {
                for (int j = 0; j < dt.Columns.Count; j++)//column iteration
                {
                    Console.Write(dt.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            //EventData ed=new EventData();
            //string msg=ed.InsertEvent();
            //Console.WriteLine(msg);
            //Console.ReadLine();

            //CustomerData customerDt = new CustomerData();
            /*DataTable data = customerDt.displayEvent();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    Console.Write(data.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("you want to book an event?(yes/no)");
            string sel = Console.ReadLine();
            if (sel == "yes")
            {
                Console.WriteLine("enter the event id:");
                int abc = Convert.ToInt32(Console.ReadLine());
                customerDt.newCustomer(abc);
            }*/
            //to show the approved status-------------------------------
            /*Console.WriteLine("Enter the Registered Mobile Number to see the approved status:");
            long ll = Convert.ToInt64(Console.ReadLine());
            DataTable sss = customerDt.show(ll);
            for (int i = 0; i < sss.Rows.Count; i++)
            {
                for (int j = 0; j < sss.Columns.Count; j++)
                {
                    Console.Write(sss.Rows[i][j] + "\t");
                }
                Console.ReadLine();
            }*/
            //------------complete------
            //DataTable dt1=customerDt.ssw();
            //for (int i = 0; i < dt1.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt1.Columns.Count; j++)
            //    {
            //        Console.Write(dt1.Rows[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("enter the mobile no:");
            //long mb=Convert.ToInt64(Console.ReadLine());

            //customerDt.up(mb);






        }
    }
}
