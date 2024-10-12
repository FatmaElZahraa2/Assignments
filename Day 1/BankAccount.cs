using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int AccountNumber , string AccountHolderName , double Balcance = 0 )
        {

            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balcance;
        }

 
        public void Deposit(double DepositedAmount)
        {
            if (DepositedAmount > 0)
                Balance += DepositedAmount;
        } 


        public void Withdraw(double WithdrawnAmount)
        {
            if (Balance >= WithdrawnAmount && WithdrawnAmount > 0 )
                Balance -= WithdrawnAmount;
            else
                Console.WriteLine("Invalid Transaction");
        }
    }
}
