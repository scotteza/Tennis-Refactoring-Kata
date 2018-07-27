namespace Tennis.ScoreHandlers
{
    internal class EqualScoreHandler : IScoreHandler
    {
        public bool CanHandle(GameScores scores)
        {
            return scores.Score1 == scores.Score2;
        }

        public string GetScore(Player player1, Player player2)
        {
            switch (player1.Score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }
    }
}