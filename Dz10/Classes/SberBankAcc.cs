using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class SberBankAcc : BankAccount
    {
        internal SberBankAcc(double balance, BankAccountType bat) : base(balance, bat) { }
        public override string ToString()
        {
            return "Сбербанк";
        }
    }
}
