namespace OOP_ICT.THIRD.Classes;

public class BankAccount
{
    public int Balance { get; private set; }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (Balance < amount) throw new Exception($"Insufficient funds for withdrawal: {amount}. Balance: {Balance}");

        Balance -= amount;
    }
}