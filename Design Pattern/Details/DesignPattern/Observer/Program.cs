using Observer;

BankAccountSaving bankAccountSaving = new BankAccountSaving("8081530642", 200);
foreach (var operation in new decimal[] { -150, 200, 300, 500, 1520 })
{
    bankAccountSaving.Saving += operation;
    Console.WriteLine($" Added {operation} to bank account {bankAccountSaving.BankAccountNumber}, new saving {bankAccountSaving.Saving}");
}

Console.ReadLine();