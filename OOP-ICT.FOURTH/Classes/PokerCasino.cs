using OOP_ICT.THIRD.Classes;

namespace OOP_ICT.FOURTH.Classes;

public class PokerCasino
{
    private readonly BankAccount _casinoBankAccount;

    public BankAccount CasinoBankAccount => _casinoBankAccount;
    
    public PokerCasino(PokerBank bank)
    {
        Bank = bank;
        _casinoBankAccount = new BankAccount();
        _casinoBankAccount.Deposit(1_000_000_000);
    }

    public PokerBank Bank { get; }

    public void Win(Player player, int totalAmount)
    {
        Bank.Win(player.Account, _casinoBankAccount, totalAmount);
    }
    
    public void Bet(Player player, int betAmount)
    {
        Bank.Bet(player.Account, _casinoBankAccount, betAmount);
    }
}