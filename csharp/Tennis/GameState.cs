namespace Tennis
{
    internal interface IGameState
    {
        bool CanHandle(Player player1, Player player2);
        string GetScore(Player player1, Player player2);
    }
}
