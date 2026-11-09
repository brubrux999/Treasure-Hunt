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

Console.WriteLine("");
Console.WriteLine("These are your initial stats " + playerName + ":");
Console.WriteLine("Health: " + playerHealth);
Console.WriteLine("Energy: " + playerEnergy);
Console.WriteLine("Score: " + playerScore);

Console.WriteLine("");

// First search
if (playerHealth > 0 && playerEnergy > 0 && isPlaying)
{
    Console.WriteLine("Where would you like to search?");
    Console.WriteLine("");
    Console.WriteLine("[a] Gas station");
    Console.WriteLine("[b] Abandoned car");
    playerLocation = Console.ReadLine();

    if (playerLocation == "a" || playerLocation == "A")
    {
        Console.WriteLine("");
        Console.WriteLine("You found a bit of fuel");
        Console.WriteLine("You ran into a zombie, it wasn't a big deal");
        Console.WriteLine("");
        playerHealth -= 5;
        playerEnergy -= 1;
        playerScore += 3;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
    else if (playerLocation == "b" || playerLocation == "B")
    {
        Console.WriteLine("");
        Console.WriteLine("You found an expensive watch!");
        Console.WriteLine("The car alarm went off and attracted many zombies, you barely make it out alive");
        Console.WriteLine("");
        playerHealth -= 45;
        playerEnergy -= 1;
        playerScore += 8;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
}

if (playerHealth <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of health. Game over!");
    Console.WriteLine("You lose");
    isPlaying = false;
}

if (playerEnergy <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of energy. Game over!");
    Console.WriteLine("Your final score: " + playerScore);
    isPlaying = false;
}

if (isPlaying)
{
    Console.WriteLine("Keep searching? [y/n]");
    input = Console.ReadLine();
    if (input == "n")
    {
        isPlaying = false;
        Console.WriteLine("Game over!");
        Console.WriteLine("Your final score: " + playerScore);
    }
}

Console.WriteLine("");
// Second search
if (playerHealth > 0 && playerEnergy > 0 && isPlaying)
{
    Console.WriteLine("Where would you like to search?");
    Console.WriteLine("");
    Console.WriteLine("[a] Dilapidated building");
    Console.WriteLine("[b] Police station");
    playerLocation = Console.ReadLine();

    if (playerLocation == "a" || playerLocation == "A")
    {
        Console.WriteLine("");
        Console.WriteLine("You found a tool: Shovel");
        Console.WriteLine("");
        playerEnergy -= 1;
        playerScore += 3;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
    else if (playerLocation == "b" || playerLocation == "B")
    {
        Console.WriteLine("");
        Console.WriteLine("You found armor: Bulletproof vest");
        Console.WriteLine("A zombie caught you by surprise from behind");
        Console.WriteLine("");
        playerHealth -= 20;
        playerEnergy -= 1;
        playerScore += 6;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
}

if (playerHealth <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of health. Game over!");
    Console.WriteLine("You lose");
    isPlaying = false;
}

if (playerEnergy <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of energy. Game over!");
    Console.WriteLine("Your final score: " + playerScore);
    isPlaying = false;
}

if (isPlaying)
{
    Console.WriteLine("Keep searching? [y/n]");
    input = Console.ReadLine();
    if (input == "n")
    {
        isPlaying = false;
        Console.WriteLine("Game over!");
        Console.WriteLine("Your final score: " + playerScore);
    }
}

Console.WriteLine("");
// Third search
if (playerHealth > 0 && playerEnergy > 0 && isPlaying)
{
    Console.WriteLine("Where would you like to search?");
    Console.WriteLine("");
    Console.WriteLine("[a] Hospital");
    Console.WriteLine("[b] Campfire");
    playerLocation = Console.ReadLine();

    if (playerLocation == "a" || playerLocation == "A")
    {
        Console.WriteLine("");
        Console.WriteLine("You found a medkit! You use it to recover some of your health");
        Console.WriteLine("");
        playerHealth += 25;
        playerEnergy -= 1;
        playerScore += 1;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
    else if (playerLocation == "b" || playerLocation == "B")
    {
        Console.WriteLine("");
        Console.WriteLine("You encountered other aggressive hunters");
        Console.WriteLine("They stole some of your items");
        Console.WriteLine("");
        playerEnergy -= 1;
        playerScore -= 5;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
}

if (playerHealth <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of health. Game over!");
    Console.WriteLine("You lose");
    isPlaying = false;
}

if (playerEnergy <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of energy. Game over!");
    Console.WriteLine("Your final score: " + playerScore);
    isPlaying = false;
}

if (isPlaying)
{
    Console.WriteLine("Keep searching? [y/n]");
    input = Console.ReadLine();
    if (input == "n")
    {
        isPlaying = false;
        Console.WriteLine("Game over!");
        Console.WriteLine("Your final score: " + playerScore);
    }
}

Console.WriteLine("");
// Fourth search
if (playerHealth > 0 && playerEnergy > 0 && isPlaying)
{
    Console.WriteLine("Where would you like to search?");
    Console.WriteLine("");
    Console.WriteLine("[a] Fire station");
    Console.WriteLine("[b] Abandoned shop");
    playerLocation = Console.ReadLine();

    if (playerLocation == "a" || playerLocation == "A")
    {
        Console.WriteLine("");
        Console.WriteLine("You found a tool: very sharp Axe");
        Console.WriteLine("");
        playerEnergy -= 1;
        playerScore += 7;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
    else if (playerLocation == "b" || playerLocation == "B")
    {
        Console.WriteLine("");
        Console.WriteLine("You found an energy drink! You drink it to recover your energy");
        Console.WriteLine("When you turn around, a zombie attacks you");
        Console.WriteLine("");
        playerHealth -= 20;
        playerScore += 1;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
}

if (playerHealth <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of health. Game over!");
    Console.WriteLine("You lose");
    isPlaying = false;
}

if (playerEnergy <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of energy. Game over!");
    Console.WriteLine("Your final score: " + playerScore);
    isPlaying = false;
}

if (isPlaying)
{
    Console.WriteLine("Keep searching? [y/n]");
    input = Console.ReadLine();
    if (input == "n")
    {
        isPlaying = false;
        Console.WriteLine("Game over!");
        Console.WriteLine("Your final score: " + playerScore);
    }
}

Console.WriteLine("");
// Fifth search
if (playerHealth > 0 && playerEnergy > 0 && isPlaying)
{
    Console.WriteLine("Where would you like to search?");
    Console.WriteLine("");
    Console.WriteLine("[a] Water tower");
    Console.WriteLine("[b] Military barricade");
    playerLocation = Console.ReadLine();

    if (playerLocation == "a" || playerLocation == "A")
    {
        Console.WriteLine("");
        Console.WriteLine("At the top, you find another survivor's backpack");
        Console.WriteLine("As you go down the staircase broke");
        Console.WriteLine("You hurt yourself and break some of your items");
        Console.WriteLine("");
        playerHealth -= 15;
        playerEnergy -= 1;
        playerScore -= 5;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
    else if (playerLocation == "b" || playerLocation == "B")
    {
        Console.WriteLine("");
        Console.WriteLine("You found a weapon: M16");
        Console.WriteLine("You don't know how to use it, but it's surely expensive");
        Console.WriteLine("");
        playerEnergy -= 1;
        playerScore += 10;
        Console.WriteLine("Health: " + playerHealth);
        Console.WriteLine("Energy: " + playerEnergy);
        Console.WriteLine("Score: " + playerScore);
    }
}

if (playerHealth <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of health. Game over!");
    Console.WriteLine("You lose");
    isPlaying = false;
}

if (playerEnergy <= 0 && isPlaying)
{
    Console.WriteLine("");
    Console.WriteLine("You ran out of energy. Game over!");
    Console.WriteLine("Your final score: " + playerScore);
}