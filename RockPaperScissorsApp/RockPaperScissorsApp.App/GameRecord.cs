namespace RockPaperScissorsApp.App
{
    public class GameRecord
    {
        public static int PlayerWins { get; set; } = 0;
        public static int ComputerWins { get; set; } = 0;
        public static int Ties { get; set; } = 0;
        public static string Player { get; set; } = "Player";
        
        public static string Record()
        {
            string gameScores = $"\n{Player}: {PlayerWins}\nComputer: {ComputerWins}\nTies: {Ties}";
            return gameScores;
        }
    }
}
