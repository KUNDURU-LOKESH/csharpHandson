using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBanking
{
    public class CurrentAccount:Account,IRateofInterest
    {

        public  new void AccountDetails()
        {
            Console.WriteLine("your current account details are") ;
        }
        public override string WithdrawAmount()
        {
            return "you can withdraw 10000 per day";
        }
        public override double BalanceEnquiry()//abstract method implemented
        {
            return 10000;
        }
        public double RoiAmount()//interface implemented
        {
            return 1.5;
        }
    }
}
