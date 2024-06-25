namespace OOP_ICT.THIRD.Classes;

public class BlackjackCasino
{
    private readonly BankAccount _casinoBankAccount;

    public BlackjackCasino(BlackjackBank bank)
    {
        Bank = bank;
        _casinoBankAccount = new BankAccount();
        // Мартингейл лучше не пробовать
        _casinoBankAccount.Deposit(1_000_000_000);
    }

    public BlackjackBank Bank { get; }

    public void Win(Player player, int betAmount)
    {
        Bank.Win(player.Account, _casinoBankAccount, betAmount * 2);
    }

    public void Blackjack(Player player, int betAmount)
    {
        Bank.Blackjack(player.Account, _casinoBankAccount, betAmount * 3);
    }

    public void Bet(Player player, int betAmount)
    {
        Bank.Bet(player.Account, _casinoBankAccount, betAmount);
    }
}