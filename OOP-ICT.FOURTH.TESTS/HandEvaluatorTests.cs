using OOP_ICT.FIRST.Classes;
using OOP_ICT.FIRST.Enums;
using OOP_ICT.FOURTH.Classes;
using OOP_ICT.FOURTH.Enums;
using Xunit;

namespace OOP_ICT.FOURTH.TESTS;

public class HandEvaluatorTests
{
    [Fact]
    public void TestValue()
    {
        var hand = new List<Card>
        {
            new(CardRank.Ace, CardSuit.Hearts),
            new(CardRank.King, CardSuit.Hearts),
            new(CardRank.Queen, CardSuit.Hearts),
            new(CardRank.Jack, CardSuit.Hearts),
            new(CardRank.Ten, CardSuit.Hearts)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(hand.Sum(c => c.GetValue()), evaluator.CalculateHandValue());
    }

    [Fact]
    public void TestRoyalFlush()
    {
        var hand = new List<Card>
        {
            new(CardRank.Ace, CardSuit.Hearts),
            new(CardRank.King, CardSuit.Hearts),
            new(CardRank.Queen, CardSuit.Hearts),
            new(CardRank.Jack, CardSuit.Hearts),
            new(CardRank.Ten, CardSuit.Hearts)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.RoyalFlush, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestStraightFlush()
    {
        var hand = new List<Card>
        {
            new(CardRank.Nine, CardSuit.Clubs),
            new(CardRank.Eight, CardSuit.Clubs),
            new(CardRank.Seven, CardSuit.Clubs),
            new(CardRank.Six, CardSuit.Clubs),
            new(CardRank.Five, CardSuit.Clubs)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.StraightFlush, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestFourOfAKind()
    {
        var hand = new List<Card>
        {
            new(CardRank.Queen, CardSuit.Hearts),
            new(CardRank.Queen, CardSuit.Diamonds),
            new(CardRank.Queen, CardSuit.Clubs),
            new(CardRank.Queen, CardSuit.Spades),
            new(CardRank.Three, CardSuit.Hearts)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.FourOfAKind, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestFullHouse()
    {
        var hand = new List<Card>
        {
            new(CardRank.Two, CardSuit.Hearts),
            new(CardRank.Two, CardSuit.Diamonds),
            new(CardRank.Three, CardSuit.Hearts),
            new(CardRank.Three, CardSuit.Diamonds),
            new(CardRank.Three, CardSuit.Clubs)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.FullHouse, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestFlush()
    {
        var hand = new List<Card>
        {
            new(CardRank.Two, CardSuit.Spades),
            new(CardRank.Five, CardSuit.Spades),
            new(CardRank.Nine, CardSuit.Spades),
            new(CardRank.Jack, CardSuit.Spades),
            new(CardRank.King, CardSuit.Spades)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.Flush, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestStraight()
    {
        var hand = new List<Card>
        {
            new(CardRank.Six, CardSuit.Hearts),
            new(CardRank.Five, CardSuit.Hearts),
            new(CardRank.Four, CardSuit.Clubs),
            new(CardRank.Three, CardSuit.Spades),
            new(CardRank.Two, CardSuit.Diamonds)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.Straight, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestThreeOfAKind()
    {
        var hand = new List<Card>
        {
            new(CardRank.Seven, CardSuit.Hearts),
            new(CardRank.Seven, CardSuit.Diamonds),
            new(CardRank.Seven, CardSuit.Clubs),
            new(CardRank.Four, CardSuit.Spades),
            new(CardRank.Two, CardSuit.Hearts)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.ThreeOfAKind, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestTwoPair()
    {
        var hand = new List<Card>
        {
            new(CardRank.Five, CardSuit.Hearts),
            new(CardRank.Five, CardSuit.Diamonds),
            new(CardRank.Three, CardSuit.Clubs),
            new(CardRank.Three, CardSuit.Spades),
            new(CardRank.Two, CardSuit.Hearts)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.TwoPair, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestPair()
    {
        var hand = new List<Card>
        {
            new(CardRank.Nine, CardSuit.Hearts),
            new(CardRank.Nine, CardSuit.Diamonds),
            new(CardRank.Seven, CardSuit.Clubs),
            new(CardRank.Four, CardSuit.Spades),
            new(CardRank.Two, CardSuit.Hearts)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.Pair, evaluator.CalculateHandRank());
    }

    [Fact]
    public void TestHighCard()
    {
        var hand = new List<Card>
        {
            new(CardRank.King, CardSuit.Hearts),
            new(CardRank.Queen, CardSuit.Diamonds),
            new(CardRank.Jack, CardSuit.Clubs),
            new(CardRank.Nine, CardSuit.Spades),
            new(CardRank.Seven, CardSuit.Hearts)
        };
        var evaluator = new HandEvaluator(hand);
        Assert.Equal(HandRank.HighCard, evaluator.CalculateHandRank());
    }
}