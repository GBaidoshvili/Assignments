

using Task2;

var a1 = new BankAccount("123", "a", new Currency("GEL", 100));
var a2 = new BankAccount("456", "b", new Currency("GEL", 200));

a1.TransferFunds(50, a2);

Console.WriteLine(a1.Balance.Amount);
Console.WriteLine(a2.Balance.Amount);