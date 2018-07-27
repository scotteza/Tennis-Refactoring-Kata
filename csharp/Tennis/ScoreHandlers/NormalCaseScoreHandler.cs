namespace Tennis.ScoreHandlers
{
    internal class NormalCaseScoreHandler : IScoreHandler
    {
        public bool CanHandle(Player player1, Player player2)
        {
            // TODO: re think this
            return true;
        }

        public string GetScore(Player player1, Player player2)
        {
            var score = "";
            for (var i = 1; i < 3; i++)
            {
                var tempScore = 0;
                if (i == 1)
                {
                    tempScore = player1.Score;
                }
                else
                {
                    score += "-";
                    tempScore = player2.Score;
                }

                switch (tempScore)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }
            }

            return score;
        }
    }
}