using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class TinkoffBankAcc : BankAccount
    {
        internal TinkoffBankAcc(double balance, BankAccountType bat) : base(balance, bat) { }
        public override string ToString()
        {
            return "Тинькофф банк";
        }
    }
}
