using OOP_ICT.FIRST.Classes;

namespace OOP_ICT.FIRST.Interfaces;

public interface IReadOnlyCardDeck
{
    public IReadOnlyList<Card> Cards { get; }
}