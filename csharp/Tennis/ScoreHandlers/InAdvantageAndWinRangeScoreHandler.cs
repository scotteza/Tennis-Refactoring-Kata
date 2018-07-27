using System;

namespace Tennis.ScoreHandlers
{
    internal class InAdvantageAndWinRangeScoreHandler : IScoreHandler
    {
        // TODO: split this out into two handler classes
        private const int MinimumScoreForAdvantageOrWin = 4;
        private const int MinimumScoreDifferenceForWin = 2;

        public bool CanHandle(Scores scores)
        {
            return scores.Score1 >= MinimumScoreForAdvantageOrWin
                   || scores.Score2 >= MinimumScoreForAdvantageOrWin;
        }

        public string GetScoreDescription(Scores scores)
        {
            var minusResult = GetAdvantageOrWin(scores);

            return minusResult == AdvantageOrWin.Advantage
                ? Advantage(scores)
                : Win(scores);
        }

        private static AdvantageOrWin GetAdvantageOrWin(Scores scores)
        {
            return Math.Abs(scores.Score1 - scores.Score2) >= MinimumScoreDifferenceForWin
                ? AdvantageOrWin.Win
                : AdvantageOrWin.Advantage;
        }

        private static string Advantage(Scores scores)
        {
            return scores.Score1 > scores.Score2
                ? "Advantage player1"
                : "Advantage player2";
        }

        private static string Win(Scores scores)
        {
            return scores.Score1 > scores.Score2
                ? "Win for player1"
                : "Win for player2";
        }

        private enum AdvantageOrWin
        {
            Advantage,
            Win
        }
    }
}