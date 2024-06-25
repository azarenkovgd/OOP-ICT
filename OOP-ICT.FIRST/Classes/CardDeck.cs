using OOP_ICT.FIRST.Interfaces;

namespace OOP_ICT.FIRST.Classes;

public class CardDeck : IReadOnlyCardDeck
{
    protected List<Card> _cards;

    public CardDeck()
    {
        _cards = new List<Card>();
    }

    public IReadOnlyList<Card> Cards => _cards;

    public override string ToString()
    {
        var cardsList = string.Join("\n", Cards.Select(card => card.ToString()));
        return $"______ All cards list ______\n{cardsList}\n_____________________________";
    }

    public void Add(Card card)
    {
        _cards.Add(card);
    }

    public Card DrawCard()
    {
        if (_cards.Count == 0) throw new Exception("No cards in deck");

        var card = _cards.First();
        _cards.Remove(card);
        return card;
    }

    public int GetValue()
    {
        return _cards.Sum(card => card.GetValue());
    }
}