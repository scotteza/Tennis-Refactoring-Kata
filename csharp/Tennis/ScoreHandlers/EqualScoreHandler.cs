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
                case 1:
                case 2:
                    return $"{ScoreHelper.GetScoreDescription(scores.Score1)}-All";
                default:
                    return "Deuce";
            }
        }
    }
}