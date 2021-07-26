using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Library
{
    public abstract class Bank
    {
        #region properties
        private string accHolderName;

        public string AccHolderName
        {
            get { return accHolderName; }
            set{ accHolderName = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private static int count=0;
        public static int Count
        {
            get { return count; }
            set { count = value; }
        }

        #endregion

        //static constructor
        //static Bank()
        //{
        //    Count = 1000;
        //}
        //Constructor without parameter
        public Bank()
        {
            Balance = 1000;
            Count++;
        }
        //constructor with parameter
        public Bank(string name, double bal):this()
        {
            AccHolderName = name;
            Balance = bal;
        }

        #region methods
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return string.Format($"AccountHolderName = {AccHolderName}  Balance = {Balance} ");
        }
        #endregion

    }
}
