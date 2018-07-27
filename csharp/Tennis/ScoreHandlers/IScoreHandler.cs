namespace Tennis.ScoreHandlers
{
    internal interface IScoreHandler
    {
        bool CanHandle(Scores scores);
        string GetScoreDescription(Scores scores);
    }
}
