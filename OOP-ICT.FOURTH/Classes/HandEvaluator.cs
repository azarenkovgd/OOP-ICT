using OOP_ICT.FIRST.Classes;
using OOP_ICT.FIRST.Enums;
using OOP_ICT.FOURTH.Enums;

namespace OOP_ICT.FOURTH.Classes;

public class HandEvaluator
{
    private readonly IReadOnlyList<Card> _hand;

    public HandEvaluator(IReadOnlyList<Card> hand)
    {
        _hand = hand;
    }

    public HandRank CalculateHandRank()
    {
        if (IsRoyalFlush()) return HandRank.RoyalFlush;
        if (IsStraightFlush()) return HandRank.StraightFlush;
        if (IsFourOfAKind()) return HandRank.FourOfAKind;
        if (IsFullHouse()) return HandRank.FullHouse;
        if (IsFlush()) return HandRank.Flush;
        if (IsStraight()) return HandRank.Straight;
        if (IsThreeOfAKind()) return HandRank.ThreeOfAKind;
        if (IsTwoPair()) return HandRank.TwoPair;
        if (IsPair()) return HandRank.Pair;
        return HandRank.HighCard;
    }

    public int CalculateHandValue()
    {
        return _hand.Sum(card => card.GetValue());
    }

    private bool IsFlush()
    {
        return _hand.All(card => card.Suit == _hand.First().Suit);
    }

    private bool IsStraight()
    {
        var orderedRanks = _hand.Select(card => (int)card.Rank).OrderBy(rank => rank).ToList();
        for (var i = 0; i < orderedRanks.Count - 1; i++)
            if (orderedRanks[i] + 1 != orderedRanks[i + 1])
                return false;
        return true;
    }

    private bool IsRoyalFlush()
    {
        return IsStraightFlush() && _hand.Any(card => card.Rank == CardRank.Ace);
    }

    private bool IsStraightFlush()
    {
        return IsFlush() && IsStraight();
    }

    private bool IsFourOfAKind()
    {
        return _hand.GroupBy(card => card.Rank).Any(g => g.Count() == 4);
    }

    private bool IsFullHouse()
    {
        var groups = _hand.GroupBy(card => card.Rank).ToList();
        return groups.Any(g => g.Count() == 3) && groups.Any(g => g.Count() == 2);
    }

    private bool IsThreeOfAKind()
    {
        return _hand.GroupBy(card => card.Rank).Any(g => g.Count() == 3);
    }

    private bool IsTwoPair()
    {
        return _hand.GroupBy(card => card.Rank).Count(g => g.Count() == 2) == 2;
    }

    private bool IsPair()
    {
        return _hand.GroupBy(card => card.Rank).Any(g => g.Count() == 2);
    }
}