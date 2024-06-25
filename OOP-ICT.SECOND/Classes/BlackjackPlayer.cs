using OOP_ICT.FIRST.Classes;

namespace OOP_ICT.SECOND.Classes;

public class BlackjackPlayer : AbstractPlayer
{
    public BlackjackPlayer(string name, int initialBalance) : base(name)
    {
        Balance = initialBalance;
    }

    public CardDeck CardDeck { get; }

    public string Name { get; }

    public int Balance { get; set; }
}