using System.Text;

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
            var score = new StringBuilder();
            for (var i = 1; i < 3; i++)
            {
                var tempScore = 0;
                if (i == 1)
                {
                    tempScore = scores.Score1;
                }
                else
                {
                    score.Append("-");
                    tempScore = scores.Score2;
                }

                switch (tempScore)
                {
                    case 0:
                        score.Append("Love");
                        break;
                    case 1:
                        score.Append("Fifteen");
                        break;
                    case 2:
                        score.Append("Thirty");
                        break;
                    case 3:
                        score.Append("Forty");
                        break;
                }
            }

            return score.ToString();
        }
    }
}