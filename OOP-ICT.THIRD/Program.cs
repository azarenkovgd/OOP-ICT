using OOP_ICT.THIRD.Classes;

var playerAccount = new BankAccount();

var player = new Player("John", playerAccount);

player.Account.Deposit(100);

var blackjackBank = new BlackjackBank();

var blackjackCasino = new BlackjackCasino(blackjackBank);

blackjackCasino.Bet(player, 50);

blackjackCasino.Win(player, 100);

blackjackCasino.Blackjack(player, 150);

Console.WriteLine(player.Account.Balance);