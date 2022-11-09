Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;

const int PIRATE = 1;
const int PIRATEHEALTH = 20;
const int PIRATEATTACK = 3;
const int PIRATESPEED = 3;

const int STONECHEWER = 2;
const int STONECHEWERHEALTH = 50;
const int STONECHEWERATTACK = 8;
const int STONECHEWERSPEED = 1;

const int GHOSTWARRIOR = 3;
const int GHOSTWARRIORHEALTH = 20;
const int GHOSTWARRIORATTACK = 2;
const int GHOSTWARRIORSPEED = 5;

Console.WriteLine("Player 1, press (1) for pirate, (2) for stone chewer or (3) for ghost warrior!");
int player1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Player 2, press (1) for pirate, (2) for stone chewer or (3) for ghost warrior!");
int player2 = int.Parse(Console.ReadLine()!);

int player1health = 0;
int player1attack;
int player1speed;
int player1damage = 0;

int player2health = 0;
int player2attack;
int player2speed;
int player2damage = 0;

if (player1 == PIRATE)
{
    player1health = PIRATEHEALTH;
    player1attack = PIRATEATTACK;
    player1speed = PIRATESPEED;
    player1damage = player1attack * player1speed;
}
else if (player1 == STONECHEWER)
{
    player1health = STONECHEWERHEALTH;
    player1attack = STONECHEWERATTACK;
    player1speed = STONECHEWERSPEED;
    player1damage = player1attack * player1speed;
}
else if (player1 == GHOSTWARRIOR)
{
    player1health = GHOSTWARRIORHEALTH;
    player1attack = GHOSTWARRIORATTACK;
    player1speed = GHOSTWARRIORSPEED;
    player1damage = player1attack * player1speed;
}
else
{
    Console.WriteLine("ERROR");
}

if (player2 == PIRATE)
{
    player2health = PIRATEHEALTH;
    player2attack = PIRATEATTACK;
    player2speed = PIRATESPEED;
    player2damage = player2attack * player2speed;
}
else if (player2 == STONECHEWER)
{
    player2health = STONECHEWERHEALTH;
    player2attack = STONECHEWERATTACK;
    player2speed = STONECHEWERSPEED;
    player2damage = player2attack * player2speed;
}
else if (player2 == GHOSTWARRIOR)
{
    player2health = GHOSTWARRIORHEALTH;
    player2attack = GHOSTWARRIORATTACK;
    player2speed = GHOSTWARRIORSPEED;
    player2damage = player2attack * player2speed;
}
else
{
    Console.WriteLine("ERROR");
}

while (player1health > 0 && player2health > 0)
{
    player1health = player1health - player2damage;
    player2health = player2health - player1damage;
}

if (player1health > 0)
{
    Console.WriteLine("Player 1 wins!");
}
else if (player2health > 0)
{
    Console.WriteLine("Player 2 wins!");
}
else if (player1health < 1 & player2health < 1)
{
    Console.WriteLine("DRAW!");
}

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
