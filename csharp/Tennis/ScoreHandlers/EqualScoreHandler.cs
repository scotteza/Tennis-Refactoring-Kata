namespace Tennis.ScoreHandlers
{
    internal class EqualScoreHandler : IScoreHandler
    {
        public bool CanHandle(Scores scores)
        {
            return scores.Score1 == scores.Score2;
        }

        public string GetScore(Scores scores)
        {
            switch (scores.Score1)
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