namespace Tennis
{
    internal class EqualScoreGameState : GameState
    {
        public EqualScoreGameState(Player player1, Player player2) : base(player1, player2)
        {
        }

        public override string GetScore()
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