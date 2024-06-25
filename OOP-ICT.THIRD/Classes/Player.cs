using OOP_ICT.SECOND.Classes;

namespace OOP_ICT.THIRD.Classes;

public class Player : AbstractPlayer
{
    public Player(string name, BankAccount account) : base(name)
    {
        Account = account;
    }

    public BankAccount Account { get; }
}