using OOP_ICT.SECOND.Classes;
using Xunit;

namespace OOP_ICT.SECOND.TESTS;

public class Tests
{
    [Fact]
    public void BlackJackGame_ThrowsIfNotEnoughBalance()
    {
        var player = new BlackjackPlayer("p", 500);

        var game = new BlackJackGame();

        Assert.Throws<Exception>(() => game.AddBet(player, 600));
    }

    [Fact]
    public void BlackJackGame_SubstractBalanceOnBet()
    {
        var player = new BlackjackPlayer("p", 500);

        var game = new BlackJackGame();

        game.AddBet(player, 500);

        Assert.Equal(0, player.Balance);
    }

    [Fact]
    public void BlackJackGame_WinsIfDealerHasTooMuch()
    {
        var player = new BlackjackPlayer("p", 500);

        var game = new BlackJackGame();

        game.AddPlayer(player);

        game.AddBet(player, 200);

        game.GameStarts();

        game.GetOneMoreCard(player);

        game.GameEnds();

        game.ShowBetStats();

        Assert.Equal(700, player.Balance);
    }

    [Fact]
    public void BlackJackGame_WinsIfNo21ButMoreThanDealer()
    {
        var player1 = new BlackjackPlayer("p1", 500);
        var player2 = new BlackjackPlayer("p2", 500);

        var game = new BlackJackGame();

        game.AddPlayer(player1);
        game.AddPlayer(player2);

        game.AddBet(player1, 200);
        game.AddBet(player2, 300);

        game.GameStarts();

        game.GetOneMoreCard(player1);
        game.GetOneMoreCard(player1);

        game.GetOneMoreCard(player2);

        game.GameEnds();

        Assert.Equal(700, player1.Balance);
        Assert.Equal(800, player2.Balance);
    }
}