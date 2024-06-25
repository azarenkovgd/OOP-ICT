using OOP_ICT.FIRST.Classes;

namespace OOP_ICT.SECOND.Classes;

public abstract class AbstractPlayer
{
    protected AbstractPlayer(string name)
    {
        CardDeck = new CardDeck();

        Name = name;
    }

    public string Name { get; }

    public CardDeck CardDeck { get; }
}