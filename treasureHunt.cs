Console.WriteLine("Welcome to Treasure Hunt!");
Console.WriteLine("");

Console.WriteLine("What's your name?");
string playerName = Console.ReadLine();
int playerHealth = 100;
int playerEnergy = 4;
int playerScore = 0;
bool isPlaying = true;
string input;
string playerLocation;

bool conditionToContinue = playerHealth > 0 && playerEnergy > 0 && isPlaying;

Console.WriteLine("");
Console.WriteLine("These are your initial stats " + playerName + ":");
Console.WriteLine("Health: " + playerHealth);
Console.WriteLine("Energy: " + playerEnergy);
Console.WriteLine("Score: " + playerScore);


if (conditionToContinue)
{
    Console.WriteLine("");
    Console.WriteLine("Where would you like to search?");
    Console.WriteLine("");
    Console.WriteLine("[a] Gas station");
    Console.WriteLine("[b] Abandoned car");
    playerLocation = Console.ReadLine();

    if (playerLocation == "a" || playerLocation == "A")
    {
        Console.WriteLine("");
        Console.WriteLine("You found a bit of fuel");
        Console.WriteLine("You ran into a zombie; it wasn't a big deal");
        Console.WriteLine("");
        playerHealth -= 10;
        playerEnergy -= 1;
        playerScore += 4;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
    else if (playerLocation == "b" || playerLocation == "B")
    {
        Console.WriteLine("");
        Console.WriteLine("You found an expensive watch!");
        Console.WriteLine("The car alarm went off and attracted many zombies");
        Console.WriteLine("");
        playerHealth -= 35;
        playerEnergy -= 1;
        playerScore += 10;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
    else
    {
        Console.WriteLine("Incorrect input");
    }

    Console.WriteLine("Keep searching? [y/n]");
    input = Console.ReadLine();
    if (input == "n");
    {
        isPlaying = false;
        Console.WriteLine("Game over!");
        Console.WriteLine("Your final score: " + playerScore);
    }
}
else if (playerHealth <= 0)
{
    Console.WriteLine("You ran out of health. Game over!");
    Console.WriteLine("Your final score: " + playerScore);
}
else if (playerEnergy <= 0)
{
    Console.WriteLine("You ran out of energy. Game over!");
    Console.WriteLine("Your final score: " + playerScore);
}