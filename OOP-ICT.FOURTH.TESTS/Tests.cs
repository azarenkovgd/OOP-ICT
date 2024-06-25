using OOP_ICT.FIRST.Classes;
using OOP_ICT.FIRST.Enums;
using OOP_ICT.FOURTH.Classes;
using OOP_ICT.THIRD.Classes;
using Xunit;

namespace OOP_ICT.FOURTH.TESTS;

public class Tests
{
    [Fact]
    public void TestValue()
    {
        
        var bank = new PokerBank();

        var casino = new PokerCasino(bank);

        var game = new PokerGame(casino);

        var player1 = new Player("Player1", bank.CreateAccount());

        player1.Account.Deposit(100);

        var player2 = new Player("Player2", bank.CreateAccount());

        player2.Account.Deposit(100);

        game.AddPlayer(player1);

        game.AddPlayer(player2);

        game.StartGame();

        game.AddBet(player1, 100);

        game.AddBet(player2, 100);

        game.EndGame();
        
        Assert.Equal(160, player1.Account.Balance);
        
        Assert.Equal(0, player2.Account.Balance);
        
        Assert.Equal(1000000040, casino.CasinoBankAccount.Balance);
    }
}