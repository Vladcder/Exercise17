using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BankAccount<T>
    {
        private T accountNumber;
        private decimal balance;
        private string ownerFullName;


        public T AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value <0) 
                {
                    balance = 0;
                }
                else
                {
                    balance=value;
                }
            }
        }

        public string OwnerFullName
        {
            get { return ownerFullName; }
            set { ownerFullName = value; }
        }

        public BankAccount(T accountNumber, decimal balance, string ownerFullName)
        {

            AccountNumber = accountNumber;
            Balance = balance;
            OwnerFullName = ownerFullName;
        }

        public decimal AddToBalance(decimal additive)
        {
            Balance = balance + additive;
            return Balance;
        }

        public decimal RemoveFromBalance(decimal subtrahend) 
        {
            Balance = balance - subtrahend;
            return Balance;
        }
    }
}
