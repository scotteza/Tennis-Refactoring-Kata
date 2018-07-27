namespace Tennis.ScoreHandlers
{
    public class GameScores
    {
        public int Score1 { get; }
        public int Score2 { get; }

        public GameScores(int score1, int score2)
        {
            Score1 = score1;
            Score2 = score2;
        }
    }
}
