using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppForBanking
{
    public class FileHandlingDemo
    {
        public void WriteFile()
        {
            FileStream fileStreamobj=new FileStream(@"D:\Csharp\Filedemo\UserDetails.txt", FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStreamobj);

            Console.Write("Enter your user id:");
            int userid=Convert.ToInt16(Console.ReadLine());
            sw.WriteLine("userid:"+userid);

            Console.Write("Enter your first name:");
            string firstName = Console.ReadLine();
            sw.WriteLine("firstName:" + firstName);

            Console.Write("Enter your last name:");
            string lastName = Console.ReadLine();
            sw.WriteLine("lastname:" + lastName);

            Console.Write("Enter your email:");
            string email = Console.ReadLine();
            sw.WriteLine("your email is:" + email);

            Console.Write("Enter your phone num:");
            long phoneNum = Convert.ToInt64(Console.ReadLine());
            sw.WriteLine("your phone number:" + phoneNum);

            sw.Close();
            fileStreamobj.Close();
            Console.WriteLine(" write operation completed for user");

        }
        public void Category()
        {
            FileStream fileStreamobj = new FileStream(@"D:\Csharp\Filedemo\CategoryDetails.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStreamobj);

            sw.WriteLine("categoryId\t categoryType");
            Console.WriteLine("Enter the category id:");
            int categoryId= Convert.ToInt16(Console.ReadLine());
            sw.Write(categoryId+"\t\t");

            Console.WriteLine("Enter the category type:");
            string categoryType = Console.ReadLine();
            sw.Write(categoryType);

            sw.Close();
            fileStreamobj.Close();
            Console.WriteLine("file operation for category completed");
        }
        public void product()
        {
            FileStream fileStreamobj = new FileStream(@"D:\Csharp\Filedemo\ProductDetails.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStreamobj);

            Console.Write("Enter the product id:");
            int productId = Convert.ToInt16(Console.ReadLine());
            sw.WriteLine("productId:" + productId);

            Console.Write("Enter the category type:");
            string categoryType = Console.ReadLine();
            sw.WriteLine("categoryType:" + categoryType);

            Console.Write("Enter the productname:");
            string productName = Console.ReadLine();
            sw.WriteLine("categoryType:" + productName);

            Console.Write("Enter the quantity:");
            string quantity = Console.ReadLine();
            sw.WriteLine("quantity:" + categoryType+"kg");

            Console.Write("Enter the price amount:");
            int price = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("price:" + price+"Rs");

            sw.Close();
            fileStreamobj.Close();
            Console.WriteLine("file operation for productDetails completed");
        }
        public void purchaseandSales()
        {
            FileStream fileStreamobj = new FileStream(@"D:\Csharp\Filedemo\Purchase.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStreamobj);

            Console.WriteLine("Enter the sales id:");
            int salesId = Convert.ToInt16(Console.ReadLine());
            sw.WriteLine("salesId:" + salesId);

            Console.WriteLine("Enter the product id:");
            int productId = Convert.ToInt16(Console.ReadLine());
            sw.WriteLine("productId:" + productId);

            Console.WriteLine("Enter the price amount:");
            int price = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("price:" + price + "Rs");

            Console.WriteLine("Enter the sales date:");
            string salesDate = Console.ReadLine();
            sw.WriteLine("salesdate:" + salesDate);

            sw.Close();
            fileStreamobj.Close();
            Console.WriteLine("file operation for purchase and sales completed");

        }
    }
}
