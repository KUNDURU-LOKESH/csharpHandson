using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBanking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandlingDemo obj=new FileHandlingDemo();
            obj.WriteFile();
            obj.Category();
            obj.product();
            obj.purchaseandSales();
            /*SavingAccount obj = new SavingAccount();
            double a=obj.BalanceEnquiry();
            Console.WriteLine(a);
            Console.WriteLine("Enter your name:");
            obj.customerName = Console.ReadLine();
            Console.WriteLine("your name is:" + obj.customerName);
            obj.AccountDetails();
            //string b = obj.AccountDetails();
            //Console.WriteLine(b);
            CurrentAccount obj1 = new CurrentAccount();
            double c = obj1.BalanceEnquiry();
            Console.WriteLine(c);
            //string d = obj1.AccountDetails();
            //Console.WriteLine(d);
            
            //obj1.Name=Console.ReadLine();
            //Console.WriteLine("Your name is :" + obj1.Name);

            Console.Read();*/

        }
    }
}
