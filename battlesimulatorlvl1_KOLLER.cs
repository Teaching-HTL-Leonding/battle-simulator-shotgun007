Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;

const int PIRATE = 1;
const int PIRATEHEALTH = 20;
const int PIRATEATTACK = 3;
const int PIRATESPEED = 3;
const int PIRATEARMOR = 3;

const int STONECHEWER = 2;
const int STONECHEWERHEALTH = 50;
const int STONECHEWERATTACK = 8;
const int STONECHEWERSPEED = 1;
const int STONECHEWERARMOR = 10;

const int GHOSTWARRIOR = 3;
const int GHOSTWARRIORHEALTH = 20;
const int GHOSTWARRIORATTACK = 2;
const int GHOSTWARRIORSPEED = 5;
const int GHOSTWARRIORARMOR = 2;

const int DARKGOBLIN = 4;
const int DARKGOBLINHEALTH = 10;
const int DARKGOBLINATTACK = 1;
const int DARKGOBLINSPEED = 3;
const int DARKGOBLINARMOR = 8;

const int OUTWORLDER =5 ;
const int OUTWORLDERHEALTH = 15;
const int OUTWORLDERATTACK = 1;
const int OUTWORLDERSPEED = 10;
const int OUTWORLDERARMOR = 2;

const int MONSTERKNIGHT = 6;
const int MONSTERKNIGHTHEALTH = 15;
const int MONSTERKNIGHTATTACK = 4;
const int MONSTERKNIGHTSPEED = 3;
const int MONSTERKNIGHTARMOR = 3;

Console.WriteLine("Player 1, press (1) for pirate, (2) for stone chewer, (3) for ghost warrior, (4) for dark goblin, (5) for outworlder or (6) for monster knight!");
int player1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Player 2, press (1) for pirate, (2) for stone chewer, (3) for ghost warrior, (4) for dark goblin, (5) for outworlder or (6) for monster knight!");
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
    player1health = PIRATEHEALTH + PIRATEARMOR;
    player1attack = PIRATEATTACK;
    player1speed = PIRATESPEED;
    player1damage = player1attack * player1speed;
}
else if (player1 == STONECHEWER)
{
    player1health = STONECHEWERHEALTH + STONECHEWERARMOR;
    player1attack = STONECHEWERATTACK;
    player1speed = STONECHEWERSPEED;
    player1damage = player1attack * player1speed;
}
else if (player1 == GHOSTWARRIOR)
{
    player1health = GHOSTWARRIORHEALTH + GHOSTWARRIORARMOR;
    player1attack = GHOSTWARRIORATTACK;
    player1speed = GHOSTWARRIORSPEED;
    player1damage = player1attack * player1speed;
}
else if (player1 == DARKGOBLIN)
{
    player1health = DARKGOBLINHEALTH + DARKGOBLINARMOR;
    player1attack = DARKGOBLINATTACK;
    player1speed = DARKGOBLINSPEED;
    player1damage = player1attack * player1speed;
}
else if (player1 == OUTWORLDER)
{
    player1health = OUTWORLDERHEALTH + OUTWORLDERARMOR;
    player1attack = OUTWORLDERATTACK;
    player1speed = OUTWORLDERSPEED;
    player1damage = player1attack * player1speed;
}
else if (player1 == MONSTERKNIGHT)
{
    player1health = MONSTERKNIGHTHEALTH + MONSTERKNIGHTARMOR;
    player1attack = MONSTERKNIGHTATTACK;
    player1speed = MONSTERKNIGHTSPEED;
    player1damage = player1attack * player1speed;
}
else
{
    Console.WriteLine("ERROR");
}

if (player2 == PIRATE)
{
    player2health = PIRATEHEALTH + PIRATEARMOR;
    player2attack = PIRATEATTACK;
    player2speed = PIRATESPEED;
    player2damage = player2attack * player2speed;
}
else if (player2 == STONECHEWER)
{
    player2health = STONECHEWERHEALTH + STONECHEWERARMOR;
    player2attack = STONECHEWERATTACK;
    player2speed = STONECHEWERSPEED;
    player2damage = player2attack * player2speed;
}
else if (player2 == GHOSTWARRIOR)
{
    player2health = GHOSTWARRIORHEALTH + GHOSTWARRIORARMOR;
    player2attack = GHOSTWARRIORATTACK;
    player2speed = GHOSTWARRIORSPEED;
    player2damage = player2attack * player2speed;
}
else if (player2 == DARKGOBLIN)
{
    player1health = DARKGOBLINHEALTH + DARKGOBLINARMOR;
    player2attack = DARKGOBLINATTACK;
    player2speed = DARKGOBLINSPEED;
    player2damage = player2attack * player2speed;
}
else if (player2 == OUTWORLDER)
{
    player2health = OUTWORLDERHEALTH + OUTWORLDERARMOR;
    player2attack = OUTWORLDERATTACK;
    player2speed = OUTWORLDERSPEED;
    player2damage = player2attack * player2speed;
}
else if (player2 == MONSTERKNIGHT)
{
    player2health = MONSTERKNIGHTHEALTH + MONSTERKNIGHTARMOR;
    player2attack = MONSTERKNIGHTATTACK;
    player2speed = MONSTERKNIGHTSPEED;
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

