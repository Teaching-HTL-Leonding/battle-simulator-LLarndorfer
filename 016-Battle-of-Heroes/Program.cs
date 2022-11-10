//Battle simulator
#region Constants
Console.OutputEncoding = System.Text.Encoding.Default;
const int PIRATE = 1;
const int STONECHEWER = 2;
const int GHOSTWARRIOR = 3;
const int OUTWORLDER = 4;
const int MONSTER_KNIGHT = 5;
const int DARK_GOBLIN = 6;
float player1health = 0;
float player2health = 1;
float player1attack = 1;
float player2attack = 1;
float player1speed = 1;
float player2speed = 1;
float player1armor = 1;
float player2armor = 1;
#endregion
#region Data query 
int rounds = 1;
Console.WriteLine("Battle simulator! \nPlayer 1, please enter your character (pirate (1), stone chewer (2), ghost warrior(3), Outworlder (4), Monster Knight (5) or Dark Goblin (6))");
int player1 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Player 1, please enter your character (pirate (1), stone chewer (2) or ghost warrior(3), Outworlder (4), Monster Knight (5) or Dark Goblin (6))");
int player2 = int.Parse(Console.ReadLine()!);
#endregion
#region Switch Player1
switch (player1)
{
    case PIRATE:
        player1health = 20;
        player1attack = 3;
        player1speed = 3;
        player1armor = 3;
        break;

    case STONECHEWER:
        player1health = 50;
        player1attack = 8;
        player1speed = 1;
        player1armor = 10;
        break;

    case GHOSTWARRIOR:
        player1health = 20;
        player1attack = 2;
        player1speed = 5;
        player1armor = 2;
        break;

    case OUTWORLDER:
        player2health = 15;
        player2attack = 1;
        player2speed = 10;
        player1armor = 2;
        break;

    case MONSTER_KNIGHT:
        player2health = 15;
        player2attack = 4;
        player2speed = 3;
        player1armor = 3;
        break;

    case DARK_GOBLIN:
        player2health = 10;
        player2attack = 1;
        player2speed = 3;
        player1armor = 8;
        break;
}
#endregion
#region Switch Player2
switch (player2)
{
    case PIRATE:
        player2health = 20;
        player2attack = 3;
        player2speed = 3;
        player2armor = 3;
        break;

    case STONECHEWER:
        player2health = 50;
        player2attack = 8;
        player2speed = 1;
        player2armor = 10;
        break;

    case GHOSTWARRIOR:
        player2health = 20;
        player2attack = 2;
        player2speed = 5;
        player2armor = 2;
        break;

    case OUTWORLDER:
        player2health = 15;
        player2attack = 1;
        player2speed = 10;
        player2armor = 2;
        break;

    case MONSTER_KNIGHT:
        player2health = 15;
        player2attack = 4;
        player2speed = 3;
        player2armor = 4;
        break;

    case DARK_GOBLIN:
        player2health = 10;
        player2attack = 1;
        player2speed = 3;
        player2armor = 1;
        break;
}
#endregion


float factor = Random.Shared.Next(-15, 16) / 100f;
float factor2 = Random.Shared.Next(-15, 16) / 100f;
float player1fullattack = (player1attack * player1speed);
float player2fullattack = (player2attack * player2speed);

float player1fullhealth = player1health + player1armor;
float player2fullhealth = player2health + player2armor;



while (player1fullhealth > 0 && player2fullhealth > 0)
{
    player1fullhealth = player1fullhealth - player2attack * (player2speed * (1 + factor));
    player2fullhealth = player2fullhealth - player1attack * (player1speed * (1 + factor2));
    if (player2fullhealth > 0 || player1fullhealth > 0)
    {
        Console.WriteLine("After Round " + rounds++ + ", Player1 got " + player1fullhealth + " health (" + player2fullattack + " Damage) and Player2 got " + player2fullhealth + " health. (" + player1fullattack + " Damage) \nPress any key for the next round.");
        Console.ReadKey();
    }
}

if (player2fullhealth <= 0)
{
    Console.WriteLine("Congratulations, Player 1 won, with the character " + player1 + ".");
}
else if (player1fullhealth <= 0)
{
    Console.WriteLine("Congratulations, Player 2 won, with the character " + player2 + ".");
}

