using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public delegate void EventHandler();
    public class Bank
    {
        public event EventHandler ZeroBalance;
        public event EventHandler InsufficientBalance;
        public event EventHandler LowBalance;
        public double Balance;
        public Bank(double Balance)
        {
            this.Balance = Balance;
        }

        public void DebitAmount(double Amount)
        {
            if (Amount > Balance)
            {
                InsufficientBalance();
            }
            else if (Amount < Balance)
            {
                Balance -= Amount;
                if (Balance == 0)
                {
                    ZeroBalance();
                }
                else if (Balance < 3000)
                {
                    LowBalance();
                }


            }
        }
        public void CreditAmount(double Amount)
        {
            Balance = Balance + Amount;
            CheckBalance();
        }
        public string CheckBalance()
        {
            return $"{Balance}";

        }
    }
}