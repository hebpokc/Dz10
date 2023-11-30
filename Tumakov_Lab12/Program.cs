using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.1");
            Console.WriteLine("Программа реализует класс BankAccount с добавленным методом Equals и перегруженными операторами ==, !=, ToString");

            BankAccount ba1 = new BankAccount(1000, BankAccountType.current);
            BankAccount ba2 = new BankAccount(1000, BankAccountType.current);
            BankAccount ba3 = new BankAccount(500, BankAccountType.savings);

            Console.WriteLine(ba1);
            Console.WriteLine(ba2);
            Console.WriteLine(ba3);

            Console.WriteLine($"Сравнение банк.аккаунта 1 и бакн.аккаунта 2 - {ba1.Equals(ba2)}");
            Console.WriteLine($"Сравнение банк.аккаунта 1 и бакн.аккаунта 2, с помощью == - {ba1 == ba2}");
            Console.WriteLine($"Сравнение банк.аккаунта 1 и бакн.аккаунта 3, с помощью != - {ba1 != ba3}");

            Console.WriteLine("\nУпражнение 12.2");
            Console.WriteLine("Программа реализует класс рациональное число");

            RationalNumber a = new RationalNumber(5, 7);
            RationalNumber b = new RationalNumber(6, 11);

            Console.WriteLine($"\nДробь a = {a}");
            Console.WriteLine($"Дробь a = {b}");

            Console.WriteLine($"\na + b = {a + b}");
            Console.WriteLine($"\na - b = {a - b}");
            Console.WriteLine($"\na * b = {a * b}");
            Console.WriteLine($"\na / b = {a / b}");
            Console.WriteLine($"\na++ = {a++}");
            Console.WriteLine($"\nb-- = {b--}");
            Console.WriteLine($"\na == b - {a == b}");
            Console.WriteLine($"\na != b - {a != b}");
            Console.WriteLine($"\na > b - {a > b}");
            Console.WriteLine($"\na <= b - {a <= b}");
            Console.WriteLine($"\na + 5 = {a + 5}");
            Console.WriteLine($"\nb - 2 = {b - 2}");

            Console.WriteLine("\nДом. задание 12.1");
            Console.WriteLine("Программа реализует класс комплексное число");

            ComplexNumber a2 = new ComplexNumber(2, 3);
            ComplexNumber b2 = new ComplexNumber(7, -5);

            Console.WriteLine($"a = {a2}");
            Console.WriteLine($"b = {b2}");
            Console.WriteLine($"\na + b = {a2 + b2}");
            Console.WriteLine($"\na - b = {a2 - b2}");
            Console.WriteLine($"\na * b = {a2 * b2}");
            Console.WriteLine($"\na = b - {a2 == b2}");
            Console.WriteLine($"\na != b - {a2 != b2}");

            Console.WriteLine("\nДом. задание 12.2");
            Console.WriteLine("Программа реализует класс контейнер для книг");

            BookContainer books = new BookContainer();
            Book book1 = new Book("Искусство войны", "Сунь-Цзы", "Стратег");
            Book book2 = new Book("Война и мир", "Лев Толстой", "Граф Толстой");
            Book book3 = new Book("1984", "Джордж Оруэлл", "Прогресс");

            books.Books.Add(book1);
            books.Books.Add(book2);
            books.Books.Add(book3);

            Console.WriteLine(books);

            Console.WriteLine("Сортировка по издательству");

            books.Sort(x => x.Publisher);

            Console.WriteLine(books);

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
