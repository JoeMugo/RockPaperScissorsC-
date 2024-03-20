// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Green;
string inputPlayer, inputCPU;
int randomInt;

bool playAgain = true;

while (playAgain == true)
{
    int scorePlayer = 0;
    int scoreCPU = 0;

    while (scorePlayer < 3 && scoreCPU < 3)
    {
        Console.Write("Choose between ROCK, PAPER and SCISSORS");
        inputPlayer = Console.ReadLine();
        inputPlayer = inputPlayer.ToUpper();

        Random rnd = new Random();

        randomInt = rnd.Next(1, 4);

        switch (randomInt)
        {
            case 1:
                inputCPU = "ROCK";
                Console.WriteLine("Player 2 chose ROCK");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("DRAW!!");
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("You Won!! ");
                    scorePlayer++;
                }
                else if (inputPlayer == "SCISSORS")
            {
                    Console.WriteLine("CPU WON!! ");
                    scoreCPU++;
                }
                break;

            case 2:
                inputCPU = "PAPER";
                Console.WriteLine("Player 2 chose PAPER");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("CPU WON!! ");
                    scoreCPU++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("DRAW!! ");

                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("YOU WON!! ");
                    scorePlayer++;

                }

                break;

            case 3:
                inputCPU = "SCISSORS";
                Console.WriteLine("Player 2 chose ROCK");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("YOU WON!!");
                    scorePlayer++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("CPU WON!!");
                    scoreCPU++;
                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("DRAW!!");

                }

                break;
            default:
                Console.WriteLine("Invalid Entry");
                break;
        }
        Console.WriteLine("\n\nSCORES:\tPLAYER:t{0}\tCPU:t{1}", scorePlayer, scoreCPU);
    }
    if (scorePlayer == 3)
    {
        Console.WriteLine("Congratulations! You Won");
    }
    else if (scoreCPU == 3)
    {
        Console.WriteLine("You Little Looser");
    }

    Console.WriteLine("Do you want to start again? (y/n)");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        playAgain = true;
        Console.Clear();
    }
    else if (loop == "n")
    {
        playAgain = false;
    }

}