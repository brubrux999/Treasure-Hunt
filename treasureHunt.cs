Console.WriteLine("Welcome to Treasure Hunt!");
Console.WriteLine("");

Console.WriteLine("What's your name?");
string playerName = Console.ReadLine();
int playerMoney = 15;
int playerEnergy = 4;
int playerScore = 0;

Console.WriteLine("");
Console.WriteLine("These are your initial stats " + playerName + ":");
Console.WriteLine("Money: $" + playerMoney);
Console.WriteLine("Energy: " + playerEnergy);
Console.WriteLine("Score: " + playerScore);