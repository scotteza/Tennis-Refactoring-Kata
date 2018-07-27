using Tennis.Exceptions;

namespace Tennis
{
    // TODO: this is a temporary step, this class will be refactored (removed) later
    public static class ScoreHelper
    {
        public static string GetScoreDescription(int score)
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
