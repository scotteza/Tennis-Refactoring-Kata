using System;
using System.Text;
using Tennis.Exceptions;

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
            var score1Description = GetScoreDescription(scores.Score1);
            var score2Description = GetScoreDescription(scores.Score2);

            return $"{score1Description}-{score2Description}";
        }

        private static string GetScoreDescription(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
            }

            throw new ScoreDescriptionNotFoundException($"Score description not found for score {score}");
        }
    }
}