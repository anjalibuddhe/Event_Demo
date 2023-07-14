using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Program
    {
        static void ZeroBalance()
        {
            Console.WriteLine("You have Zero Balance In your account");
        }
        static void InsufficientBalance()
        {
            Console.WriteLine("You have Insufficient Balance");
        }
        static void LowBalance()
        {
            Console.WriteLine("You have Low Balance");
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank(10000);
            bank.ZeroBalance += new EventHandler(ZeroBalance);
            bank.InsufficientBalance += new EventHandler(InsufficientBalance);
            bank.LowBalance += new EventHandler(LowBalance);

            bank.CreditAmount(100);
            bank.DebitAmount(200);
            bank.CheckBalance();
            bank.CheckBalance();
            Console.WriteLine(bank.CheckBalance());

        }
    }
 }

