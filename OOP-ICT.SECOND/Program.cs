using OOP_ICT.SECOND.Classes;

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

game.ShowDeckValues();

game.ShowBetStats();