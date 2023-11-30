using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class BankAccountFabric
    {
        Hashtable accounts;
        public BankAccountFabric()
        {
            accounts = new Hashtable();
        }
        public TinkoffBankAcc CreateAccountTinkoff(double balance, BankAccountType bat)
        {
            if (balance < 0)
            {
                return null;
            }
            else
            {
                TinkoffBankAcc bankAcc = new TinkoffBankAcc(balance, bat);
                accounts.Add(bankAcc.AccountNumber, bankAcc);
                return bankAcc;
            }
        }
        public SberBankAcc CreateAccountSber(double balance, BankAccountType bat)
        {
            if (balance < 0)
            {
                return null;
            }
            else
            {
                SberBankAcc bankAcc = new SberBankAcc(balance, bat);
                accounts.Add(bankAcc.AccountNumber, bankAcc);
                return bankAcc;
            }
        }
        public void CloseAccount(int number)
        {
            accounts.Remove(number);
        }
        public void Print()
        {
            Console.WriteLine($"\nАккаунтов хранится: {accounts.Count}");
            ICollection keys = accounts.Keys;
            foreach (var s in keys)
            {
                Console.WriteLine(s + ": " + accounts[s].ToString());
            }
        }
    }
}
