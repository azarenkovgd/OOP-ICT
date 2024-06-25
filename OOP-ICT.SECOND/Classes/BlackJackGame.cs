using OOP_ICT.FIRST.Classes;

namespace OOP_ICT.SECOND.Classes;

public class BlackJackGame
{
    private readonly List<Bet> _bets;

    private readonly Dealer _dealer;

    private readonly CardDeck _dealersDeck;

    private readonly List<BlackjackPlayer> _players;

    public BlackJackGame(
    )
    {
        _players = new List<BlackjackPlayer>();
        _dealer = new Dealer();
        _dealersDeck = new CardDeck();
        _bets = new List<Bet>();
    }

    public void AddPlayer(BlackjackPlayer blackjackPlayer)
    {
        _players.Add(blackjackPlayer);
    }

    public void AddBet(BlackjackPlayer blackjackPlayer, int amount)
    {
        if (blackjackPlayer.Balance < amount) throw new Exception("Insufficient funds for bet");

        var bet = new Bet(blackjackPlayer, amount);
        blackjackPlayer.Balance -= amount;
        _bets.Add(bet);
    }

    public void GameStarts()
    {
        foreach (var player in _players)
        {
            player.CardDeck.Add(_dealer.DrawCard());
            player.CardDeck.Add(_dealer.DrawCard());
        }

        _dealersDeck.Add(_dealer.DrawCard());
    }

    public void GetOneMoreCard(BlackjackPlayer blackjackPlayer)
    {
        blackjackPlayer.CardDeck.Add(_dealer.DrawCard());
    }

    public void GameEnds()
    {
        while (_dealersDeck.GetValue() < 17) _dealersDeck.Add(_dealer.DrawCard());

        foreach (var bet in _bets)
            if (bet.Player.CardDeck.GetValue() == 21)
            {
                ((BlackjackPlayer)bet.Player).Balance += bet.Amount * 3;
                bet.SetWin();
            }

            else if (bet.Player.CardDeck.GetValue() > 21)
            {
            }

            else if (_dealersDeck.GetValue() > 21 || bet.Player.CardDeck.GetValue() > _dealersDeck.GetValue())
            {
                ((BlackjackPlayer)bet.Player).Balance += bet.Amount * 2;
                bet.SetWin();
            }
    }

    public void ShowDeckValues()
    {
        Console.WriteLine("Dealer deck value: " + _dealersDeck.GetValue());

        foreach (var player in _players) Console.WriteLine($"{player.Name} deck value: {player.CardDeck.GetValue()}");
    }

    public void ShowBetStats()
    {
        foreach (var bet in _bets) Console.WriteLine($"Player: {bet.Player.Name}, Bet: {bet.Amount}, Win: {bet.IsWin}");
    }
}