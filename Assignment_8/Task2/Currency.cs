using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Currency
    {
        public Currency(string currencyName, double amount)
        {
            CurrencyName = currencyName;
            Amount = amount;
        }

        public string CurrencyName { get; set; }
        public double Amount { get; set; }
    }
}
