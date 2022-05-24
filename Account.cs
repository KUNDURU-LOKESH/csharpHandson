using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForBanking
{
    public abstract class Account
    {
        public virtual void AccountDetails()
        {
            Console.WriteLine("your account details are");
        }
        public abstract String WithdrawAmount();
        public abstract double BalanceEnquiry();
    }

    interface IDeposit 
    {
        int DepositAmount();
    }
    interface IRateofInterest
    {
        double RoiAmount();
    }
}
