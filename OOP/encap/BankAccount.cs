using System.Text;

namespace Encaps;

public class BankAccount
{
    private decimal _balance;
    public string Balance => _balance.ToString() + $" {Currency}";
    public string RawBalance => _balance.ToString();
    
    private string _currency;
    public string Currency => _currency;
    
    private Stack<string> transactions = new Stack<string>();
    

    public BankAccount(string currency = "kr")
    {
        _balance = 0;
        _currency = currency;
    }

    public bool Deposit(decimal amount, string note = "")
    {
        if (amount <= 0)
            return false;

        _balance += amount;
        transactions.Push($"DEPOSIT: {amount} - {note}");
        return true;
    }

    public bool Withdraw(decimal amount, string note = "")
    {
        if (amount > _balance || amount <= 0 )
            return false;

        _balance -= amount;
        transactions.Push($"WITHDRAW: {amount} - {note}");
        return true;
    }

    public string GetTransactions()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Available Balance: {Balance}\n");
        
        foreach (string transaction in transactions)
        {
            sb.Append(transaction + "\n");
        }

        return sb.ToString();
    }
}