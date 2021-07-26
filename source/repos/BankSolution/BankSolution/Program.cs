using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Library;


namespace BankSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("from bank solution");
            Savings bank = new Savings("Arvind", 100000);

            //bank.Balance = 100000;
            //bank.AccHolderName = "Arvind";
            Console.WriteLine("bank object data " + bank);
            try
            {
                bank.Deposit(10000);
            }
            catch(BalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("bank object data " + bank);


            //bank.Withdraw(20000);


            Console.WriteLine("=======Interest========");
            Console.WriteLine("Interest is =" + bank.CalculateInterest());


            Current current = new Current("Abhijeet", 110000);
            Console.WriteLine("Current account "+current +" and Interest is = "+current.CalculateInterest());


            Console.WriteLine("---------========-----------");
            Console.WriteLine("Total count of object is " + Bank.Count);

            Console.ReadLine();
        }

       
    }
}
