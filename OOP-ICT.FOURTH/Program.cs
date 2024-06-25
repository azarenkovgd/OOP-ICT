// See https://aka.ms/new-console-template for more information

using OOP_ICT.FOURTH.Classes;
using OOP_ICT.THIRD.Classes;

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

Console.WriteLine($"{player1.Name} balance: {player1.Account.Balance}");
Console.WriteLine($"{player2.Name} balance: {player2.Account.Balance}");
Console.WriteLine($"Casino balance: {casino.CasinoBankAccount.Balance}");