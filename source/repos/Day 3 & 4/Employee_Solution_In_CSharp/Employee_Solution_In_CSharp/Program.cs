using HRLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Solution_In_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee trainee = new Trainee("Arvind", "Darbhanga", 22, 1500);
            Console.WriteLine(trainee.ToString());


            ConfirmEmployee cnfemp = new ConfirmEmployee("Arvind Kumar", "Madhubani", 22500, "Developer");
            Console.WriteLine(cnfemp.ToString());

            Console.ReadKey();
        }
    }
}
