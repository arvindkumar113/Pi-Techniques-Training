using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Library
{
    public class BalanceException:Exception
    {
        public BalanceException(string msg) : base(msg)
        {

        }
    }
}
