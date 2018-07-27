namespace Tennis.ScoreHandlers
{
    internal class NormalCaseScoreHandler : IScoreHandler
    {
        public bool CanHandle(Scores scores)
        {
            // TODO: re think this
            return true;
        }

        public string GetScore(Scores scores)
        {
            var score = "";
            for (var i = 1; i < 3; i++)
            {
                var tempScore = 0;
                if (i == 1)
                {
                    tempScore = scores.Score1;
                }
                else
                {
                    score += "-";
                    tempScore = scores.Score2;
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