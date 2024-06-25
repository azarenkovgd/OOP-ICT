using OOP_ICT.FIRST.Enums;

namespace OOP_ICT.FIRST.Classes;

public class MainCardDeck : CardDeck
{
    public MainCardDeck()
    {
        foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            var card = new Card(rank, suit);
            _cards.Add(card);
        }
    }

    public void Shuffle()
    {
        var n = Cards.Count / 2;
        var shuffledCards = new List<Card>();

        for (var i = 0; i < n; i++)
        {
            shuffledCards.Add(Cards[i]);
            shuffledCards.Add(Cards[i + n]);
        }

        _cards = shuffledCards;
    }
}