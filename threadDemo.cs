using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Myproject
{
    public class threadDemo
    {
        public void display()
        {
            Console.WriteLine("welcome");
        }
        //Parallel.Invoke(getdetails, getinfo)
        public void getdetails()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void getinfo()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        public void ShowData(string s)
        {
            Console.WriteLine(s);
        }
        public void DisplayFruits()
        {
            //data and functions here is executed parallerly not in a sequencial manner 
            List<string> fruitCollections = new List<string>()
            {
                 "apple","banana","kiwi","mango","grapes"
            };
            Parallel.ForEach(fruitCollections, car => ShowData(car));

            //execution of 2 function parallerly 
            Parallel.Invoke(ShowSellerReport, ShowBuyerReport);

        }


        public void ShowBuyerReport()
        {
            char buyerName = 'a';
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(buyerName++);

                //pauses for 100 mili second
                Thread.Sleep(100);
            }

        }

        public void ShowSellerReport()
        {
            int sellerName = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sellerName++);
                Thread.Sleep(100);
            }
        }

    }
}
