using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 11.1");
            Console.WriteLine("Программа реализует фабричный класс банковских аккаунтов");

            BankAccountFabric bankFabric = new BankAccountFabric();
            bankFabric.Print();

            Console.WriteLine("\nДобавление аккаунта Tinkoff");
            TinkoffBankAcc tinkoffAcc = bankFabric.CreateAccountTinkoff(5000, BankAccountType.current);
            tinkoffAcc.Print();
            bankFabric.Print();

            Console.WriteLine("\nУдаление аккаунта по номеру 1");
            bankFabric.CloseAccount(1);

            bankFabric.Print();

            Console.WriteLine("\nУпражнение 11.2");
            Console.WriteLine("Разбитие классов");

            BankAccountFabric bankFabric2 = new BankAccountFabric();
            BankAccountFabric bankFabric3 = new BankAccountFabric();

            Console.WriteLine("\nДобавление аккаунта Tinkoff и Sber");
            TinkoffBankAcc tinkoffAcc2 = bankFabric2.CreateAccountTinkoff(1000, BankAccountType.savings);
            SberBankAcc sberAcc = bankFabric3.CreateAccountSber(1000, BankAccountType.current);

            tinkoffAcc2.Print();
            sberAcc.Print();

            bankFabric2.Print();
            bankFabric3.Print();

            Console.WriteLine("\nУдаление аккаунта по номеру 3");
            bankFabric3.CloseAccount(3);

            bankFabric2.Print();
            bankFabric3.Print();

            Console.WriteLine("\nДом. Задание 11.1 и 11.2");
            Creator.Print();

            Console.WriteLine("\nСоздание кирпичного и металлического здания");
            BrickBuilding bb = Creator.CreateBrickBuild(150, 5, 20, 2);
            MetalBuilding mb = Creator.CreateMetalBuild(250, 10, 50, 4);

            Creator.Print();

            Console.WriteLine("\nУдаление здания по номеру 1");
            Creator.Destroy(1);

            Creator.Print();

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
