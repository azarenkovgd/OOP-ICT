using OOP_ICT.FIRST.Classes;
using OOP_ICT.FIRST.Enums;
using Xunit;

namespace OOP_ICT.FIRST.TESTS;

public class Tests
{
    [Fact]
    public void CardConstructor_SetsRankAndSuit()
    {
        var rank = CardRank.Ace;
        var suit = CardSuit.Hearts;

        var card = new Card(rank, suit);

        Assert.Equal(rank, card.Rank);
        Assert.Equal(suit, card.Suit);
    }

    [Fact]
    public void CardDeck_ShouldBeInteractable()
    {
        var deck = new CardDeck();

        var card = new Card(CardRank.Ace, CardSuit.Hearts);

        deck.Add(card);

        var drawnCard = deck.DrawCard();

        Assert.Equal(card, drawnCard);

        Assert.Empty(deck.Cards);

        Assert.Throws<Exception>(() => deck.DrawCard());
    }
}