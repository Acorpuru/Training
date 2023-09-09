// See https://aka.ms/new-console-template for more information
using FactoryMethod;

int brutAmount = 10000;

ExecuteBankProcess(new BankService());

Console.WriteLine();

void ExecuteBankProcess(BankService baseBankService) =>
    Console.WriteLine($"Net amount of {baseBankService.Name} bank {baseBankService.GetNetAmount(brutAmount)}");