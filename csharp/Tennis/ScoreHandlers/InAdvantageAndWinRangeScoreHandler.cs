namespace Tennis.ScoreHandlers
{
    internal class InAdvantageAndWinRangeScoreHandler : IScoreHandler
    {
        public bool CanHandle(Player player1, Player player2)
        {
            return player1.Score >= 4 || player2.Score >= 4;
        }

        public string GetScore(Player player1, Player player2)
        {
            var minusResult = player1.Score - player2.Score;
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