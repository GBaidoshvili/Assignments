using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class BankAccount
    {
        public BankAccount()
        {
        }

        public BankAccount(string accountNumber, string accountHolderName, Currency balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public Currency _balance;

        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public Currency Balance
        {
            get {  return _balance; } 
            set { _balance = value; }
        }

        public void Deposit(double amount)
        {
            _balance.Amount += amount;
        }


        public void Withdraw(double amount)
        {
            _balance.Amount -= amount;
        }

        public string BalanceCheck()
        {
            return Balance.Amount + " " + Balance.CurrencyName;
        }
    }
}
