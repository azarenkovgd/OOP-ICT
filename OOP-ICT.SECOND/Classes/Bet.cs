namespace OOP_ICT.SECOND.Classes;

public class Bet
{
    public Bet(AbstractPlayer player, int amount)
    {
        Player = player;
        Amount = amount;
    }

    public bool IsWin { get; private set; }

    public AbstractPlayer Player { get; }

    public int Amount { get; }

    public void SetWin()
    {
        IsWin = true;
    }
}