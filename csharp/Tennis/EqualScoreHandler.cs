namespace Tennis
{
    internal class EqualScoreHandler : IScoreHandler
    {
        public bool CanHandle(Player player1, Player player2)
        {
            return player1.Score == player2.Score;
        }

        public string GetScore(Player player1, Player player2)
        {
            switch (player1.Score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }
    }
}