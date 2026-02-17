namespace Encaps;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount();
        account1.Deposit(800, "founding");
        Console.WriteLine(account1.Balance);
        
        BankAccount account2 = new BankAccount();
        
        account2.Deposit(1000, "vipps from Thomas");
        account2.Withdraw(500, "paid gym membership");
        account2.Withdraw(100, "bought a coffee");

        Console.WriteLine(account2.GetTransactions());

        BankAccount account3 = new BankAccount("CHF");
        account3.Deposit(100, "Gift from Granny");

        Console.WriteLine(account3.GetTransactions());

        Console.WriteLine(account2.RawBalance);

        Person p1 = new Person();
        p1.Name = "craig";

        Console.WriteLine(p1.Name);
        
        

    }
}