using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Library
{
    public class Savings:Bank,IInterest
    {
        public Savings(string name, double amount)
        {
            AccHolderName = name;
            Balance = amount;
        }

        //interface implementation of method
        public double CalculateInterest()
        {
            return Balance*0.04;
        }

        public override void Withdraw(double amount)
        {
            if(Balance-amount<0)
            {
                Balance -= amount;
            }
            else
            {
                //throw new BalanceException("Amount grater than Balance");
            }
        }


    }
}
