using OOP_ICT.FIRST.Interfaces;

namespace OOP_ICT.FIRST.Classes;

public class Dealer
{
    private readonly MainCardDeck _deck;

    public Dealer()
    {
        _deck = new MainCardDeck();

        _deck.Shuffle();
    }

    public IReadOnlyCardDeck Deck => _deck;

    public Card DrawCard()
    {
        return _deck.DrawCard();
    }
}