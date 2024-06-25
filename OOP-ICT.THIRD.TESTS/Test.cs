using OOP_ICT.THIRD.Classes;
using Xunit;

namespace OOP_ICT.THIRD.TESTS;

public class Tests
{
    [Fact]
    public void BlackJackCasion_CommonOperationsSuccess()
    {
        var playerAccount = new BankAccount();

        var player = new Player("John", playerAccount);

        playerAccount.Deposit(100);

        Assert.Equal(100, playerAccount.Balance);

        var blackjackBank = new BlackjackBank();

        var blackjackCasino = new BlackjackCasino(blackjackBank);

        blackjackCasino.Bet(player, 50);

        Assert.Equal(50, player.Account.Balance);

        blackjackCasino.Win(player, 100);

        Assert.Equal(250, player.Account.Balance);

        blackjackCasino.Blackjack(player, 150);

        Assert.Equal(700, player.Account.Balance);
    }
}