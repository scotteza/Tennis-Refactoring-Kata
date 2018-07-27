namespace Tennis.ScoreHandlers
{
    internal class InAdvantageAndWinRangeScoreHandler : IScoreHandler
    {
        public bool CanHandle(Scores scores)
        {
            return scores.Score1 >= 4 || scores.Score2 >= 4;
        }

        public string GetScore(Scores scores)
        {
            var minusResult = scores.Score1 - scores.Score2;
            if (minusResult == 1)
            {
                return "Advantage player1";
            }
            else if (minusResult == -1)
            {
                return "Advantage player2";
            }
            else if (minusResult >= 2)
            {
                return "Win for player1";
            }
            else
            {
                return "Win for player2";
            }
        }
    }
}