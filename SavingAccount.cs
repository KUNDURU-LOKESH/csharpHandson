using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBanking
{
    public class SavingAccount:Account,IRateofInterest
    {
        public int accountNumber=123;
        public string customerName { set; get; }
        public override void  AccountDetails()
        {
            Console.WriteLine("your saving account details are:") ;
            Console.WriteLine(accountNumber) ;
        }
        public override String WithdrawAmount()
        {
            return "you can withdraw only 5000 per day";
            
        }
        public override double BalanceEnquiry()//abstract method implemented
        {
            return 50000;
        }
        public double RoiAmount()//interface implemented
        {
            return 2;
        }
    }
}
