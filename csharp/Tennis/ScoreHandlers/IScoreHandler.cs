namespace Tennis.ScoreHandlers
{
    internal interface IScoreHandler
    {
        bool CanHandle(Scores scores);
        string GetScore(Scores scores);
    }
}
