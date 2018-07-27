using System;

namespace Tennis.ScoreHandlers
{
    internal class WinningScoreHandler : IScoreHandler
    {
        // TODO: move this somewhere else, it is used in 2 classes
        private const int MinimumPerplayerScoreForWinCalculations = 4;
        private const int MinimumScoreDifferenceForWin = 2;

        public bool CanHandle(Scores scores)
        {
            return (scores.Score1 >= MinimumPerplayerScoreForWinCalculations || scores.Score2 >= MinimumPerplayerScoreForWinCalculations)
                    && HasAPlayerWon(scores);
        }

        // TODO: rename?
        private static bool HasAPlayerWon(Scores scores)
        {
            var scoreDifference = Math.Abs(scores.Score1 - scores.Score2);
            return scoreDifference >= MinimumScoreDifferenceForWin;
        }

        public string GetScoreDescription(Scores scores)
        {
            // TODO: pass in player names?
            return scores.Score1 > scores.Score2
                ? "Win for player1"
                : "Win for player2";
        }
    }
}
