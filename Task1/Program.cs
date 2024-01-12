using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>(1,100,"Иванов Иван Иванович");
            BankAccount<string> bankAccount2 = new BankAccount<string>("02", 100, "Петров Петр Петрович");
            bankAccount1.AddToBalance(200);
            bankAccount2.AddToBalance(300);
            Console.WriteLine($"На счету под номером {bankAccount1.AccountNumber} лежит {bankAccount1.Balance}");
            Console.WriteLine($"На счету под номером {bankAccount2.AccountNumber} лежит {bankAccount2.Balance}");
            Console.ReadLine();


        }
    }
}
