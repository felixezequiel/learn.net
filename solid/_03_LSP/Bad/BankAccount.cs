namespace Solid._03_LSP.Bad;

public class BankAccount
{
    public virtual void Withdraw(decimal amount)
    {
        Console.WriteLine("Withdraw from BankAccount");
    }
}

public class SavingsAccount : BankAccount
{
    public decimal Balance { get; set; }
    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Insufficient balance");
        }

        Balance -= amount;
        Console.WriteLine($"Withdraw {amount} from SavingsAccount");
    }
}