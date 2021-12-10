namespace RockPaperScissorsApp.App
{
    public class Game
    {
        public string Summary
        {
            get
            {
                return GameRecord.Record(); ;
            }
        }
        public void PlayRound(int gameSelection, string name)
        {
            GameRecord.Player = name;
            int userSlection;
            int computerSlection = 0;
            Random random = new Random();
            Dictionary<int, string> gamePlays = new Dictionary<int, string>();
            gamePlays.Add(1, "Rock");
            gamePlays.Add(2, "Paper");
            gamePlays.Add(3, "Scissors");

            if (gameSelection == 1)
            {
                computerSlection = random.Next(1, 4);
                Console.WriteLine();
                Console.WriteLine("Please make a selection.");
                Console.WriteLine($"1. {gamePlays[1]}\n2. {gamePlays[2]}\n3. {gamePlays[3]}");
            }
            else if (gameSelection == 2)
            {
                computerSlection = random.Next(1, 6);
                gamePlays.Add(4, "Lizard");
                gamePlays.Add(5, "Spock");
                Console.WriteLine();
                Console.WriteLine("Please make a selection.");
                Console.WriteLine($"1. {gamePlays[1]}\n2. {gamePlays[2]}\n3. {gamePlays[3]}\n4. {gamePlays[4]}\n5. {gamePlays[5]}");
            }

            bool isInt = int.TryParse(Console.ReadLine(), out userSlection);
            if(userSlection > 3 && gameSelection == 1)
            {
                Console.WriteLine("No valid selection made, please make a valid selection.");
            }

            switch (isInt)
            {
                case true:
                    string message = $"{name}: {gamePlays[userSlection]}\nComputer: {gamePlays[computerSlection]}";
                    if (computerSlection == userSlection)
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("It's a tie!");
                        GameRecord.Ties += 1;
                    }
                    else if (computerSlection == 2 && userSlection == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else if (computerSlection == 3 && userSlection == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else if (computerSlection == 1 && userSlection == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else if (computerSlection == 4 && (userSlection == 2 || userSlection == 5))
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else if (computerSlection == 5 && (userSlection == 1 || userSlection == 3))
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else if (computerSlection == 3 && userSlection == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else if (computerSlection == 2 && userSlection == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else if (computerSlection == 1 && userSlection == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You lost!");
                        GameRecord.ComputerWins += 1;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(message);
                        Console.WriteLine("You win!");
                        GameRecord.PlayerWins += 1;
                    }
                    break;
                case false:
                    Console.WriteLine("No valid selection made, please make a valid selection.");
                    PlayRound(gameSelection, name);
                    break;
            }
        }
    }
}
