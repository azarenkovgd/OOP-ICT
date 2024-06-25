using OOP_ICT.FIRST.Enums;

namespace OOP_ICT.FIRST.Classes;

public class Card
{
    public Card(CardRank rank, CardSuit suit)
    {
        Rank = rank;
        Suit = suit;
    }

    public CardRank Rank { get; }

    public CardSuit Suit { get; }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }

    public int GetValue()
    {
        switch (Rank)
        {
            case CardRank.Ace:
                return 11;
            case CardRank.King:
            case CardRank.Queen:
            case CardRank.Jack:
            case CardRank.Ten:
                return 10;
            case CardRank.Nine:
                return 9;
            case CardRank.Eight:
                return 8;
            case CardRank.Seven:
                return 7;
            case CardRank.Six:
                return 6;
            case CardRank.Five:
                return 5;
            case CardRank.Four:
                return 4;
            case CardRank.Three:
                return 3;
            case CardRank.Two:
                return 2;
            default:
                throw new ArgumentException("Unknown card rank");
        }
    }
}