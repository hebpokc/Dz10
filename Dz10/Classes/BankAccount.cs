using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dz10
{
    public enum BankAccountType
    {
        current,
        savings
    }
    abstract class BankAccount
    {
        private int _accountNumber;
        private double _balance;
        private BankAccountType _bat;
        private static int magnifier = 1;
        private Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public BankAccountType Bat
        {
            get
            {
                return _bat;
            }
        }
        public Queue<BankTransaction> Transactions
        {
            get
            {
                return transactions;
            }
        }
        internal BankAccount()
        {
            _accountNumber = magnifier;
            IncreaseNumber();
        }
        internal BankAccount(double balance)
        {
            _accountNumber = magnifier;
            IncreaseNumber();
            _balance = balance;
            _bat = BankAccountType.current;
        }
        internal BankAccount(BankAccountType bat)
        {
            _accountNumber = magnifier;
            IncreaseNumber();
            _balance = 0;
            _bat = bat;
        }
        internal BankAccount(double balance, BankAccountType bat)
        {
            _accountNumber = magnifier;
            IncreaseNumber();
            _balance = balance;
            _bat = bat;
        }
        private void IncreaseNumber()
        {
            magnifier++;
        }
        public void AddBalance(double money)
        {
            if (money > 0)
            {
                _balance += money;
                transactions.Enqueue(new BankTransaction(money));
            }
            else
            {
                Console.WriteLine("\nСумма должна быть положительной");
            }

        }
        public void RemoveBalance(double money)
        {

            if (_balance < money)
            {
                Console.WriteLine("\nНедостаточно денег на счете");
            }
            else
            {
                _balance -= money;
                transactions.Enqueue(new BankTransaction(-money));
            }
        }
        public void Transfer(BankAccount ba, double money)
        {
            if (money < 0)
            {
                Console.WriteLine("\nСумма не может быть отрицательной");
            }
            else
            {
                if (ba._balance < money)
                {
                    Console.WriteLine("\nНедостаточно денег на счете");
                }
                else
                {
                    _balance += money;
                    ba._balance -= money;
                    transactions.Enqueue(new BankTransaction(money));
                    Console.WriteLine($"\nПереведено {money} на счет");
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"\nНомер счета: {_accountNumber}\nБаланс: {_balance}\nТип: {_bat}");
        }
        public void Dispose()
        {
            foreach (var trans in transactions)
            {
                File.AppendAllText("transactions.txt", trans.ToString() + "\n");
            }
            GC.SuppressFinalize(this);
        }
    }
}
