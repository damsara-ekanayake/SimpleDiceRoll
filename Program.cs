﻿Console.WriteLine(" \t\t --- WELCOME TO THE DICE GAME ---\n");

Random random = new Random();

int playerRandomNumber;
int computerRandomNumber;
int playerWinCount = 0;
int computerWinCount = 0;
bool isPlaying = true;

do
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"\t - ROUND {i + 1} -");
        RollTheDice();
        GetRoundWinner();
        Console.WriteLine("\n****************************************");
        Console.WriteLine();
    }
    GetOverallWinner();
    Console.WriteLine();
    PlayAgain();
} 
while (isPlaying);

Console.ReadKey();

void PlayAgain()
{
        Console.Write("PLAY AGAIN? [Y/N]........");
        var input = Console.ReadLine();

        if (input == "Y" || input == "y")
        {
            playerWinCount = 0;
            computerWinCount = 0;
        }
        else if (input == "N" || input == "n")
        {
            isPlaying = false;
            Console.WriteLine("\n  --- THANKS FOR PLAYING <3 --- \n             ***\n     BY MALFUNCTION SOFTWARE");
        }
        else
        {
            Console.WriteLine("INVALID INPUT. PLEASE TRY AGAIN\n");
            PlayAgain();
        }
}

void RollTheDice()
{
    Console.WriteLine("  Press any key to roll your dice");
    Console.ReadKey();

    playerRandomNumber = random.Next(1, 7);
    Console.WriteLine($"\tPlayer rolled a {playerRandomNumber}");

    Console.WriteLine("\t   ...");
    Thread.Sleep(1000);

    computerRandomNumber = random.Next(1, 7);
    Console.WriteLine($"\tComputer rolled a {computerRandomNumber}\n");
}

void GetRoundWinner()
{
    if (playerRandomNumber > computerRandomNumber)
    {
        playerWinCount++;
        Console.WriteLine("     -- PLAYER WINS! --");
    }
    else if (playerRandomNumber < computerRandomNumber)
    {
        computerWinCount++;
        Console.WriteLine("    -- COMPUTER WINS! -- ");
    }
    else
    {
        Console.WriteLine("         -- DRAW! --");
    }

    Console.WriteLine($"  player : {playerWinCount} \t computer : {computerWinCount}");
}

void GetOverallWinner()
{
    if (playerWinCount > computerWinCount)
    {
        Console.WriteLine("    \" CONGRATULATIONS! YOU WIN \"\n\n****************************************");
    }
    else if (playerWinCount < computerWinCount)
    {
        Console.WriteLine("            \" YOU LOSE! \"\n\n****************************************");
    }
    else 
    {
        Console.WriteLine("\" DRAW! YOU HAVE ONE LAST CHANCE \"");
        RollTheDice();

        if (playerRandomNumber > computerRandomNumber)
        {
            Console.WriteLine("    \" CONGRATULATIONS! YOU WIN \"\n\n****************************************");
        }
        else if (playerRandomNumber < computerRandomNumber)
        {
            Console.WriteLine("            \" YOU LOSE! \"\n\n****************************************");
        }
     
    }
}