namespace Tennis.ScoreHandlers
{
    internal class NormalCaseScoreHandler : IScoreHandler
    {
        public bool CanHandle(Scores scores)
        {
            // TODO: re think this
            return true;
        }

        public string GetScoreDescription(Scores scores)
        {
            var score1Description = ScoreHelper.GetScoreDescription(scores.Score1);
            var score2Description = ScoreHelper.GetScoreDescription(scores.Score2);

            return $"{score1Description}-{score2Description}";
        }
    }
}