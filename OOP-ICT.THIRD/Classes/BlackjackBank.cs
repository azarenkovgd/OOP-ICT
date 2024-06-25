namespace OOP_ICT.THIRD.Classes;

public class BlackjackBank : AbstractBank
{
    public void Bet(BankAccount playerBankAccount, BankAccount casinoBankAccount, int amount)
    {
        if (playerBankAccount.Balance < amount) throw new Exception("Insufficient funds for bet");

        playerBankAccount.Withdraw(amount);
        casinoBankAccount.Deposit(amount);
    }

    public void Win(BankAccount playerBankAccount, BankAccount casinoBankAccount, int amount)
    {
        playerBankAccount.Deposit(amount);
        casinoBankAccount.Withdraw(amount);
    }

    public void Blackjack(BankAccount playerBankAccount, BankAccount casinoBankAccount, int amount)
    {
        playerBankAccount.Deposit(amount);
        casinoBankAccount.Withdraw(amount);
    }
}