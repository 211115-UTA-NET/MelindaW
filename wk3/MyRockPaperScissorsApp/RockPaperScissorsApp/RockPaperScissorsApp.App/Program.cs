// app to play rock-paper-scissors with the computer

// required features:
// - play multiple rounds
// - get a summary/record of all the rounds played so far

// stretch goal features:
// - persistence (save data somehow, it will remember past game history) (and clear history)
// - play more complex variants of RPS (like RPS+lizard+spock)
// - logging (to help with debugging the app if something goes wrong)
// - some way to have more than 2 players at a time
// - support both player vs player and player vs computer
// - difficulty settings for the computer (remembers your moves and tries to predict)

// - in general, we want to write something simple
//    but in a way that allows for extending it / generalizing it in the future.

namespace RockPaperScissorsApp.App
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to RockPaperScissors App");

            var game = new Game();
            var player = new Player();

            Console.WriteLine("Player name?");
            string? name = Console.ReadLine();

            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine();
                Console.WriteLine($"Hello {player.Name}!");
            }
            else
            {
                Console.WriteLine();
                player.Name = name;
                Console.WriteLine($"Hello {player.Name}!");
            }

            Dictionary<int, string> gameType = new Dictionary<int, string>();
            gameType.Add(1, "Rock Paper Scissors");
            gameType.Add(2, "Rock Paper Scissors Spock");

            Console.WriteLine("Select one.");
            Console.WriteLine($"1. {gameType[1]}");
            Console.WriteLine($"2. {gameType[2]}");

            int gameSelection;
            bool isInt = int.TryParse(Console.ReadLine(), out gameSelection);
            if (!isInt && (gameSelection != 1 || gameSelection != 2)) { gameSelection = 1; }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Play a round of {gameType[gameSelection]}? (y/n) ");

                string? input = Console.ReadLine();

                if (input != "y") { break; }
                
                game.PlayRound(gameSelection, player.Name);
            }

            string path = "./Scores.xml";

            string summary = game.Summary;

            XMLScore reader = new XMLScore(summary, path);
            summary = reader.ScoresReader();
            Console.WriteLine(summary);
        }
    }
}
