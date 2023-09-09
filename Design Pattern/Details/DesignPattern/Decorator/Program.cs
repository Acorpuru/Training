// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");

decimal amountToCredit = 2010;

var bank = new Bank();

bank.CreditAmount(amountToCredit);

Console.WriteLine($"current saving {bank.GetSavings()}");
Console.ReadLine();