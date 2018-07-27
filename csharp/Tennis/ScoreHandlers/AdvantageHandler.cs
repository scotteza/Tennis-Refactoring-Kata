using System;

namespace Tennis.ScoreHandlers
{
    internal class AdvantageHandler : IScoreHandler
    {
        // TODO: move this somewhere else, it is used in 2 classes
        private const int MinimumPerplayerScoreForAdvantageCalculations = 4;
        private const int ScoreDifferenceForAdvantage = 1;

        public bool CanHandle(Scores scores)
        {
            return (scores.Score1 >= MinimumPerplayerScoreForAdvantageCalculations || scores.Score2 >= MinimumPerplayerScoreForAdvantageCalculations)
                    && IsAPlayerInAdvantage(scores);
        }

        private bool IsAPlayerInAdvantage(Scores scores)
        {
            var scoreDifference = Math.Abs(scores.Score1 - scores.Score2);
            return scoreDifference == ScoreDifferenceForAdvantage;
        }

        public string GetScoreDescription(Scores scores)
        {
            // TODO: pass in player names?
            return scores.Score1 > scores.Score2
                ? "Advantage player1"
                : "Advantage player2";
        }
    }
}