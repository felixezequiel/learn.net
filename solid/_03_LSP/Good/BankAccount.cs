namespace Solid._03_LSP.Good;

public abstract class BankAccount
{
    public decimal Balance { get; protected set; }

    public abstract void Withdraw(decimal amount);
}

public class CheckingAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        Console.WriteLine("Withdraw from CheckingAccount");
    }
}

public class SavingsAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Insufficient balance");
        }

        Balance -= amount;
    }
}