using OOP_ICT.FIRST.Classes;
using OOP_ICT.FOURTH.Enums;
using OOP_ICT.SECOND.Classes;
using OOP_ICT.THIRD.Classes;

namespace OOP_ICT.FOURTH.Classes;

public class PokerGame
{
    private readonly List<Bet> _bets;

    private readonly Dealer _dealer;
    
    private readonly List<Player> _players;

    private readonly PokerCasino _casino;
    
    public PokerGame(PokerCasino casino)
    {
        _casino = casino;
        
        _players = new List<Player>();

        _bets = new List<Bet>();

        _dealer = new Dealer();
    }

    public void AddPlayer(Player player)
    {
        _players.Add(player);
    }

    public void AddBet(Player player, int amount)
    {
        _casino.Bet(player, amount);
        _bets.Add(new Bet(player, amount));
    }

    public void StartGame()
    {
        if (_players.Count < 2) throw new Exception("Not enough players");

        foreach (var player in _players)
            for (var i = 0; i < 5; i++)
                player.CardDeck.Add(_dealer.DrawCard());
    }

    public void PrintHands()
    {
        foreach (var player in _players) Console.WriteLine($"{player.Name}: {player.CardDeck}\n");
    }

    public void EndGame()
    {
        var bestHandRank = HandRank.HighCard;

        var bestHandValue = 0;

        var bestPlayer = _players[0];

        var totalWon = 0;

        foreach (var bet in _bets)
        {
            var player = (Player)bet.Player;

            var amount = bet.Amount;

            var cards = player.CardDeck.Cards;

            var handEvaluator = new HandEvaluator(cards);

            var handValue = handEvaluator.CalculateHandValue();

            var handRank = handEvaluator.CalculateHandRank();

            totalWon += amount;
            
            if (handRank > bestHandRank)
            {
                bestHandRank = handRank;

                bestHandValue = handValue;

                bestPlayer = player;
            }
            else if (handRank == bestHandRank && handValue > bestHandValue)
            {
                bestHandValue = handValue;

                bestPlayer = player;
            }
        }
        
        _casino.Win(bestPlayer, totalWon);
    }
}