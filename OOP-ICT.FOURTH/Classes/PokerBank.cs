using OOP_ICT.THIRD.Classes;

namespace OOP_ICT.FOURTH.Classes;

public class PokerBank : AbstractBank
{
    public void Bet(BankAccount playerBankAccount, BankAccount casinoBankAccount, int amount)
    {
        if (playerBankAccount.Balance < amount) throw new Exception("Insufficient funds for bet");

        playerBankAccount.Withdraw(amount);
        casinoBankAccount.Deposit(amount);
    }

    public void Win(BankAccount playerBankAccount, BankAccount casinoBankAccount, int amount)
    {
        // Учитываем коммисию казино
        playerBankAccount.Deposit((int)(amount * 0.8));
        casinoBankAccount.Withdraw((int)(amount * 0.8));
    }
}