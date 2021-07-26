using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Library
{
    public class Current:Bank,IInterest
    {

        //constructor
        public Current(string name, double amount)
        {
            AccHolderName = name;
            Balance = amount;
        }
        //Generally, bank does not pay any interest on current account. Nowadays, some banks do pay interest on current accounts.
        public double CalculateInterest()
        {
            return Balance * 0.001;
        }

        public override void Withdraw(double amount)
        {
            if(Balance-amount<0)
            {
                Balance -= amount;
            }
            else
            {
                throw new Exception("Amount grater than balance");
            }
        }
    }
}
