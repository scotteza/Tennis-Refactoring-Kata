namespace Tennis.ScoreHandlers
{
    internal interface IScoreHandler
    {
        bool CanHandle(GameScores scores);
        string GetScore(Player player1, Player player2);
    }
}
